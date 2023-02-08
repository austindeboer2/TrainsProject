using Trains;

namespace ShortestRouteTests
{
    public class SRTests
    {
        //Towns that exist in test network
        List<string> towns;
        //Connections that exist in test network
        List<Connection> connections;
        //Test trainNetwork
        TrainNetwork trainNetwork;

        [SetUp]
        public void Setup()
        {
            //Adding towns
            towns = new List<string>();
            towns.Add("A");
            towns.Add("B");
            towns.Add("C");
            towns.Add("D");
            towns.Add("E");

            //Adding connections
            connections = new List<Connection>();
            connections.Add(new Connection("A", "B", 5));
            connections.Add(new Connection("B", "C", 4));
            connections.Add(new Connection("C", "D", 8));
            connections.Add(new Connection("D", "C", 8));
            connections.Add(new Connection("D", "E", 6));
            connections.Add(new Connection("A", "D", 5));
            connections.Add(new Connection("C", "E", 2));
            connections.Add(new Connection("E", "B", 3));
            connections.Add(new Connection("A", "E", 7));

            //Creating the network from the towns and connections
            trainNetwork = new TrainNetwork(towns, connections);
        }

        //Test output 8
        [Test]
        public void Test8()
        {
            if (trainNetwork.ShortestRoute("A", "C") == 9) Assert.Pass();
            Assert.Fail("ShortestRoute(\"A\", \"C\") Failed. EV: 9, AV: " + trainNetwork.ShortestRoute("A", "C"));
        }

        //Test output 9
        [Test]
        public void Test9()
        {
            if (trainNetwork.ShortestRoute("B", "B") == 9) Assert.Pass();
            Assert.Fail("ShortestRoute(\"B\", \"B\") Failed. EV: 9, AV: " + trainNetwork.ShortestRoute("B", "B"));
        }
    }
}