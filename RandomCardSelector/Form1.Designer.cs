namespace RandomCardSelector
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
            this.ListOfCardType1Label = new System.Windows.Forms.Label();
            this.ListOfCardType1ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cardDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.cardDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardTypeToRandomComboBox = new System.Windows.Forms.ComboBox();
            this.GetRandomCardFromListButton = new System.Windows.Forms.Button();
            this.ListOfCardType2Label = new System.Windows.Forms.Label();
            this.ListOfCardType2ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.randomCardModeRadioButton = new System.Windows.Forms.RadioButton();
            this.viewCardsType1ModeRadioButton = new System.Windows.Forms.RadioButton();
            this.viewCardsType2ModeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.cardDescriptionGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfCardType1Label
            // 
            this.ListOfCardType1Label.AutoSize = true;
            this.ListOfCardType1Label.Location = new System.Drawing.Point(18, 19);
            this.ListOfCardType1Label.Name = "ListOfCardType1Label";
            this.ListOfCardType1Label.Size = new System.Drawing.Size(99, 13);
            this.ListOfCardType1Label.TabIndex = 0;
            this.ListOfCardType1Label.Text = "List of Card Type 1:";
            // 
            // ListOfCardType1ComboBox
            // 
            this.ListOfCardType1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfCardType1ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfCardType1ComboBox.FormattingEnabled = true;
            this.ListOfCardType1ComboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListOfCardType1ComboBox.Location = new System.Drawing.Point(15, 35);
            this.ListOfCardType1ComboBox.MaxDropDownItems = 11;
            this.ListOfCardType1ComboBox.Name = "ListOfCardType1ComboBox";
            this.ListOfCardType1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ListOfCardType1ComboBox.TabIndex = 1;
            this.ListOfCardType1ComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfCardType1ComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.cardDescriptionGroupBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(27, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cardDescriptionGroupBox
            // 
            this.cardDescriptionGroupBox.BackColor = System.Drawing.Color.Gray;
            this.cardDescriptionGroupBox.Controls.Add(this.cardDescriptionLabel);
            this.cardDescriptionGroupBox.Location = new System.Drawing.Point(6, 116);
            this.cardDescriptionGroupBox.Name = "cardDescriptionGroupBox";
            this.cardDescriptionGroupBox.Size = new System.Drawing.Size(243, 276);
            this.cardDescriptionGroupBox.TabIndex = 3;
            this.cardDescriptionGroupBox.TabStop = false;
            // 
            // cardDescriptionLabel
            // 
            this.cardDescriptionLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cardDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardDescriptionLabel.Location = new System.Drawing.Point(6, 10);
            this.cardDescriptionLabel.Name = "cardDescriptionLabel";
            this.cardDescriptionLabel.Size = new System.Drawing.Size(231, 263);
            this.cardDescriptionLabel.TabIndex = 3;
            this.cardDescriptionLabel.Text = "CardNameHere";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.CardNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameLabel.Location = new System.Drawing.Point(16, 6);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(211, 91);
            this.CardNameLabel.TabIndex = 3;
            this.CardNameLabel.Text = "CardNameHere";
            this.CardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardTypeToRandomComboBox
            // 
            this.CardTypeToRandomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardTypeToRandomComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTypeToRandomComboBox.FormattingEnabled = true;
            this.CardTypeToRandomComboBox.Location = new System.Drawing.Point(52, 579);
            this.CardTypeToRandomComboBox.Name = "CardTypeToRandomComboBox";
            this.CardTypeToRandomComboBox.Size = new System.Drawing.Size(208, 21);
            this.CardTypeToRandomComboBox.TabIndex = 8;
            this.CardTypeToRandomComboBox.SelectedIndexChanged += new System.EventHandler(this.CardTypeToRandomComboBox_SelectedIndexChanged);
            // 
            // GetRandomCardFromListButton
            // 
            this.GetRandomCardFromListButton.BackColor = System.Drawing.Color.Silver;
            this.GetRandomCardFromListButton.Enabled = false;
            this.GetRandomCardFromListButton.Location = new System.Drawing.Point(52, 609);
            this.GetRandomCardFromListButton.Name = "GetRandomCardFromListButton";
            this.GetRandomCardFromListButton.Size = new System.Drawing.Size(208, 28);
            this.GetRandomCardFromListButton.TabIndex = 7;
            this.GetRandomCardFromListButton.Text = "Select Random Card";
            this.GetRandomCardFromListButton.UseVisualStyleBackColor = false;
            this.GetRandomCardFromListButton.Click += new System.EventHandler(this.GetRandomCardFromListButton_Click);
            // 
            // ListOfCardType2Label
            // 
            this.ListOfCardType2Label.AutoSize = true;
            this.ListOfCardType2Label.Location = new System.Drawing.Point(159, 19);
            this.ListOfCardType2Label.Name = "ListOfCardType2Label";
            this.ListOfCardType2Label.Size = new System.Drawing.Size(99, 13);
            this.ListOfCardType2Label.TabIndex = 0;
            this.ListOfCardType2Label.Text = "List of Card Type 2:";
            // 
            // ListOfCardType2ComboBox
            // 
            this.ListOfCardType2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfCardType2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfCardType2ComboBox.FormattingEnabled = true;
            this.ListOfCardType2ComboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ListOfCardType2ComboBox.Location = new System.Drawing.Point(149, 35);
            this.ListOfCardType2ComboBox.MaxDropDownItems = 11;
            this.ListOfCardType2ComboBox.Name = "ListOfCardType2ComboBox";
            this.ListOfCardType2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ListOfCardType2ComboBox.TabIndex = 1;
            this.ListOfCardType2ComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfCardType2ComboBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListOfCardType1Label);
            this.groupBox3.Controls.Add(this.ListOfCardType1ComboBox);
            this.groupBox3.Controls.Add(this.ListOfCardType2Label);
            this.groupBox3.Controls.Add(this.ListOfCardType2ComboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 63);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Card Type Lists";
            // 
            // randomCardModeRadioButton
            // 
            this.randomCardModeRadioButton.AutoSize = true;
            this.randomCardModeRadioButton.Location = new System.Drawing.Point(70, 16);
            this.randomCardModeRadioButton.Name = "randomCardModeRadioButton";
            this.randomCardModeRadioButton.Size = new System.Drawing.Size(110, 17);
            this.randomCardModeRadioButton.TabIndex = 10;
            this.randomCardModeRadioButton.TabStop = true;
            this.randomCardModeRadioButton.Text = "Get Random Card";
            this.randomCardModeRadioButton.UseVisualStyleBackColor = true;
            this.randomCardModeRadioButton.CheckedChanged += new System.EventHandler(this.randomCardModeRadioButton_CheckedChanged);
            // 
            // viewCardsType1ModeRadioButton
            // 
            this.viewCardsType1ModeRadioButton.AutoSize = true;
            this.viewCardsType1ModeRadioButton.Location = new System.Drawing.Point(70, 37);
            this.viewCardsType1ModeRadioButton.Name = "viewCardsType1ModeRadioButton";
            this.viewCardsType1ModeRadioButton.Size = new System.Drawing.Size(108, 17);
            this.viewCardsType1ModeRadioButton.TabIndex = 11;
            this.viewCardsType1ModeRadioButton.TabStop = true;
            this.viewCardsType1ModeRadioButton.Text = "View CardsType1";
            this.viewCardsType1ModeRadioButton.UseVisualStyleBackColor = true;
            this.viewCardsType1ModeRadioButton.CheckedChanged += new System.EventHandler(this.viewCardsType1ModeRadioButton_CheckedChanged);
            // 
            // viewCardsType2ModeRadioButton
            // 
            this.viewCardsType2ModeRadioButton.AutoSize = true;
            this.viewCardsType2ModeRadioButton.Location = new System.Drawing.Point(70, 60);
            this.viewCardsType2ModeRadioButton.Name = "viewCardsType2ModeRadioButton";
            this.viewCardsType2ModeRadioButton.Size = new System.Drawing.Size(108, 17);
            this.viewCardsType2ModeRadioButton.TabIndex = 12;
            this.viewCardsType2ModeRadioButton.TabStop = true;
            this.viewCardsType2ModeRadioButton.Text = "View CardsType2";
            this.viewCardsType2ModeRadioButton.UseVisualStyleBackColor = true;
            this.viewCardsType2ModeRadioButton.CheckedChanged += new System.EventHandler(this.viewCardsType2ModeRadioButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.viewCardsType2ModeRadioButton);
            this.groupBox4.Controls.Add(this.randomCardModeRadioButton);
            this.groupBox4.Controls.Add(this.viewCardsType1ModeRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(27, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 84);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 644);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CardTypeToRandomComboBox);
            this.Controls.Add(this.GetRandomCardFromListButton);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Deck Random Card Selector";
            this.groupBox1.ResumeLayout(false);
            this.cardDescriptionGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListOfCardType1Label;
        private System.Windows.Forms.ComboBox ListOfCardType1ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cardDescriptionGroupBox;
        private System.Windows.Forms.Label cardDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CardNameLabel;
        private System.Windows.Forms.ComboBox CardTypeToRandomComboBox;
        private System.Windows.Forms.Button GetRandomCardFromListButton;
        private System.Windows.Forms.Label ListOfCardType2Label;
        private System.Windows.Forms.ComboBox ListOfCardType2ComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton randomCardModeRadioButton;
        private System.Windows.Forms.RadioButton viewCardsType1ModeRadioButton;
        private System.Windows.Forms.RadioButton viewCardsType2ModeRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

