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

    /// <summary>
    /// Program: Midterm DND Character Creator
    /// Name: Justin Schieck
    /// StudentID: 200328630
    /// App Creation Date: Feb 20, 2013
    /// App Desc: Creates a character used for RPG adventures
    /// </summary>
    /// 

    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //About form display
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();

            aboutbox.ShowDialog();
        }

        //Font form Display
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();
        }

        //Fake Print Message
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer...");
        }

        //Calls the variable that fills all the read only text boxes with information gathered from other forms
        //Done this way instead of one at a time to maximize cpu and uses less space.
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Stats();
        }

        //Function that fills appropriate text boxes
        public void Stats()
        {
            HealthTextBox.Text = Program.character.Health;
            RaceTextBox.Text = Program.character.Race;
            JobTextBox.Text = Program.character.Job;
            STRTextBox.Text = Program.character.Strength;
            DEXTextBox.Text = Program.character.Dexterity;
            ENDTextBox.Text = Program.character.Endurance;
            INTTextBox.Text = Program.character.Intelligence;
            PERTextBox.Text = Program.character.Perception;
            CHATextBox.Text = Program.character.Charisma;
        }

        
    }
}
