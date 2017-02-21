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
 
    public partial class RaceForm : Form
    {

        //public previous form variable
        public AbilityForm previousForm { get; set; }
        //Private varibles
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
        
        //next form button
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = _selectedRace;
            character.Strength = _StrengthMod.ToString();
            character.Dexterity = _DexterityMod.ToString();
            character.Endurance = _EnduranceMod.ToString();
            character.Intelligence = _IntellegenceMod.ToString();
            character.Perception = _PerceptionMod.ToString();
            character.Charisma = _CharismaMod.ToString();

            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        //human option radio button
        private void HumanRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase all abilities by 5";
            
            _StrengthMod = _StrengthMod + 5;
            _DexterityMod = _DexterityMod + 5;
            _EnduranceMod = _EnduranceMod + 5;
            _IntellegenceMod = _IntellegenceMod + 5;
            _PerceptionMod = _PerceptionMod + 5;
            _CharismaMod = _CharismaMod + 5;

          
            this._selectedRace = selectedRace.Text;
        }
        //Elf option radio button
        private void ElfRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DexterityMod = _DexterityMod + 20;
            _PerceptionMod = _PerceptionMod + 20;

            this._selectedRace = selectedRace.Text;
            
           
        }
        //Dwarf option Radio button
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
        //Radio button for the Halfling Option
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

