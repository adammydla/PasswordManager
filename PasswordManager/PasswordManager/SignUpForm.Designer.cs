namespace PasswordManager
{
    partial class SignUpForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.butSignUp = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.butQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(0, 60);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(283, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswd.Location = new System.Drawing.Point(0, 147);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(283, 27);
            this.tbPasswd.TabIndex = 1;
            // 
            // butSignUp
            // 
            this.butSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butSignUp.Location = new System.Drawing.Point(65, 220);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(154, 30);
            this.butSignUp.TabIndex = 2;
            this.butSignUp.Text = "Sign Up";
            this.butSignUp.UseVisualStyleBackColor = true;
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(104, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 20);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelPasswd
            // 
            this.labelPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Location = new System.Drawing.Point(107, 117);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(70, 20);
            this.labelPasswd.TabIndex = 4;
            this.labelPasswd.Text = "Password";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(115, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(390, 40);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Create your own account";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butQuit.Location = new System.Drawing.Point(12, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 6;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.tbPasswd);
            this.panel1.Controls.Add(this.labelPasswd);
            this.panel1.Controls.Add(this.butSignUp);
            this.panel1.Location = new System.Drawing.Point(168, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 300);
            this.panel1.TabIndex = 7;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "SignUpForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPasswd;
        private Button butSignUp;
        private Label labelUsername;
        private Label labelPasswd;
        private Label labelTitle;
        private Button butQuit;
        private Panel panel1;
    }
}