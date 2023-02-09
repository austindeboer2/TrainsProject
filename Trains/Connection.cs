using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    /*
     * Class, Connection, structures a single network connection to be used in 
     * making the TrainNetwork.
     */
    public class Connection
    {
        //Starting town for the train connection
        private string start { get; }
        
        //Ending town for the train connection, cannot be the same as the starting town
        private string end { get; }
        
        //Weight on this connection
        private int weight { get; }

        /*
         * Connection Constructor
         * Parameters:
         *      String containing the starting town for the connection
         *      String containing the ending town for the connection
         *      Int containing the weight of the connection
         *      
         *  Function:
         *      Creates a connection object that has all the needed information for
         *      that particular route.
         */
        public Connection(string start, string end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }   

        /*
         * Getters for all the private variables
         */
        public string GetStart() { return start; }

        public string GetEnd() { return end; }  

        public int GetWeight() { return weight; }
    }
}
