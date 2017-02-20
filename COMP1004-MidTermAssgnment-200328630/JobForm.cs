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
            else if (RogueRadioButton.Checked)
            {
                HealthTextBox.Text = "28" + Program.Character.Dexterity;
            }
            else if (MagickerRadioButton.Checked)
            {
                HealthTextBox.Text = "15" + Program.Character.Intelligence;
            }
            else if (CultistRadioButton.Checked)
            {
                HealthTextBox.Text = "24" + Program.Character.Charisma;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();

            character.Health = HealthTextBox.Text;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
    }
}
