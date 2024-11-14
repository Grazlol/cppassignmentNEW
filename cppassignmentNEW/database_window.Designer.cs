namespace cppassignmentNEW
{
    partial class database_window
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
            dataGridView1 = new DataGridView();
            where_param = new TextBox();
            column_name = new ComboBox();
            cancelButton = new Button();
            button1 = new Button();
            cancelledfromtwitter = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1069, 554);
            dataGridView1.TabIndex = 0;
            // 
            // where_param
            // 
            where_param.Location = new Point(277, 583);
            where_param.Name = "where_param";
            where_param.Size = new Size(251, 23);
            where_param.TabIndex = 1;
            // 
            // column_name
            // 
            column_name.FormattingEnabled = true;
            column_name.Items.AddRange(new object[] { "", "Member_Type", "Fee", "Full_Name", "Nick_Name", "Student_No", "College", "Course", "Year_Level", "Contact_No", "Email_Address", "Committees", "Organization" });
            column_name.Location = new Point(32, 583);
            column_name.Name = "column_name";
            column_name.Size = new Size(216, 23);
            column_name.TabIndex = 2;
            column_name.Text = "Member_Type";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(192, 0, 0);
            cancelButton.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(557, 579);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(184, 30);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Search";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(747, 579);
            button1.Name = "button1";
            button1.Size = new Size(184, 30);
            button1.TabIndex = 13;
            button1.Text = "Delete Row";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cancelledfromtwitter
            // 
            cancelledfromtwitter.BackColor = Color.FromArgb(192, 0, 0);
            cancelledfromtwitter.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelledfromtwitter.ForeColor = Color.White;
            cancelledfromtwitter.Location = new Point(32, 681);
            cancelledfromtwitter.Name = "cancelledfromtwitter";
            cancelledfromtwitter.Size = new Size(184, 30);
            cancelledfromtwitter.TabIndex = 15;
            cancelledfromtwitter.Text = "Cancel";
            cancelledfromtwitter.UseVisualStyleBackColor = false;
            cancelledfromtwitter.Click += cancelledfromtwitter_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("basis33", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(747, 615);
            button2.Name = "button2";
            button2.Size = new Size(184, 30);
            button2.TabIndex = 16;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // database_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1131, 723);
            Controls.Add(button2);
            Controls.Add(cancelledfromtwitter);
            Controls.Add(button1);
            Controls.Add(cancelButton);
            Controls.Add(column_name);
            Controls.Add(where_param);
            Controls.Add(dataGridView1);
            Name = "database_window";
            Text = "database_window";
            Load += ready;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox where_param;
        private ComboBox column_name;
        private Button cancelButton;
        private Button button1;
        private Button cancelledfromtwitter;
        private Button button2;
    }
}