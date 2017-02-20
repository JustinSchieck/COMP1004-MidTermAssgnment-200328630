using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MidTermAssgnment_200328630
{
    public partial class JobForm : Form
    {

        public RaceForm previousForm;


        public JobForm()
        {
            InitializeComponent();
        }

        private void HealthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked)
            {
                HealthTextBox.Text = "30" + Program.Character.Endurance;
            }
        }
    }
}
