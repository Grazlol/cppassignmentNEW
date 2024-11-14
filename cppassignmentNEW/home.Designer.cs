namespace cppassignmentNEW
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            toDatabase = new Button();
            toRegister = new Button();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // toDatabase
            // 
            toDatabase.BackColor = Color.FromArgb(192, 0, 0);
            toDatabase.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toDatabase.ForeColor = Color.White;
            toDatabase.Location = new Point(497, 348);
            toDatabase.Name = "toDatabase";
            toDatabase.Size = new Size(184, 37);
            toDatabase.TabIndex = 15;
            toDatabase.Text = "Database";
            toDatabase.UseVisualStyleBackColor = false;
            toDatabase.Click += toDatabase_Click;
            // 
            // toRegister
            // 
            toRegister.BackColor = Color.FromArgb(192, 0, 0);
            toRegister.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toRegister.ForeColor = Color.White;
            toRegister.Location = new Point(497, 305);
            toRegister.Name = "toRegister";
            toRegister.Size = new Size(184, 37);
            toRegister.TabIndex = 14;
            toRegister.Text = "Register";
            toRegister.UseVisualStyleBackColor = false;
            toRegister.Click += toRegister_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DimGray;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(965, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 111);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("MS Gothic", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(957, 62);
            label1.TabIndex = 12;
            label1.Text = "STUDENT ORGANIZATION MEMBERSHIP";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1131, 723);
            Controls.Add(toDatabase);
            Controls.Add(toRegister);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Name = "home";
            Text = "home";
            FormClosing += KILL;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toDatabase;
        private Button toRegister;
        private PictureBox pictureBox4;
        private Label label1;
    }
}