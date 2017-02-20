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

        private int _soldierHealth = 30;
        private int _rogueHealth = 28;
        private int _magickerHealth = 15;
        private int _cultistHealth = 24;

    
        private int _DexterityHealthMod = Convert.ToInt32(Program.character.Dexterity);
        private int _EnduranceHealthMod = Convert.ToInt32(Program.character.Endurance);
        private int _IntellegenceHealthMod = Convert.ToInt32(Program.character.Intelligence);
        private int _CharismaHealthMod = Convert.ToInt32(Program.character.Charisma);



        public JobForm()
        {
            InitializeComponent();
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
            HealthTextBox.Text = (_soldierHealth + _EnduranceHealthMod).ToString();
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_rogueHealth + _DexterityHealthMod).ToString();
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_magickerHealth + _IntellegenceHealthMod).ToString();
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthTextBox.Text = (_cultistHealth + _CharismaHealthMod).ToString();
        }
    }
}
