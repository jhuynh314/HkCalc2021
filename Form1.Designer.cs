namespace HK_Calc_2021
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createDieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dieValueTextBox = new System.Windows.Forms.TextBox();
            this.knightRadioButton = new System.Windows.Forms.RadioButton();
            this.mageRadioButton = new System.Windows.Forms.RadioButton();
            this.rangerRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.currentDiceLabel = new System.Windows.Forms.Label();
            this.clearDiceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addRequirementButton = new System.Windows.Forms.Button();
            this.kRadioButton = new System.Windows.Forms.RadioButton();
            this.mRadioButton = new System.Windows.Forms.RadioButton();
            this.rRadioButton = new System.Windows.Forms.RadioButton();
            this.nRadioButton = new System.Windows.Forms.RadioButton();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clearMissionButton = new System.Windows.Forms.Button();
            this.currentMissionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.trialsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.successesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createDieButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dieValueTextBox);
            this.groupBox1.Controls.Add(this.knightRadioButton);
            this.groupBox1.Controls.Add(this.mageRadioButton);
            this.groupBox1.Controls.Add(this.rangerRadioButton);
            this.groupBox1.Controls.Add(this.noneRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(180, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Dice";
            // 
            // createDieButton
            // 
            this.createDieButton.Location = new System.Drawing.Point(12, 82);
            this.createDieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createDieButton.Name = "createDieButton";
            this.createDieButton.Size = new System.Drawing.Size(56, 19);
            this.createDieButton.TabIndex = 6;
            this.createDieButton.Text = "Create";
            this.createDieButton.UseVisualStyleBackColor = true;
            this.createDieButton.Click += new System.EventHandler(this.createDieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value:";
            // 
            // dieValueTextBox
            // 
            this.dieValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieValueTextBox.Location = new System.Drawing.Point(21, 38);
            this.dieValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dieValueTextBox.Name = "dieValueTextBox";
            this.dieValueTextBox.Size = new System.Drawing.Size(37, 32);
            this.dieValueTextBox.TabIndex = 4;
            this.dieValueTextBox.Text = "8";
            this.dieValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knightRadioButton
            // 
            this.knightRadioButton.AutoSize = true;
            this.knightRadioButton.Location = new System.Drawing.Point(93, 86);
            this.knightRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knightRadioButton.Name = "knightRadioButton";
            this.knightRadioButton.Size = new System.Drawing.Size(55, 17);
            this.knightRadioButton.TabIndex = 3;
            this.knightRadioButton.TabStop = true;
            this.knightRadioButton.Text = "Knight";
            this.knightRadioButton.UseVisualStyleBackColor = true;
            // 
            // mageRadioButton
            // 
            this.mageRadioButton.AutoSize = true;
            this.mageRadioButton.Location = new System.Drawing.Point(93, 64);
            this.mageRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mageRadioButton.Name = "mageRadioButton";
            this.mageRadioButton.Size = new System.Drawing.Size(52, 17);
            this.mageRadioButton.TabIndex = 2;
            this.mageRadioButton.TabStop = true;
            this.mageRadioButton.Text = "Mage";
            this.mageRadioButton.UseVisualStyleBackColor = true;
            // 
            // rangerRadioButton
            // 
            this.rangerRadioButton.AutoSize = true;
            this.rangerRadioButton.Location = new System.Drawing.Point(93, 42);
            this.rangerRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rangerRadioButton.Name = "rangerRadioButton";
            this.rangerRadioButton.Size = new System.Drawing.Size(60, 17);
            this.rangerRadioButton.TabIndex = 1;
            this.rangerRadioButton.TabStop = true;
            this.rangerRadioButton.Text = "Ranger";
            this.rangerRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Checked = true;
            this.noneRadioButton.Location = new System.Drawing.Point(93, 20);
            this.noneRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // currentDiceLabel
            // 
            this.currentDiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDiceLabel.Location = new System.Drawing.Point(294, 10);
            this.currentDiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDiceLabel.Name = "currentDiceLabel";
            this.currentDiceLabel.Size = new System.Drawing.Size(266, 26);
            this.currentDiceLabel.TabIndex = 1;
            // 
            // clearDiceButton
            // 
            this.clearDiceButton.Location = new System.Drawing.Point(382, 38);
            this.clearDiceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearDiceButton.Name = "clearDiceButton";
            this.clearDiceButton.Size = new System.Drawing.Size(105, 19);
            this.clearDiceButton.TabIndex = 2;
            this.clearDiceButton.Text = "Clear Dice";
            this.clearDiceButton.UseVisualStyleBackColor = true;
            this.clearDiceButton.Click += new System.EventHandler(this.clearDiceButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addRequirementButton);
            this.groupBox2.Controls.Add(this.kRadioButton);
            this.groupBox2.Controls.Add(this.mRadioButton);
            this.groupBox2.Controls.Add(this.rRadioButton);
            this.groupBox2.Controls.Add(this.nRadioButton);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(180, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requiremnt";
            // 
            // addRequirementButton
            // 
            this.addRequirementButton.Location = new System.Drawing.Point(12, 88);
            this.addRequirementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRequirementButton.Name = "addRequirementButton";
            this.addRequirementButton.Size = new System.Drawing.Size(55, 19);
            this.addRequirementButton.TabIndex = 10;
            this.addRequirementButton.Text = "Add";
            this.addRequirementButton.UseVisualStyleBackColor = true;
            this.addRequirementButton.Click += new System.EventHandler(this.addRequirementButton_Click);
            // 
            // kRadioButton
            // 
            this.kRadioButton.AutoSize = true;
            this.kRadioButton.Location = new System.Drawing.Point(111, 79);
            this.kRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kRadioButton.Name = "kRadioButton";
            this.kRadioButton.Size = new System.Drawing.Size(32, 17);
            this.kRadioButton.TabIndex = 9;
            this.kRadioButton.TabStop = true;
            this.kRadioButton.Text = "K";
            this.kRadioButton.UseVisualStyleBackColor = true;
            // 
            // mRadioButton
            // 
            this.mRadioButton.AutoSize = true;
            this.mRadioButton.Location = new System.Drawing.Point(111, 57);
            this.mRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mRadioButton.Name = "mRadioButton";
            this.mRadioButton.Size = new System.Drawing.Size(34, 17);
            this.mRadioButton.TabIndex = 8;
            this.mRadioButton.TabStop = true;
            this.mRadioButton.Text = "M";
            this.mRadioButton.UseVisualStyleBackColor = true;
            // 
            // rRadioButton
            // 
            this.rRadioButton.AutoSize = true;
            this.rRadioButton.Location = new System.Drawing.Point(111, 35);
            this.rRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rRadioButton.Name = "rRadioButton";
            this.rRadioButton.Size = new System.Drawing.Size(33, 17);
            this.rRadioButton.TabIndex = 7;
            this.rRadioButton.TabStop = true;
            this.rRadioButton.Text = "R";
            this.rRadioButton.UseVisualStyleBackColor = true;
            // 
            // nRadioButton
            // 
            this.nRadioButton.AutoSize = true;
            this.nRadioButton.Checked = true;
            this.nRadioButton.Location = new System.Drawing.Point(111, 13);
            this.nRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nRadioButton.Name = "nRadioButton";
            this.nRadioButton.Size = new System.Drawing.Size(33, 17);
            this.nRadioButton.TabIndex = 6;
            this.nRadioButton.TabStop = true;
            this.nRadioButton.Text = "N";
            this.nRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(71, 66);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(71, 44);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(71, 22);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(38, 66);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(38, 44);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 22);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clearMissionButton
            // 
            this.clearMissionButton.Location = new System.Drawing.Point(382, 96);
            this.clearMissionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearMissionButton.Name = "clearMissionButton";
            this.clearMissionButton.Size = new System.Drawing.Size(105, 19);
            this.clearMissionButton.TabIndex = 5;
            this.clearMissionButton.Text = "Clear Mission";
            this.clearMissionButton.UseVisualStyleBackColor = true;
            this.clearMissionButton.Click += new System.EventHandler(this.clearMissionButton_Click);
            // 
            // currentMissionLabel
            // 
            this.currentMissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentMissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMissionLabel.Location = new System.Drawing.Point(294, 67);
            this.currentMissionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentMissionLabel.Name = "currentMissionLabel";
            this.currentMissionLabel.Size = new System.Drawing.Size(266, 26);
            this.currentMissionLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Dice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Mission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Probability:";
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.probabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probabilityLabel.Location = new System.Drawing.Point(426, 232);
            this.probabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(76, 23);
            this.probabilityLabel.TabIndex = 9;
            this.probabilityLabel.Text = "0.00%";
            // 
            // trialsTextBox
            // 
            this.trialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialsTextBox.Location = new System.Drawing.Point(426, 149);
            this.trialsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trialsTextBox.Name = "trialsTextBox";
            this.trialsTextBox.Size = new System.Drawing.Size(76, 26);
            this.trialsTextBox.TabIndex = 10;
            this.trialsTextBox.Text = "1000000";
            this.trialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Trials:";
            // 
            // successesLabel
            // 
            this.successesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successesLabel.Location = new System.Drawing.Point(426, 184);
            this.successesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successesLabel.Name = "successesLabel";
            this.successesLabel.Size = new System.Drawing.Size(76, 23);
            this.successesLabel.TabIndex = 13;
            this.successesLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Successes:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(240, 199);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 28);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 287);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.successesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trialsTextBox);
            this.Controls.Add(this.probabilityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearMissionButton);
            this.Controls.Add(this.currentMissionLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearDiceButton);
            this.Controls.Add(this.currentDiceLabel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "HK Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createDieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dieValueTextBox;
        private System.Windows.Forms.RadioButton knightRadioButton;
        private System.Windows.Forms.RadioButton mageRadioButton;
        private System.Windows.Forms.RadioButton rangerRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.Label currentDiceLabel;
        private System.Windows.Forms.Button clearDiceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addRequirementButton;
        private System.Windows.Forms.RadioButton kRadioButton;
        private System.Windows.Forms.RadioButton mRadioButton;
        private System.Windows.Forms.RadioButton rRadioButton;
        private System.Windows.Forms.RadioButton nRadioButton;
        private System.Windows.Forms.Button clearMissionButton;
        private System.Windows.Forms.Label currentMissionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label probabilityLabel;
        private System.Windows.Forms.TextBox trialsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label successesLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateButton;
    }
}

