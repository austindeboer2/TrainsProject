using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    /* Class, TrainNetwork
     * contains all the information about the train network.
     * This information is then used to provide methods to determine route distance, 
     * unique routes between towns, and the shortest route between towns. 
     */
    internal class TrainNetwork
    {
        //Array of towns, listed as strings
        private string[] towns;

        //2D array that keeps track of the weights and routes between towns
        private int[,] weights;

        /* TrainNetwork Constructor
         * 
         * Parameters:
         *      List<string> containing all the town names that are included in the network
         *      List<Connection> containing all of the one way town connections with weights
         *      
         *  Function:
         *      Creates arrays from the arguments to make a network that 
         *      can be manipulated though the class methods.
         */
        public TrainNetwork(List<string> townsL, List<Connection> connections)
        {
            towns = new string[townsL.Count];
            for (int i = 0; i < townsL.Count; i++)
            {
                towns[i] = townsL[i].ToString();
            }


            //Instatiates weights to a square 2D array with sides the same length as towns.
            //All default values are set to 0.
            weights = new int[towns.Length, towns.Length];

            foreach (Connection c in connections)
            {
                int start = 0;
                int end = 0;

                //Loops though all the towns to make sure the correct towns are recorded 
                //to mark the weight in the table.
                for (int i = 0; i < towns.Length; i++)
                {
                    if (c.GetStart().Equals(towns[i])) start = i;
                    if (c.GetEnd().Equals(towns[i])) end = i;
                }

                //Checks to make sure that a bad connection was not given with that same
                //starting and ending location
                if (start != end)
                {
                    //Sets the weight of the connection in the corresponding space in the weights array.
                    weights[start, end] = c.GetWeight();
                }

            }
        }

        /* RouteDistance(string)
         * Calculates the weight of traveling on the given route
         * Parameter:
         *      string, route - a string of town names in the order that they will be traveled. 
         *      Towns should have a '-' in between each other without any spaces.
         * Return:
         *      int - the weight value of traveling along the given route.
         *            -1 will be returned if the route does not exist.
         */
        public int RouteDistance(string route)
        {
            int distance = 0;
            //Splits the given route into individual towns to visit in a string[].
            //Where locations[0] will be the starting location, locations[1] will be the first stop etc.
            string[] locations = route.Split('-');

            //Copy of locations to hold the numeric values of the towns
            int[] locationNumbers = new int[locations.Length];

            //Loops through all the locations to asign them their numeric values
            for (int i = 0; i < locations.Length; i++)
            {
                //Used to make sure a town is found
                bool found = false;
                //Loops through all the towns to check where they exist
                for (int j = 0; j < towns.Length; j++)
                {
                    //Checks if the town was found at index j
                    if (locations[i].Equals(towns[j]))
                    {
                        //Assignes the numeric value of the town to the array
                        locationNumbers[i] = j;
                        //Assigns that the town has been found
                        found = true;
                    }
                }

                //If no town with the same name is found the route cannot exist
                if (found == false) return -1;
            }

            //Loops through all the needed connections to establish the total distance.
            for (int k = 1; k < locationNumbers.Length; k++)
            {
                //checks to see if a route exists between locations
                if (weights[locationNumbers[k - 1], locationNumbers[k]] == 0) return -1;

                //adds the distance between given locations
                distance += weights[locationNumbers[k - 1], locationNumbers[k]];
            }

            return distance;
        }


        /* UniqueRoutes(string, string, int, bool)
         * Calculates the number of unique routes between two different locations. 
         * Parameter:
         *      string, start - The starting town for the routes to begin
         *      string, stop - The ending town for the routes to end
         *      int, maxStops - the maximum number of stops allowed in a route, including the ending town.
         *      bool, exactStops - When true the number of routes returned will be only the number of routes 
         *                         that have the exact amount of max stops allowed. When false the number 
         *                         of routes returned will be for all routes at or under the max stops allowed.
         * Return:
         *      int - The number of routes that are possible given the start and stop town.
         */
        public int UniqueRoutes(string start, string stop, int maxStops, bool exactStops)
        {
            //Sets the integer beginning and end to -1 to make sure we have actual towns the train visits
            int begin = -1;
            int end = -1;

            //Loops through the given towns to figure out what index that are equal to
            for (int i = 0; i < towns.Length; i++)
            {
                if (start.Equals(towns[i])) begin = i;
                if (stop.Equals(towns[i])) end = i;
            }
            //Verifies we have good towns, returns -1 if the towns do not exist
            if (begin == -1 || end == -1) return -1;

            //Calls the recursive sister function UniqueRoutes(int, int, int, bool) that will systematically
            //go throught the weights array figuring out how many ways to reach the 'stop' town.
            return UniqueRoutes(begin, end, maxStops, exactStops);

      
        }

        /* UniqueRoutes(int, int, int, bool)
         * Recursivly calculates the number of unique routes between two different locations. 
         * Parameter:
         *      int, start - The index of the starting town for the routes to begin
         *      int, stop - The index of the ending town for the routes to end
         *      int, maxStops - the maximum number of stops allowed in a route, including the ending town.
         *      bool, exactStops - When true the number of routes returned will be only the number of routes 
         *                         that have the exact amount of max stops allowed. When false the number 
         *                         of routes returned will be for all routes at or under the max stops allowed.
         * Return:
         *      int - The number of routes that are possible given the start and stop town.
         */
        public int UniqueRoutes(int start, int stop, int maxStops, bool exactStops)
        {
            if (maxStops == 0) return 0;

            int routeCount = 0;

            for (int i = 0; i < weights.GetLength(1); i++)
            {
                if (weights[start, i] != 0)
                {
                    if(i == stop)
                    {
                        if (exactStops)
                        {
                            if(maxStops == 1) routeCount++;
                        }
                        else routeCount++;
                        routeCount += UniqueRoutes(i, stop, maxStops - 1, exactStops);
                    }
                    else
                    {
                        routeCount += UniqueRoutes(i, stop, maxStops - 1, exactStops);
                    }
                }
            }
            return routeCount;
        }

        /* UniqueRoutes(string, string, int)
         * Calculates the number of unique routes between two different locations with a weight less than 'maxDistance' 
         * Parameter:
         *      string, start - The starting town for the routes to begin
         *      string, stop - The ending town for the routes to end
         *      int, maxStops - the maximum weight allowed in a route
         *      
         * Return:
         *      int - The number of routes that are possible given the start town, stop town, and distance allowed.
         */
        //TODO:
        public int UniqueRoutes(string start, string stop, int maxDistance)
        {
            return 0;//Temp
        }



        /* ShortestRoute(string, string)
        * Calculates the weight of the shortest route between two different locations. 
        * Parameter:
        *      string, start - The starting town for the routes to begin
        *      string, stop - The ending town for the routes to end
        *      
        * Return:
        *      int - The weight of the shortest route between the start and stop towns.
        */
        //TODO:
        public int ShortestRoute(string start, string stop)
        {
            return 0;//Temp
        }
    }
}
