using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Trains
{
    /*
     * Creates the starting form to fill out what qualities you want your 
     * train network to have.
     */
    public partial class Form1 : Form
    {
        //Keeps track of the user made towns and connections
        List<string> towns;
        List<Connection> connections;
        public Form1()
        {
            InitializeComponent();
            towns = new List<string>();
            connections = new List<Connection>();

            //Adds weight options to the dropdown
            for(int i = 1; i <= 30; i++)
                weightConnect.Items.Add(i);
        }

        private void AddTownBtn_Click(object sender, EventArgs e)
        {
            //Makes sure that the user is not trying to add a black town name
            if (!newTown.Text.Equals(""))
            {
                //adds the name to the towns list
                towns.Add(newTown.Text);

                //resets the textbox
                townsList.Text = "";

                //Replaces all the towns in order they were created
                foreach (string t in towns)
                {
                    townsList.AppendText(t);
                    townsList.AppendText(Environment.NewLine);
                }

                //Adds options to the connections dropboxes
                startConnect.Items.Add(newTown.Text);
                stopConnect.Items.Add(newTown.Text);

                //Deletes the text used to add town name
                newTown.Text = "";
            }
        }

        //Generate Network Btn
        private void GenNetwork_Click(object sender, EventArgs e)
        {
            //Only lets you generate the network if there is at least one town name in the list
            if (towns.Count != 0)
            {
                //Opens the network simulation form with the given information
                this.Hide();
                NetworkSim sim = new NetworkSim(new TrainNetwork(towns, connections));
                sim.Show();
            }
        }

        //Add Connection Btn
        private void AddConnection_Click(object sender, EventArgs e)
        {
            string start = this.startConnect.GetItemText(this.startConnect.SelectedItem);
            string stop = this.stopConnect.GetItemText(this.stopConnect.SelectedItem);
            if (start != "" && stop != "")
            {
                try
                {
                    //Trys the code just incase a number is not selected properly so the app doesnt crash
                    int weight = 0;
                    weight = Convert.ToInt32(this.weightConnect.GetItemText(this.weightConnect.SelectedItem));


                    //Bad connections will be deleted when the network is created
                    if (weight != 0) connections.Add(new Connection(start, stop, weight));

                    connectionText.Text = "";
                    //Adds all the connections for the user to see
                    //Adds all the connections for the user to see
                    foreach (Connection c in connections)
                    {
                        connectionText.AppendText("Start: " + c.GetStart() + " Stop: " + c.GetEnd() + " Weight: " + c.GetWeight());
                        connectionText.AppendText(Environment.NewLine);
                    }

                }
                catch (Exception exc)
                {

                }
            }
            
        }
    }
}