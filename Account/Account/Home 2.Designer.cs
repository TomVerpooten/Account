namespace Account
{
    partial class frmSecondHome
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
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnDutch = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnC_A = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnA_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShutDown
            // 
            this.btnShutDown.Location = new System.Drawing.Point(226, 307);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(101, 50);
            this.btnShutDown.TabIndex = 35;
            this.btnShutDown.Text = "Afsluiten";
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(119, 307);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(101, 50);
            this.btnEnglish.TabIndex = 34;
            this.btnEnglish.Text = "Engels";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnDutch
            // 
            this.btnDutch.Location = new System.Drawing.Point(12, 307);
            this.btnDutch.Name = "btnDutch";
            this.btnDutch.Size = new System.Drawing.Size(101, 50);
            this.btnDutch.TabIndex = 33;
            this.btnDutch.Text = "Nederlands";
            this.btnDutch.UseVisualStyleBackColor = true;
            this.btnDutch.Click += new System.EventHandler(this.btnDutch_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 50);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnC_A
            // 
            this.btnC_A.Location = new System.Drawing.Point(12, 12);
            this.btnC_A.Name = "btnC_A";
            this.btnC_A.Size = new System.Drawing.Size(101, 50);
            this.btnC_A.TabIndex = 24;
            this.btnC_A.Text = "Account maken\r\nRandom wachtwoord";
            this.btnC_A.UseVisualStyleBackColor = true;
            this.btnC_A.Click += new System.EventHandler(this.btnC_A_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(278, 360);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 13);
            this.lblTime.TabIndex = 39;
            this.lblTime.Text = "...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 360);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 13);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "...";
            // 
            // btnA_C
            // 
            this.btnA_C.Location = new System.Drawing.Point(12, 68);
            this.btnA_C.Name = "btnA_C";
            this.btnA_C.Size = new System.Drawing.Size(101, 50);
            this.btnA_C.TabIndex = 40;
            this.btnA_C.Text = "Account maken\r\nEigen wachtwoord";
            this.btnA_C.UseVisualStyleBackColor = true;
            this.btnA_C.Click += new System.EventHandler(this.btnA_C_Click);
            // 
            // frmSecondHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 382);
            this.Controls.Add(this.btnA_C);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnDutch);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnC_A);
            this.Name = "frmSecondHome";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.frmSecondHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnDutch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnC_A;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnA_C;
    }
}