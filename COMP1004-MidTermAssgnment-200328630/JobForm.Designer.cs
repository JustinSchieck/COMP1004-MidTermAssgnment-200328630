namespace COMP1004_MidTermAssgnment_200328630
{
    partial class JobForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.JobGroupBox = new System.Windows.Forms.GroupBox();
            this.SoldierRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.CultistRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthTextBox = new System.Windows.Forms.TextBox();
            this.HPlabel = new System.Windows.Forms.Label();
            this.JobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // JobGroupBox
            // 
            this.JobGroupBox.Controls.Add(this.CultistRadioButton);
            this.JobGroupBox.Controls.Add(this.MagickerRadioButton);
            this.JobGroupBox.Controls.Add(this.RogueRadioButton);
            this.JobGroupBox.Controls.Add(this.SoldierRadioButton);
            this.JobGroupBox.Location = new System.Drawing.Point(43, 53);
            this.JobGroupBox.Name = "JobGroupBox";
            this.JobGroupBox.Size = new System.Drawing.Size(230, 235);
            this.JobGroupBox.TabIndex = 4;
            this.JobGroupBox.TabStop = false;
            this.JobGroupBox.Text = "Job List";
            // 
            // SoldierRadioButton
            // 
            this.SoldierRadioButton.AutoSize = true;
            this.SoldierRadioButton.Checked = true;
            this.SoldierRadioButton.Location = new System.Drawing.Point(47, 39);
            this.SoldierRadioButton.Name = "SoldierRadioButton";
            this.SoldierRadioButton.Size = new System.Drawing.Size(73, 21);
            this.SoldierRadioButton.TabIndex = 0;
            this.SoldierRadioButton.TabStop = true;
            this.SoldierRadioButton.Text = "Soldier";
            this.SoldierRadioButton.UseVisualStyleBackColor = true;
            this.SoldierRadioButton.CheckedChanged += new System.EventHandler(this.SoldierRadioButton_CheckedChanged);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(47, 88);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(71, 21);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Location = new System.Drawing.Point(47, 133);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(86, 21);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this.MagickerRadioButton_CheckedChanged);
            // 
            // CultistRadioButton
            // 
            this.CultistRadioButton.AutoSize = true;
            this.CultistRadioButton.Location = new System.Drawing.Point(47, 178);
            this.CultistRadioButton.Name = "CultistRadioButton";
            this.CultistRadioButton.Size = new System.Drawing.Size(67, 21);
            this.CultistRadioButton.TabIndex = 3;
            this.CultistRadioButton.Text = "Cultist";
            this.CultistRadioButton.UseVisualStyleBackColor = true;
            this.CultistRadioButton.CheckedChanged += new System.EventHandler(this.CultistRadioButton_CheckedChanged);
            // 
            // HealthTextBox
            // 
            this.HealthTextBox.Location = new System.Drawing.Point(336, 151);
            this.HealthTextBox.Name = "HealthTextBox";
            this.HealthTextBox.Size = new System.Drawing.Size(220, 22);
            this.HealthTextBox.TabIndex = 5;
            this.HealthTextBox.TextChanged += new System.EventHandler(this.HealthTextBox_TextChanged);
            // 
            // HPlabel
            // 
            this.HPlabel.AutoSize = true;
            this.HPlabel.Location = new System.Drawing.Point(346, 110);
            this.HPlabel.Name = "HPlabel";
            this.HPlabel.Size = new System.Drawing.Size(92, 17);
            this.HPlabel.TabIndex = 6;
            this.HPlabel.Text = "Health Points";
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.HPlabel);
            this.Controls.Add(this.HealthTextBox);
            this.Controls.Add(this.JobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.JobGroupBox.ResumeLayout(false);
            this.JobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox JobGroupBox;
        private System.Windows.Forms.RadioButton CultistRadioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoldierRadioButton;
        private System.Windows.Forms.TextBox HealthTextBox;
        private System.Windows.Forms.Label HPlabel;
    }
}