using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Trains
{
    public partial class Form1 : Form
    {
        List<string> towns;
        List<Connection> connections;
        public Form1()
        {
            InitializeComponent();
            towns = new List<string>();
            connections = new List<Connection>();
            for(int i = 1; i <= 30; i++)
                weightConnect.Items.Add(i);
        }

        private void AddTownBtn_Click(object sender, EventArgs e)
        {
            if (!newTown.Text.Equals(""))
            {
                towns.Add(newTown.Text);

                townsList.Text = "";

                foreach (string t in towns)
                {
                    townsList.AppendText(t);
                    townsList.AppendText(Environment.NewLine);
                }

                startConnect.Items.Add(newTown.Text);
                stopConnect.Items.Add(newTown.Text);
                newTown.Text = "";
            }
        }

        private void GenNetwork_Click(object sender, EventArgs e)
        {
            this.Hide();
            NetworkSim sim = new NetworkSim(new TrainNetwork(towns, connections));
            sim.Show();
        }

        private void AddConnection_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = 0;
                weight = Convert.ToInt32(this.weightConnect.GetItemText(this.weightConnect.SelectedItem));


                //Bad connections will be deleted when the network is created
                if(weight != 0) connections.Add(new Connection(this.startConnect.GetItemText(this.startConnect.SelectedItem), this.stopConnect.GetItemText(this.stopConnect.SelectedItem), weight));

                connectionText.Text = "";
                foreach(Connection c in connections)
                {
                    connectionText.AppendText("Start: " + c.GetStart() + " Stop: " + c.GetEnd() + " Weight: " + c.GetWeight());
                    connectionText.AppendText(Environment.NewLine);
                }
                
            }
            catch(Exception exc)
            {

            }
            
        }
    }
}