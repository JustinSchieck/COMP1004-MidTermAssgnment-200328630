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
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();

            aboutbox.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer...");
        }

        private void RaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            Stats();
        }


        public void Stats()
        {
            HealthTextBox.Text = Program.character.Health;
            RaceTextBox.Text = Program.character.Race;
            STRTextBox.Text = Program.character.Strength;
            DEXTextBox.Text = Program.character.Dexterity;
            ENDTextBox.Text = Program.character.Endurance;
            INTTextBox.Text = Program.character.Intelligence;
            PERTextBox.Text = Program.character.Perception;
            CHATextBox.Text = Program.character.Charisma;
        }

        
    }
}
