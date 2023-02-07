using Trains;

namespace RouteDistanceTests
{
    public class RDTests
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

        //Test output 1
        [Test]
        public void Test1()
        {
            if(trainNetwork.RouteDistance("A-B-C") == 9) Assert.Pass();
            Assert.Fail("RouteDistance(\"A-B-C\") Failed. EV: 9, AV: " + trainNetwork.RouteDistance("A-B-C"));
        }

        //Test output 2
        [Test]
        public void Test2()
        {
            if (trainNetwork.RouteDistance("A-D") == 5) Assert.Pass();
            Assert.Fail("RouteDistance(\"A-D\") Failed. EV: 5, AV: " + trainNetwork.RouteDistance("A-D"));
        }

        //Test output 3
        [Test]
        public void Test3()
        {
            if (trainNetwork.RouteDistance("A-D-C") == 13) Assert.Pass();
            Assert.Fail("RouteDistance(\"A-D-C\") Failed. EV: 13, AV: " + trainNetwork.RouteDistance("A-D-C"));
        }

        //Test output 4
        [Test]
        public void Test4()
        {
            if (trainNetwork.RouteDistance("A-E-B-C-D") == 22) Assert.Pass();
            Assert.Fail("RouteDistance(\"A-E-B-C-D\") Failed. EV: 22, AV: " + trainNetwork.RouteDistance("A-E-B-C-D"));
        }

        //Test output 5
        [Test]
        public void Test5()
        {
            if (trainNetwork.RouteDistance("A-E-D") == -1) Assert.Pass();
            Assert.Fail("RouteDistance(\"A-E-D\") Failed. EV: -1, AV: " + trainNetwork.RouteDistance("A-E-D"));
        }
    }
}