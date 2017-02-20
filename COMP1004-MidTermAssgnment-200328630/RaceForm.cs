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


        private int _StrengthMod = Convert.ToInt32(Program.character.Strength);
        private int _DexterityMod = Convert.ToInt32(Program.character.Dexterity);
        private int _EnduranceMod = Convert.ToInt32(Program.character.Endurance);
        private int _IntellegenceMod = Convert.ToInt32(Program.character.Intelligence);
        private int _PerceptionMod = Convert.ToInt32(Program.character.Perception);
        private int _CharismaMod = Convert.ToInt32(Program.character.Charisma);

        public RaceForm()
        {
            InitializeComponent();
        }




        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

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

            RacialBonusTextBox.Text = "Increase all abilities by 10";
            
            _StrengthMod = _StrengthMod + 10;
            _DexterityMod = _DexterityMod + 10;
            _EnduranceMod = _EnduranceMod + 10;
            _IntellegenceMod = _IntellegenceMod + 10;
            _PerceptionMod = _PerceptionMod + 10;
            _CharismaMod = _CharismaMod + 10;

          
            this._selectedRace = selectedRace.Text;
        }

        private void ElfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DexterityMod = _DexterityMod + 20;
            _PerceptionMod = _PerceptionMod + 20;

            this._selectedRace = selectedRace.Text;
            
           
        }

        private void DwarfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _StrengthMod = _StrengthMod + 20;
            _PerceptionMod = _PerceptionMod + 20;
            _CharismaMod = _CharismaMod - 10;
            this._selectedRace = selectedRace.Text;
            
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DexterityMod = _DexterityMod + 20;
            _IntellegenceMod = _IntellegenceMod + 20;
            _StrengthMod = _StrengthMod - 10;

            this._selectedRace = selectedRace.Text;
           
        }
    }
}

