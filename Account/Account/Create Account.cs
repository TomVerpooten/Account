using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class frmC_A : Form
    {
        string strUserName;
        string strPassWord;

        int intDutch;

        public frmC_A(string UserName, string strPassWord, int intDutch)
        {
            this.strUserName = strUserName;
            this.strPassWord = strPassWord;

            this.intDutch = intDutch;

            InitializeComponent();
        }

        private void frmC_A_Load(object sender, EventArgs e)
        {
            if (intDutch == 0)
            {
                Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
                Create_Account.Text = "Account maken";

                lblFirstName.Text = "Voornaam:";
                lblSecondName.Text = "Achternaam:";
                lblStudyDirection.Text = "Studie richting:";

                btnNext.Text = "Volgende";
                btnHome.Text = "Start";
                btnShutDown.Text = "Afsluiten";
                btnBack.Text = "Terug";
            }

            else
            {
                Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
                Create_Account.Text = "Create account";

                lblFirstName.Text = "First Name:";
                lblSecondName.Text = "Second Name:";
                lblStudyDirection.Text = "Study Direction:";

                btnNext.Text = "Next";
                btnHome.Text = "Home";
                btnShutDown.Text = "Shut down";
                btnBack.Text = "Back";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form SecondHome = new frmSecondHome(strUserName, strPassWord, intDutch);
            SecondHome.Show();
            //Shows Second Home;

            Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
            this.Hide();
            //Close/ Hide Create Account;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (intDutch == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bent u zeker dat u wilt afsluiten", "Afsluiten", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                //closing application;                
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to shut down the application?", "Shut down", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                //closing application;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string strFirstName, strSecondName;
                string strPassWord, strFirstNameWW, strSecondNameWW, strStudyDirectionWW, strUserName;

                strFirstName = txtFirstName.Text;
                strSecondName = txtSecondName.Text;

                strStudyDirectionWW = txtStudyDirection.Text;
                strFirstNameWW = strFirstName.Substring(0, 2);
                strSecondNameWW = strSecondName.Substring(0, 3);

                strPassWord = strSecondNameWW + strFirstNameWW + strStudyDirectionWW;
                strUserName = strFirstNameWW + strSecondNameWW;

                if (intDutch == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Hey " + strFirstName + " " + strSecondName + ", your username is " + strUserName + " and your password is " + strPassWord, "Login info", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        Form LogIn = new frmLogin(strUserName, strPassWord, intDutch);
                        LogIn.Show();
                        //Show form Login;

                        Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
                        this.Close();
                        //Close/ Hide form Create_Account;
                    }
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Hallo " + strFirstName + " " + strSecondName + ", je gebruikersnaam is " + strUserName + " en je wachtwoord is " + strPassWord, "Log in gegevens", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        Form LogIn = new frmLogin(strUserName, strPassWord, intDutch);
                        LogIn.Show();
                        //Show form Login;

                        Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
                        this.Close();
                        //Close/ Hide form Create_Account;
                    }
                }
            }

            catch
            {
                if (txtFirstName.Text == "" || txtSecondName.Text == "" || txtStudyDirection.Text == "")
                {
                    if (intDutch == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Gelieve de textboxen in te vullen.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.OK)
                        {

                        }
                        //Prevent a system crash, caused by empty textboxes;
                    }

                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please fill in the textboxes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.OK)
                        {

                        }
                        //Prevent a system crash, caused by empty textboxes;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form SecondHome = new frmSecondHome(strUserName, strPassWord, intDutch);
            SecondHome.Show();
            //Show form Second Home;

            Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
            this.Close();
            //Close/ Hide form Create_Account;
        }
    }
}