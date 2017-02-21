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

    /// <summary>
    /// Program: Midterm DND Character Creator
    /// Name: Justin Schieck
    /// StudentID: 200328630
    /// App Creation Date: Feb 20, 2013
    /// App Desc: Creates a character used for RPG adventures
    /// </summary>
    /// 
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

        //In essence rolls 3, 10 sided die and inputs the string value into appropriate text boxes
        private void GenerateAbilities()
        {
         
                    STRTextBox.Text = this.Roll3D10().ToString();
                    DEXTextBox.Text = this.Roll3D10().ToString();
                    ENDTextBox.Text = this.Roll3D10().ToString();
                    INTTextBox.Text = this.Roll3D10().ToString();
                    PERTextBox.Text = this.Roll3D10().ToString();
                    CHATextBox.Text = this.Roll3D10().ToString();
            
      }

        // Calls the Generate Abilities method
        private void RollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());
            GenerateAbilities();
        }

        //Inputs the proper information to Character.cs then switches the forms. Uses try Catch for validation
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            try
            {
                           
                 character.Strength = STRTextBox.Text;
                 character.Dexterity = DEXTextBox.Text;
                 character.Endurance = ENDTextBox.Text;
                 character.Intelligence = INTTextBox.Text;
                 character.Perception = PERTextBox.Text;
                 character.Charisma = CHATextBox.Text;

                if(STRTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (DEXTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (ENDTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (INTTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (PERTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (CHATextBox.Text == "")
                {
                    throw new Exception();
                }
            }
            //Catches if line is blank and asks to fill with a response in text boxes.
            catch(Exception) 
            {
                MessageBox.Show("Please fill in a valid Response or press roll");
                return;
            }

            //Hides current form and moves to the next form in order.
            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }
    }
}
