using System.Text.RegularExpressions;

namespace cppassignmentNEW
{
    public partial class Form1 : Form
    {
        String imageLocation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Accept_Clicked(object sender, EventArgs e)
        {
            bool isEmailValid = Regex.IsMatch(emailBox.Text, @"^\w+@[a-zA-Z_]+?.[a-zA-Z]{2,3}$");
            bool isFirstNValid = Regex.IsMatch(FnameBox.Text, @"^[A-Z][a-zA-Z]*$");
            bool isMidNValid = Regex.IsMatch(MnameBox.Text, @"^[A-Z][a-zA-Z]*$");
            bool isLastNValid = Regex.IsMatch(LnameBox.Text, @"^[A-Z][a-zA-Z]*$");
            bool isNickNValid = Regex.IsMatch(nicknameBox.Text, @"^[A-Z][a-zA-Z]*$");
            bool isPhoneNValid = Regex.IsMatch(conoBox.Text, @"^((^(\+)(\d){12}$)|(^\d{11}$))");
            bool isStudNValid = Regex.IsMatch(stunoBox.Text, @"^((^\d{11}$))");
            if (
            LnameBox.Text.Length > 1 && FnameBox.Text.Length > 1 && FnameBox.Text.Length > 0 &&
            emailBox.Text.Length > 5 &&
            stunoBox.Text.Length > 5 &&
            colegBox.Text.Length > 0 &&
            courBox.Text.Length > 0 &&
            yearBox.Text.Length > 0 &&
            CommitteeBoxA.Text.Length > 0 &&
            CommitteeBoxB.Text.Length > 0 &&
            availOrgs.Text.Length > 0 &&
            isEmailValid &&
            isFirstNValid &&
            isLastNValid &&
            isNickNValid &&
            isPhoneNValid &&
            isStudNValid &&
            isMidNValid
            


            )
            {
                
                if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid email");
                }
                else
                {
                    if (queryDB.select("student_no", "student_no", stunoBox.Text, "student_info") == null)
                    {
                        string summary = "";
                        string formermember = memberBox.Checked ? "Old Member" : "New Member";
                        float billmodifier = memberBox.Checked ? (0.00f - (GetOrgPrice(availOrgs.Text) * 0.10f)) : 50;
                        float totalbill = GetOrgPrice(availOrgs.Text) + billmodifier;

                        summary += "Name: " + LnameBox.Text + "\n";
                        summary += "nickname: " + nicknameBox.Text + "\n\n";

                        summary += "Email Address: " + emailBox.Text + "\n";
                        summary += "Phone Number: " + conoBox + "\n";
                        summary += "Student Number: " + stunoBox.Text + "\n\n";

                        summary += "College: " + colegBox.Text + "\n";
                        summary += "Course: " + courBox.Text + "\n";
                        summary += "Year Level: " + yearBox.Text + "\n\n";

                        summary += "Joined Organization: " + availOrgs.Text + "\n";
                        summary += "Committee A: " + CommitteeBoxA.Text + "\n";
                        summary += "Committee B: " + CommitteeBoxB.Text + "\n";
                        summary += formermember + "\n\n";

                        summary += "Total Fee: " + totalbill;

                        queryDB.insert("student_no", "student_info");
                        queryDB.update(formermember, "Member_Type", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(totalbill.ToString(), "Fee", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(LnameBox.Text + ", " + FnameBox.Text + ", " + MnameBox.Text + ".", "Full_Name", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(nicknameBox.Text, "Nick_Name", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(colegBox.Text, "College", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(courBox.Text, "Course", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(yearBox.Text, "Year_Level", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(conoBox.Text, "Contact_No", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(emailBox.Text, "Email_Address", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(CommitteeBoxA.Text + " / " + CommitteeBoxB.Text, "Committees", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(availOrgs.Text, "Organization", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(imageLocation, "picture", "student_no", queryDB.Last_Created_ID, "student_info");
                        queryDB.update(stunoBox.Text, "student_no", "student_no", queryDB.Last_Created_ID, "student_info");



                        MessageBox.Show(summary, "Registration Summary", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Student Number '" + stunoBox.Text + "' Already Exists!");
                    }
                }
                
            }
            else
            {
                ErrorLabel.Visible = true;
                LnameBox.BackColor = Color.Crimson;

                emailBox.BackColor = Color.Crimson;

                stunoBox.BackColor = Color.Crimson;

                colegBox.BackColor = Color.Crimson;

                courBox.BackColor = Color.Crimson;

                yearBox.BackColor = Color.Crimson;

                CommitteeBoxA.BackColor = Color.Crimson;

                CommitteeBoxB.BackColor = Color.Crimson;

                availOrgs.BackColor = Color.Crimson;
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void display_info(string AAAAAAAAA)
        {
            infoBox.Text = AAAAAAAAA;
        }

        private void memstathover(object sender, EventArgs e)
        {
            display_info("Are you a former member of a selected organization? You might be subject to a 10% Discount!");
        }

        private void orghover(object sender, EventArgs e)
        {
            display_info("Choose an Organization you want to join in! Availability is heavily dependent on your current course.");
        }

        private void comithover(object sender, EventArgs e)
        {
            display_info("Join a Committee! Note that Finance and Auditing, Academics Multimedia and Animation is restricted selection to 1st and 2nd year level");
        }

        private void nameHover(object sender, EventArgs e)
        {
            display_info("Enter Your personal information on the field provided. Be honest.");
        }

        private void acceptButton_MouseEnter(object sender, EventArgs e)
        {
            display_info("Accept All Information and Register. Make sure you have entered all required fields");
        }

        private void cancelHover(object sender, EventArgs e)
        {
            display_info("Cancel Registration Process. Unsaved Progress will be lost.");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void CollegeFieldTampered(object sender, EventArgs e)
        {
            courBox.SelectedItem = null;
            courBox.Items.Clear();
            availOrgs.SelectedItem = null;
            availOrgs.Items.Clear();
            switch (colegBox.Text)
            {
                case "College of Engineering":
                    string[] engineeringCourses = { "BS Information Technology", "BS Computer Science", "BS Computer Engineering", "BS Electronics and Communication Engineering" };
                    string[] engineeringOrgs = { "Association of Computer Studies and Systems Students",
                                        "Computer Engineering Students Society",
                                        "Electronics Engineering Society – Institute of Electronic Engineers of the Philippines",
                                        "League of Information Technology Students" };
                    courBox.Items.AddRange(engineeringCourses);
                    availOrgs.Items.AddRange(engineeringOrgs);
                    break;

                case "Business Administration":
                    string[] businessCourses = { "BS Accountancy", "BS Business Administration", "BS Finance", "BS Marketing" };
                    string[] businessOrgs = { "Junior Financial Executives",
                                     "Junior Philippine Institute of Accountants",
                                     "Junior Executive Marketing Society" };
                    courBox.Items.AddRange(businessCourses);
                    availOrgs.Items.AddRange(businessOrgs);
                    break;

                case "Fine Arts and Design":
                    string[] fineArtsCourses = { "BS Architecture", "BS Advertising", "BS Interior Design", "BS Fine Arts" };
                    string[] fineArtsOrgs = { "Buklod Sining",
                                     "United Architects of the Philippines Student Auxiliary",
                                     "Society of Interior Design Students" };
                    courBox.Items.AddRange(fineArtsCourses);
                    availOrgs.Items.AddRange(fineArtsOrgs);
                    break;

                default:
                    break;
            }
        }

        private void orgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void committeeChangedA(object sender, EventArgs e)
        {
            string[] committees = { "Creative and Design", "Finance and Auditing", "Business Marketing", "Academics", "Non-Academics", "Multimedia and Animation", "Personality Development" };
            CommitteeBoxB.Items.Clear();
            CommitteeBoxB.Items.AddRange(committees);
            CommitteeBoxB.Items.Remove(CommitteeBoxA.Text);
        }

        private void committeeChangedB(object sender, EventArgs e)
        {
            string[] committees = { "Creative and Design", "Finance and Auditing", "Business Marketing", "Academics", "Non-Academics", "Multimedia and Animation", "Personality Development" };
            CommitteeBoxA.Items.Clear();
            CommitteeBoxA.Items.AddRange(committees);
            CommitteeBoxA.Items.Remove(CommitteeBoxB.Text);
        }

        private void CommitteeBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private float GetOrgPrice(string orgName)
        {
            switch (orgName)
            {
                case "Association of Computer Studies and Systems Students":
                    return 150.00f;
                case "Computer Engineering Students Society":
                    return 140.00f;
                case "Electronics Engineering Society – Institute of Electronic Engineers of the Philippines":
                    return 200.00f;
                case "League of Information Technology Students":
                    return 160.00f;
                case "Junior Financial Executives":
                    return 150.00f;
                case "Junior Philippine Institute of Accountants":
                    return 200.00f;
                case "Junior Executive Marketing Society":
                    return 175.00f;
                case "Buklod Sining":
                    return 150.00f;
                case "United Architects of the Philippines Student Auxiliary":
                    return 175.00f;
                case "Society of Interior Design Students":
                    return 150.00f;
                default:
                    throw new ArgumentException($"Unknown organization: {orgName}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
