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

    public partial class JobForm : Form
    {
        //Instance Variables
        public RaceForm previousForm;

        private int _soldierHealth = 30;
        private int _rogueHealth = 28;
        private int _magickerHealth = 15;
        private int _cultistHealth = 24;
        private string _RaceSelect;

        //Instance Variables that convert String from Character.cs to an Int for easy calculations.
        private int _DexterityHealthMod = Convert.ToInt32(Program.character.Dexterity);
        private int _EnduranceHealthMod = Convert.ToInt32(Program.character.Endurance);
        private int _IntellegenceHealthMod = Convert.ToInt32(Program.character.Intelligence);
        private int _CharismaHealthMod = Convert.ToInt32(Program.character.Charisma);



        public JobForm()
        {
            InitializeComponent();
        }

        //Next form button
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Health = HealthTextBox.Text;
            character.Job = _RaceSelect.ToString();

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
        
        /// <summary>
        /// Calculates and Displays the Health for the Character being made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_soldierHealth + _EnduranceHealthMod).ToString();
            RadioButton RaceSelect = (RadioButton)sender;

            this._RaceSelect = RaceSelect.Text;

        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_rogueHealth + _DexterityHealthMod).ToString();
            RadioButton RaceSelect = (RadioButton)sender;

            this._RaceSelect = RaceSelect.Text;
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_magickerHealth + _IntellegenceHealthMod).ToString();
            RadioButton RaceSelect = (RadioButton)sender;

            this._RaceSelect = RaceSelect.Text;
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_cultistHealth + _CharismaHealthMod).ToString();
            RadioButton RaceSelect = (RadioButton)sender;

            this._RaceSelect = RaceSelect.Text;
        }
    }
}
