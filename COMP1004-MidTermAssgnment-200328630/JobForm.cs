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

        private string _soldierHealth = "30";
        private string _rogueHealth = "28";
        private string _magickerHealth = "15";
        private string _cultistHealth = "24";


        public JobForm()
        {
            InitializeComponent();
        }

        private void HealthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked)
            {
                HealthTextBox.Text = _soldierHealth + Program.Character.Endurance;
            }
            else if (RogueRadioButton.Checked)
            {
                HealthTextBox.Text = _rogueHealth + Program.Character.Dexterity;
            }
            else if (MagickerRadioButton.Checked)
            {
                HealthTextBox.Text = _magickerHealth + Program.Character.Intelligence;
            }
            else if (CultistRadioButton.Checked)
            {
                HealthTextBox.Text = _cultistHealth + Program.Character.Charisma;
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

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
