namespace cppassignmentNEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            acceptButton = new Button();
            cancelButton = new Button();
            infoBox = new TextBox();
            memberBox = new CheckBox();
            label2 = new Label();
            LnameBox = new TextBox();
            nicknameBox = new TextBox();
            label5 = new Label();
            stunoBox = new TextBox();
            label6 = new Label();
            conoBox = new TextBox();
            label7 = new Label();
            emailBox = new TextBox();
            label8 = new Label();
            colegBox = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            courBox = new ComboBox();
            label11 = new Label();
            yearBox = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            CommitteeBoxA = new ComboBox();
            CommitteeBoxB = new ComboBox();
            ErrorLabel = new TextBox();
            availOrgs = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            FnameBox = new TextBox();
            MnameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("MS Gothic", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(957, 62);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ORGANIZATION MEMBERSHIP";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(444, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(493, 619);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(0, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(438, 619);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("basis33", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(444, 71);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 6;
            label3.Text = "Student Details";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("basis33", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 71);
            label4.Name = "label4";
            label4.Size = new Size(274, 29);
            label4.TabIndex = 7;
            label4.Text = "Organization Details";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DimGray;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(963, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 111);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.FromArgb(192, 0, 0);
            acceptButton.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptButton.ForeColor = Color.White;
            acceptButton.Location = new Point(943, 161);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(184, 37);
            acceptButton.TabIndex = 10;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += Accept_Clicked;
            acceptButton.MouseEnter += acceptButton_MouseEnter;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(192, 0, 0);
            cancelButton.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(943, 204);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(184, 37);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += Cancel_Clicked;
            cancelButton.MouseEnter += cancelHover;
            // 
            // infoBox
            // 
            infoBox.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoBox.Location = new Point(943, 455);
            infoBox.Multiline = true;
            infoBox.Name = "infoBox";
            infoBox.PlaceholderText = "Information Preview";
            infoBox.ReadOnly = true;
            infoBox.Size = new Size(184, 267);
            infoBox.TabIndex = 12;
            infoBox.Tag = "";
            // 
            // memberBox
            // 
            memberBox.AutoSize = true;
            memberBox.BackColor = Color.Gainsboro;
            memberBox.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberBox.Location = new Point(12, 131);
            memberBox.Name = "memberBox";
            memberBox.Size = new Size(227, 25);
            memberBox.TabIndex = 13;
            memberBox.Text = "Are you an old member?";
            memberBox.UseVisualStyleBackColor = false;
            memberBox.MouseEnter += memstathover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 110);
            label2.Name = "label2";
            label2.Size = new Size(343, 21);
            label2.TabIndex = 14;
            label2.Text = "Last Name, First Name, Middle Initial";
            label2.Click += label2_Click_1;
            // 
            // LnameBox
            // 
            LnameBox.BackColor = Color.White;
            LnameBox.Font = new Font("basis33", 14.25F);
            LnameBox.Location = new Point(451, 134);
            LnameBox.Name = "LnameBox";
            LnameBox.Size = new Size(202, 26);
            LnameBox.TabIndex = 15;
            LnameBox.MouseEnter += nameHover;
            // 
            // nicknameBox
            // 
            nicknameBox.BackColor = Color.White;
            nicknameBox.Font = new Font("basis33", 14.25F);
            nicknameBox.Location = new Point(451, 183);
            nicknameBox.Name = "nicknameBox";
            nicknameBox.Size = new Size(230, 26);
            nicknameBox.TabIndex = 17;
            nicknameBox.MouseEnter += nameHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(450, 163);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 16;
            label5.Text = "Nickname";
            label5.Click += label5_Click;
            // 
            // stunoBox
            // 
            stunoBox.BackColor = Color.White;
            stunoBox.Font = new Font("basis33", 14.25F);
            stunoBox.Location = new Point(451, 237);
            stunoBox.Name = "stunoBox";
            stunoBox.Size = new Size(230, 26);
            stunoBox.TabIndex = 19;
            stunoBox.MouseEnter += nameHover;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(450, 213);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 18;
            label6.Text = "Student № [11]";
            // 
            // conoBox
            // 
            conoBox.BackColor = Color.White;
            conoBox.Font = new Font("basis33", 14.25F);
            conoBox.Location = new Point(687, 237);
            conoBox.Name = "conoBox";
            conoBox.Size = new Size(240, 26);
            conoBox.TabIndex = 21;
            conoBox.TextChanged += textBox5_TextChanged;
            conoBox.MouseEnter += nameHover;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(687, 213);
            label7.Name = "label7";
            label7.Size = new Size(144, 21);
            label7.TabIndex = 20;
            label7.Text = "Contact № [11]";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.White;
            emailBox.Font = new Font("basis33", 14.25F);
            emailBox.Location = new Point(687, 183);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(240, 26);
            emailBox.TabIndex = 23;
            emailBox.MouseEnter += nameHover;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(686, 163);
            label8.Name = "label8";
            label8.Size = new Size(127, 21);
            label8.TabIndex = 22;
            label8.Text = "Email Address";
            // 
            // colegBox
            // 
            colegBox.Font = new Font("basis33", 14.25F);
            colegBox.FormattingEnabled = true;
            colegBox.Items.AddRange(new object[] { "College of Engineering", "Business Administration", "Fine Arts and Design" });
            colegBox.Location = new Point(451, 290);
            colegBox.Name = "colegBox";
            colegBox.Size = new Size(476, 27);
            colegBox.TabIndex = 24;
            colegBox.TextChanged += CollegeFieldTampered;
            colegBox.MouseEnter += nameHover;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(451, 266);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 25;
            label9.Text = "College";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(451, 324);
            label10.Name = "label10";
            label10.Size = new Size(64, 21);
            label10.TabIndex = 27;
            label10.Text = "Course";
            // 
            // courBox
            // 
            courBox.Font = new Font("basis33", 14.25F);
            courBox.FormattingEnabled = true;
            courBox.Location = new Point(451, 348);
            courBox.Name = "courBox";
            courBox.Size = new Size(476, 27);
            courBox.TabIndex = 26;
            courBox.MouseEnter += nameHover;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(451, 383);
            label11.Name = "label11";
            label11.Size = new Size(100, 21);
            label11.TabIndex = 29;
            label11.Text = "Year Level";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("basis33", 14.25F);
            yearBox.FormattingEnabled = true;
            yearBox.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            yearBox.Location = new Point(451, 407);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(476, 27);
            yearBox.TabIndex = 28;
            yearBox.MouseEnter += nameHover;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 110);
            label12.Name = "label12";
            label12.Size = new Size(163, 21);
            label12.TabIndex = 30;
            label12.Text = "Membership Status";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 170);
            label13.Name = "label13";
            label13.Size = new Size(217, 21);
            label13.TabIndex = 32;
            label13.Text = "Available Organizations\r\n";
            label13.Click += label13_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Gainsboro;
            label15.Font = new Font("basis33", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(14, 485);
            label15.Name = "label15";
            label15.Size = new Size(235, 21);
            label15.TabIndex = 36;
            label15.Text = "Join a Committee (Min. 2)";
            // 
            // CommitteeBoxA
            // 
            CommitteeBoxA.BackColor = Color.White;
            CommitteeBoxA.Font = new Font("basis33", 14.25F);
            CommitteeBoxA.FormattingEnabled = true;
            CommitteeBoxA.Items.AddRange(new object[] { "Creative and Design", "Finance and Auditing", "Business Marketing", "Academics", "Non-Academics", "Multimedia and Animation", "Personality Development" });
            CommitteeBoxA.Location = new Point(14, 509);
            CommitteeBoxA.Name = "CommitteeBoxA";
            CommitteeBoxA.Size = new Size(415, 27);
            CommitteeBoxA.TabIndex = 35;
            CommitteeBoxA.SelectedIndexChanged += CommitteeBoxA_SelectedIndexChanged;
            CommitteeBoxA.TextChanged += committeeChangedA;
            CommitteeBoxA.MouseEnter += comithover;
            // 
            // CommitteeBoxB
            // 
            CommitteeBoxB.BackColor = Color.White;
            CommitteeBoxB.Font = new Font("basis33", 14.25F);
            CommitteeBoxB.FormattingEnabled = true;
            CommitteeBoxB.Items.AddRange(new object[] { "Creative and Design", "Finance and Auditing", "Business Marketing", "Academics", "Non-Academics", "Multimedia and Animation", "Personality Development" });
            CommitteeBoxB.Location = new Point(14, 550);
            CommitteeBoxB.Name = "CommitteeBoxB";
            CommitteeBoxB.Size = new Size(415, 27);
            CommitteeBoxB.TabIndex = 37;
            CommitteeBoxB.TextChanged += committeeChangedB;
            CommitteeBoxB.MouseEnter += comithover;
            // 
            // ErrorLabel
            // 
            ErrorLabel.BackColor = Color.Black;
            ErrorLabel.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(455, 455);
            ErrorLabel.Multiline = true;
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.ReadOnly = true;
            ErrorLabel.Size = new Size(472, 173);
            ErrorLabel.TabIndex = 38;
            ErrorLabel.Text = "INFORMATION PROVIDED IS INVALID";
            ErrorLabel.Visible = false;
            // 
            // availOrgs
            // 
            availOrgs.BackColor = Color.White;
            availOrgs.Font = new Font("basis33", 14.25F);
            availOrgs.FormattingEnabled = true;
            availOrgs.Location = new Point(14, 197);
            availOrgs.Name = "availOrgs";
            availOrgs.Size = new Size(415, 27);
            availOrgs.TabIndex = 39;
            availOrgs.MouseEnter += orghover;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(130, 420);
            button1.Name = "button1";
            button1.Size = new Size(184, 37);
            button1.TabIndex = 40;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(130, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // FnameBox
            // 
            FnameBox.BackColor = Color.White;
            FnameBox.Font = new Font("basis33", 14.25F);
            FnameBox.Location = new Point(659, 134);
            FnameBox.Name = "FnameBox";
            FnameBox.Size = new Size(203, 26);
            FnameBox.TabIndex = 42;
            // 
            // MnameBox
            // 
            MnameBox.BackColor = Color.White;
            MnameBox.Font = new Font("basis33", 14.25F);
            MnameBox.Location = new Point(868, 134);
            MnameBox.Name = "MnameBox";
            MnameBox.Size = new Size(59, 26);
            MnameBox.TabIndex = 43;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1131, 723);
            Controls.Add(MnameBox);
            Controls.Add(FnameBox);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(availOrgs);
            Controls.Add(ErrorLabel);
            Controls.Add(CommitteeBoxB);
            Controls.Add(label15);
            Controls.Add(CommitteeBoxA);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(yearBox);
            Controls.Add(label10);
            Controls.Add(courBox);
            Controls.Add(label9);
            Controls.Add(colegBox);
            Controls.Add(emailBox);
            Controls.Add(label8);
            Controls.Add(conoBox);
            Controls.Add(label7);
            Controls.Add(stunoBox);
            Controls.Add(label6);
            Controls.Add(nicknameBox);
            Controls.Add(label5);
            Controls.Add(LnameBox);
            Controls.Add(label2);
            Controls.Add(memberBox);
            Controls.Add(infoBox);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "d";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Button acceptButton;
        private Button cancelButton;
        private TextBox infoBox;
        private CheckBox memberBox;
        private Label label2;
        private TextBox LnameBox;
        private TextBox nicknameBox;
        private Label label5;
        private TextBox stunoBox;
        private Label label6;
        private TextBox conoBox;
        private Label label7;
        private TextBox emailBox;
        private Label label8;
        private ComboBox colegBox;
        private Label label9;
        private Label label10;
        private ComboBox courBox;
        private Label label11;
        private ComboBox yearBox;
        private Label label12;
        private Label label13;
        private Label label15;
        private ComboBox CommitteeBoxA;
        private ComboBox CommitteeBoxB;
        private TextBox ErrorLabel;
        private ComboBox availOrgs;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox FnameBox;
        private TextBox MnameBox;
    }
}
