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
    public partial class RaceForm : Form
    {


        public AbilityForm previousForm;
        private string _selectedRace;
       

        public RaceForm()
        {
            InitializeComponent();
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();

            character.Race = _selectedRace;


            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

   
        private void HumanRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
        }

        private void ElfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
        }

        private void DwarfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
        }
    }
}

