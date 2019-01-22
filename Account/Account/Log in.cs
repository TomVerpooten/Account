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
    public partial class frmLogin : Form
    {
        string strUserName;
        string strPassWord;

        int intDutch;

        public frmLogin(string strUserName, string strPassWord, int intDutch)
        {
            this.strUserName = strUserName;
            this.strPassWord = strPassWord;

            this.intDutch = intDutch;

            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (intDutch == 0)
            {
                Form Login = new frmLogin(strUserName, strPassWord, intDutch);
                Login.Text = "Log in";

                lblUserName.Text = "Gebruikersnaam:";
                lblPassWord.Text = "Wachtwoord:";

                btnNext.Text = "Volgende";
                btnHome.Text = "Start";
                btnShutDown.Text = "Afsluiten";
                btnBack.Text = "Terug";
            }
            else
            {
                Form Login = new frmLogin(strUserName, strPassWord,intDutch);
                Login.Text = "Login";

                lblUserName.Text = "User name:";
                lblPassWord.Text = "Password:";

                btnNext.Text = "Next";
                btnHome.Text = "Home";
                btnShutDown.Text = "Shut down";
                btnBack.Text = "Back";
            }

            Timer Time = new Timer();

            Time.Interval = 1000;
            Time.Tick += new EventHandler(Time_Tick);
            Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-YYYY");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form SecondHome = new frmSecondHome(strUserName, strPassWord, intDutch);
            SecondHome.Show();
            //Shows Second Home;

            Form Login = new frmLogin(strUserName, strPassWord, intDutch);
            this.Hide();
            //Close/ Hide Login;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
            Create_Account.Show();
            //Show form Create_Account;

            Form Login = new frmLogin(strUserName, strPassWord,intDutch);
            this.Close();
            //Close/ Hide form Login;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form Tasks = new frmTasks(intDutch);
            Tasks.Show();

            Form Login = new frmLogin(strUserName, strPassWord, intDutch);
            this.Hide();
        }
    }
}