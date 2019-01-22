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
    public partial class frmHome : Form
    {
        string strUserName;
        string strPassWord;

        int intDutch;

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnDutch_Click(object sender, EventArgs e)
        {
            Form Home = new frmHome();
            Home.Text = "Start";

            btnC_A.Text = "Account maken" + Environment.NewLine + "Random wachtwoord";
            btnA_C.Text = "Account maken" + Environment.NewLine + "Eigen wachtwoord";
            btnLogin.Text = "Log in";

            btnDutch.Text = "Nederlands";
            btnEnglish.Text = "Engels";
            btnShutDown.Text = "Afsluiten";

            intDutch = 0;
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Form Home = new frmHome();
            Home.Text = "Home";

            btnC_A.Text = "Create account" + Environment.NewLine + "Random password";
            btnA_C.Text = "Create account" + Environment.NewLine + "Own password";
            btnLogin.Text = "Login";

            btnDutch.Text = "Dutch";
            btnEnglish.Text = "English";
            btnShutDown.Text = "Shut down";

            intDutch = 1;
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

            if (intDutch == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to shut down the application?", "Shut down", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                //closing application;
            }
        }

        private void btnC_A_Click(object sender, EventArgs e)
        {
            Form Create_Account = new frmC_A(strUserName, strPassWord, intDutch);
            Create_Account.Show();
            //Shows Create_Account;

            Form Home = new frmHome();
            this.Hide();
            //Close/ Hide Home;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form Login = new frmLogin(strUserName, strPassWord, intDutch);
            Login.Show();

            Form Home = new frmHome();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (intDutch == 0)
            {
                Form Home = new frmHome();
                Home.Text = "Start";

                btnC_A.Text = "Account maken" + Environment.NewLine + "Random wachtwoord";
                btnA_C.Text = "Account maken" + Environment.NewLine + "Eigen wachtwoord";
                btnLogin.Text = "Log in";

                btnDutch.Text = "Nederlands";
                btnEnglish.Text = "Engels";
                btnShutDown.Text = "Afsluiten";
            }

            else
            {
                Form Home = new frmHome();
                Home.Text = "Home";

                btnC_A.Text = "Create account" + Environment.NewLine + "Random password";
                btnA_C.Text = "Create account" + Environment.NewLine + "Own password";
                btnLogin.Text = "Login";

                btnDutch.Text = "Dutch";
                btnEnglish.Text = "English";
                btnShutDown.Text = "Shut down";
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

        private void btnA_C_Click(object sender, EventArgs e)
        {
            Form Account_Create = new frmA_C(strUserName, strPassWord, intDutch);
            Account_Create.Show();

            Form Home = new frmHome();
            this.Hide();
        }
    }
}