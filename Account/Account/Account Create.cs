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
    public partial class frmA_C : Form
    {
        string strUserName;
        string strPassWord;

        int intDutch;

        public frmA_C(string UserName, string strPassWord, int intDutch)
        {
            this.strUserName = strUserName;
            this.strPassWord = strPassWord;

            this.intDutch = intDutch;

            InitializeComponent();
        }

        private void frmA_C_Load(object sender, EventArgs e)
        {
            if (intDutch == 0)
            {
                Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
                Account_Create.Text = "Account maken";

                lblFirstName.Text = "Voornaam:";
                lblSecondName.Text = "Achternaam:";
                lblPassWord.Text = "Wachtwoord:";
                lblConfirmPassWord.Text = "Bevestig wachtwoord:";

                btnNext.Text = "Volgende";
                btnHome.Text = "Start";
                btnShutDown.Text = "Afsluiten";
                btnBack.Text = "Terug";
            }

            else
            {
                Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
                Account_Create.Text = "Create account";

                lblFirstName.Text = "First Name:";
                lblSecondName.Text = "Second Name:";
                lblPassWord.Text = "Password:";
                lblConfirmPassWord.Text = "Confirm password:";

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

            Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
            this.Hide();
            //Close/ Hide Account_Create;
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
                string strFirstName, strSecondName, strFirstUserName, strSecondUserName;
                string strPassWord, strConfirmPassWord, strUserName;

                strFirstName = txtFirstName.Text;
                strSecondName = txtSecondName.Text;
                strPassWord = txtPassWord.Text;
                strConfirmPassWord = txtConfirmPassWord.Text;

                strFirstUserName = strFirstName.Substring(0, 2);
                strSecondUserName = strSecondName.Substring(0, 3);

                strUserName = strFirstUserName + strSecondUserName;

                if (strPassWord != strConfirmPassWord)
                {
                    if (intDutch == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Your passwords aren't the same.", "Incorrect password", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.OK)
                        {

                        }
                    }

                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Je wachtwoorden komen niet overeen.", "Incorrect wachtwoord", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.OK)
                        {

                        }
                    }
                }

                else
                {
                    if (intDutch == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Hey " + strFirstName + " " + strSecondName + ", your username is " + strUserName + ".", "Login info", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.OK)
                        {
                            Form LogIn = new frmLogin(strUserName, strPassWord, intDutch);
                            LogIn.Show();
                            //Show form Login;

                            Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
                            this.Close();
                            //Close/ Hide form Account_Create;
                        }
                    }

                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Hallo " + strFirstName + " " + strSecondName + ", je gebruikersnaam is " + strUserName + ".", "Log in gegevens", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.OK)
                        {
                            Form LogIn = new frmLogin(strUserName, strPassWord, intDutch);
                            LogIn.Show();
                            //Show form Login;

                            Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
                            this.Close();
                            //Close/ Hide form Account_Create;
                        }
                    }
                }
            }

            catch
            {
                if (txtFirstName.Text == "" || txtSecondName.Text == "" || txtPassWord.Text == "" || txtConfirmPassWord.Text == "")
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

            Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
            this.Close();
            //Close/ Hide form Account_Create;
        }
    }
}