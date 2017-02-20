using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MidTermAssgnment_200328630
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void GenerateAbilities()
        {
            STRTextBox.Text = this.Roll3D10().ToString();
            DEXTextBox.Text = this.Roll3D10().ToString();
            ENDTextBox.Text = this.Roll3D10().ToString();
            INTTextBox.Text = this.Roll3D10().ToString();
            PERTextBox.Text = this.Roll3D10().ToString();
            CHATextBox.Text = this.Roll3D10().ToString();



        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());
            GenerateAbilities();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = STRTextBox.Text;
            character.Dexterity = DEXTextBox.Text;
            character.Endurance = ENDTextBox.Text;
            character.Intelligence = INTTextBox.Text;
            character.Perception = PERTextBox.Text;
            character.Charisma = CHATextBox.Text;

            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }
    }
}
