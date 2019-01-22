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
    public partial class frmTasks : Form
    {
        string strUserName;
        string strPassWord;

        int intDutch;

        public frmTasks(int intDutch)
        {
            this.intDutch = intDutch;

            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strInput;

                strInput = txtInput.Text;

                lbxTasks.Items.Add(strInput);
                txtInput.Text = string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strInput;

            strInput = txtInput.Text;

            lbxTasks.Items[lbxTasks.SelectedIndex] = "";
            lbxTasks.Items[lbxTasks.SelectedIndex] = strInput;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
        }

        private void frmTasks_Load(object sender, EventArgs e)
        {
            lbxTasks.Text = "";

            if (intDutch == 0)
            {
                Form Tasks = new frmTasks(intDutch);
                Tasks.Text = "Taken noties";

                btnEdit.Text = "Bewerken";
                btnDelete.Text = "Verwijderen";
                btnHome.Text = "Start";
                btnShutDown.Text = "Afsluiten";
                btnBack.Text = "Terug";
            }

            else
            {
                Form Tasks = new frmTasks(intDutch);
                Tasks.Text = "Tasks";

                btnEdit.Text = "Edit";
                btnDelete.Text = "Delete";
                btnHome.Text = "Home";
                btnShutDown.Text = "Shut down";
                btnBack.Text = "Back";
            }

            Timer Time = new Timer();

            Time.Interval = 1000;
            Time.Tick+=new EventHandler(Time_Tick);
            Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-YYYY");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Login = new frmLogin(strUserName, strPassWord, intDutch);
            Login.Show();

            Form Tasks = new frmTasks(intDutch);
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form SecondHome = new frmSecondHome(strUserName, strPassWord, intDutch);
            SecondHome.Show();

            Form Tasks = new frmTasks(intDutch);
            this.Hide();
        }
    }
}