using Trains;

namespace AdditionalTests
{
    public class AdditionalTests
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
            towns.Add("Grand Rapids");
            towns.Add("Rockford");
            towns.Add("Detroit");
            towns.Add("Lansing");
            towns.Add("Grant");
            towns.Add("Big Rapids");

            //Adding connections
            connections = new List<Connection>();
            connections.Add(new Connection("Grand Rapids", "Rockford", 3));
            connections.Add(new Connection("Grand Rapids", "Detroit", 5));
            connections.Add(new Connection("Grand Rapids", "Grant", 5));
            connections.Add(new Connection("Rockford", "Detroit", 4));
            connections.Add(new Connection("Detroit", "Lansing", 3));
            connections.Add(new Connection("Lansing", "Grant", 4));
            connections.Add(new Connection("Grant", "Big Rapids", 3));
            connections.Add(new Connection("Big Rapids", "Grand Rapids", 4));

            //Creating the network from the towns and connections
            trainNetwork = new TrainNetwork(towns, connections);
        }

        //Test output 11
        [Test]
        public void Test11()
        {
            if (trainNetwork.RouteDistance("Grand Rapids-Detroit-Lansing") == 8) Assert.Pass();
            Assert.Fail("RouteDistance(\"Grand Rapids-Detroit-Lansing\") Failed. EV: 8, AV: " + trainNetwork.RouteDistance("Grand Rapids-Detroit-Lansing"));
        }

        //Test output 12
        [Test]
        public void Test12()
        {
            if (trainNetwork.UniqueRoutes("Grand Rapids", "Detroit", 3, false) == 2) Assert.Pass();
            Assert.Fail("UniqueRoutes(\"Grand Rapids\", \"Detroit\", 3, false) Failed. EV: 2, AV: " + trainNetwork.UniqueRoutes("Grand Rapids", "Detroit", 3, false));
        }

        //Test output 13
        [Test]
        public void Test13()
        {
            if (trainNetwork.UniqueRoutes("Grand Rapids", "Detroit", 25) == 5) Assert.Pass();
            Assert.Fail("UniqueRoutes(\"Grand Rapids\", \"Detroit\", 25) Failed. EV: 5, AV: " + trainNetwork.UniqueRoutes("Grand Rapids", "Detroit", 25));
        }

        //Test output 14
        [Test]
        public void Test14()
        {
            if (trainNetwork.ShortestRoute("Big Rapids", "Grant") == 9) Assert.Pass();
            Assert.Fail("ShortestRoute(\"Big Rapids\", \"Grant\") Failed. EV: 9, AV: " + trainNetwork.ShortestRoute("Big Rapids", "Grant"));
        }

        //Test output 15
        [Test]
        public void Test15()
        {
            if (trainNetwork.ShortestRoute("Big Rapids", "Detroit") == 9) Assert.Pass();
            Assert.Fail("ShortestRoute(\"Big Rapids\", \"Detroit\") Failed. EV: 9, AV: " + trainNetwork.ShortestRoute("Big Rapids", "Detroit"));
        }

        //Test output 16
        [Test]
        public void Test16()
        {
            if (trainNetwork.ShortestRoute("Big Rapids", "Lansing") == 12) Assert.Pass();
            Assert.Fail("ShortestRoute(\"Big Rapids\", \"Lansing\") Failed. EV: 12, AV: " + trainNetwork.ShortestRoute("Big Rapids", "Lansing"));
        }

        //Test output 17
        [Test]
        public void Test17()
        {
            if (trainNetwork.ShortestRoute("Big Rapids", "Big Rapids") == 12) Assert.Pass();
            Assert.Fail("ShortestRoute(\"Big Rapids\", \"Big Rapids\") Failed. EV: 12, AV: " + trainNetwork.ShortestRoute("Big Rapids", "Big Rapids"));
        }
    }
}