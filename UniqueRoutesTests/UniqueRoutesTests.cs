using Trains;

namespace UniqueRoutesTests
{
    public class URTests
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

        //Test output 6
        [Test]
        public void Test6()
        {
            if (trainNetwork.UniqueRoutes("C", "C", 3, false) == 2) Assert.Pass();
            Assert.Fail("UniqueRoutes(\"C\", \"C\", 3, false) Failed. EV: 2, AV: " + trainNetwork.UniqueRoutes("C", "C", 3, false));
        }


        //Test output 7
        [Test]
        public void Test7()
        {
            if (trainNetwork.UniqueRoutes("A", "C", 4, true) == 3) Assert.Pass();
            Assert.Fail("UniqueRoutes(\"A\", \"C\", 4, true) Failed. EV: 3, AV: " + trainNetwork.UniqueRoutes("A", "C", 4, true));
        }

        //Test output 10
        [Test]
        public void Test10()
        {
            if (trainNetwork.UniqueRoutes("C", "C", 30) == 7) Assert.Pass();
            Assert.Fail("UniqueRoutes(\"C\", \"C\", 30) Failed. EV: 7, AV: " + trainNetwork.UniqueRoutes("C", "C", 30));
        }
    }
}