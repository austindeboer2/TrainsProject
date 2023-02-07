using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    /*
     * Class, TrainNetwork, contains all the information about the train network.
     * This information is then used to provide methods to determine route distance, 
     * unique routes between towns, and the shortest route between towns. 
     */
    internal class TrainNetwork
    {
        //Array of towns, listed as strings
        private string[] towns;

        //2D array that keeps track of the weights and routes between towns
        private int[,] weights;


        /*
         * TrainNetwork Constructor
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
            towns = townsL.ToArray();

            //Instatiates weights to a square 2D array with sides the same length as towns.
            //All default values are set to 0.
            this.weights = new int[connections.Count, connections.Count];

            foreach(Connection c in connections)
            {
                int start = 0;
                int end = 0;
                int weight = 0;

                //Loops though all the towns to make sure the correct towns are recorded 
                //to mark the weight in the table.
                for(int i = 0; i < towns.Length; i++)
                {
                    if (c.GetStart().Equals(towns[i])) start = i;
                    if(c.GetEnd().Equals(towns[i])) end = i;
                }

                //Checks to make sure that a bad connection was not given with that same
                //starting and ending location
                if(start != end)
                {
                    //Sets the weight of the connection in the corresponding space in the weights array.
                    weights[start, end] = weight;
                }

            }
        }

        /*
         * RouteDistance(string) - calculates the weight of traveling on the given route
         * Parameter:
         *      string - a string of town names in the order that they will be traveled. 
         *      Towns should have a '-' in between each other without any spaces.
         * Return:
         *      int - the weight value of traveling along the given route.
         *            -1 will be returned if the route does not exist.
         */

        /*
         * public int RouteDistance(string route)
         * {
         * 
         * }
         */
    }
}
