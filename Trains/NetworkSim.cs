using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trains
{
    public partial class NetworkSim : Form
    {
        TrainNetwork tn;
        public NetworkSim(TrainNetwork tn) 
        {
            InitializeComponent();
            this.tn = tn;
        }
    }
}
