using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trains
{
    public partial class NetworkSim : Form
    {
        TrainNetwork tn;
        int[,] weights;
        string[] towns;
        public NetworkSim(TrainNetwork tn) 
        {
            InitializeComponent();
            this.tn = tn;
            weights = tn.GetWeights();
            towns = tn.GetTowns();
            weightsTable.Rows.Clear();
            weightsTable.Columns.Clear();
            weightsTable.ColumnCount = weights.GetLength(1);
            weightsTable.RowCount = weights.GetLength(0);

            for(int i = 0; i < weights.GetLength(0); i++)
            {
                for(int j = 0; j < weights.GetLength(1); j++)
                {
                    weightsTable[i,j].Value = weights[i, j];
                }
            }
            for(int i = 0; i < weights.GetLength(0); i++)
            {
                weightsTable.Columns[i].HeaderText = "(Start) " + towns[i];
                weightsTable.Rows[i].HeaderCell.Value = "(Stop) " + towns[i];

                startDrop.Items.Add(towns[i]);
                startDrop2.Items.Add(towns[i]);
                stopDrop.Items.Add(towns[i]);
                stopDrop2.Items.Add(towns[i]);
            }

            exactDrop.Items.Add("Exact Stops");
            exactDrop.Items.Add("Any Stops");
            exactDrop.Items.Add("Max Distance");

            for (int i = 1; i <= 30; i++)
                numberDrop.Items.Add(i);
        }



        private void GenRouteDist_Click(object sender, EventArgs e)
        {
            routeDistOutput.Text = tn.RouteDistance(routeDistInput.Text).ToString();
            if (routeDistOutput.Text.Equals("-1")) routeDistOutput.Text = "NO SUCH ROUTE";
        }

        private void GenUnique_Click(object sender, EventArgs e)
        {
            string start = "";
            string stop = "";
            int dist = 0;
            try
            {
                start = this.startDrop.GetItemText(this.startDrop.SelectedItem);
                stop = this.stopDrop.GetItemText(this.stopDrop.SelectedItem);
                dist = Convert.ToInt32(this.numberDrop.GetItemText(this.numberDrop.SelectedItem));
            }
            catch(Exception ex) { }
            if (this.exactDrop.GetItemText(this.exactDrop.SelectedItem).Equals("Exact Stops"))
            {
                uniqueOutput.Text = tn.UniqueRoutes(start, stop, dist, true).ToString();
                
            }
            else if (this.exactDrop.GetItemText(this.exactDrop.SelectedItem).Equals("Max Distance"))
            {
                uniqueOutput.Text = tn.UniqueRoutes(start, stop, dist).ToString();
            }
            else
            {
                uniqueOutput.Text = tn.UniqueRoutes(start, stop, dist, false).ToString();
            }
            if (uniqueOutput.Text.Equals("-1")) uniqueOutput.Text = "NO SUCH ROUTE";
        }

        private void GenShortRoute_Click(object sender, EventArgs e)
        {
            string start = this.startDrop2.GetItemText(this.startDrop2.SelectedItem);
            string stop = this.stopDrop2.GetItemText(this.stopDrop2.SelectedItem);

            shortOutput.Text = tn.ShortestRoute(start, stop).ToString();
            if (shortOutput.Text.Equals("-1")) shortOutput.Text = "NO SUCH ROUTE";

        }
    }
}
