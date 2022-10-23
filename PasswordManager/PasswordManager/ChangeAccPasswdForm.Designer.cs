namespace PasswordManager
{
    partial class ChangeAccPasswdForm
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
            this.labelNewPasswd = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOldPasswd = new System.Windows.Forms.Label();
            this.butQuit = new System.Windows.Forms.Button();
            this.butChangeAction = new System.Windows.Forms.Button();
            this.butChangePasswd = new System.Windows.Forms.Button();
            this.tbOldPasswd = new System.Windows.Forms.TextBox();
            this.tbNewPasswd = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNewPasswd
            // 
            this.labelNewPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNewPasswd.AutoSize = true;
            this.labelNewPasswd.Location = new System.Drawing.Point(383, 12);
            this.labelNewPasswd.Name = "labelNewPasswd";
            this.labelNewPasswd.Size = new System.Drawing.Size(104, 20);
            this.labelNewPasswd.TabIndex = 0;
            this.labelNewPasswd.Text = "New Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(107, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(115, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(390, 40);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Change your account password";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOldPasswd
            // 
            this.labelOldPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOldPasswd.AutoSize = true;
            this.labelOldPasswd.Location = new System.Drawing.Point(96, 12);
            this.labelOldPasswd.Name = "labelOldPasswd";
            this.labelOldPasswd.Size = new System.Drawing.Size(98, 20);
            this.labelOldPasswd.TabIndex = 3;
            this.labelOldPasswd.Text = "Old Password";
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butQuit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butQuit.Location = new System.Drawing.Point(12, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 4;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // butChangeAction
            // 
            this.butChangeAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butChangeAction.Location = new System.Drawing.Point(490, 391);
            this.butChangeAction.Name = "butChangeAction";
            this.butChangeAction.Size = new System.Drawing.Size(120, 30);
            this.butChangeAction.TabIndex = 5;
            this.butChangeAction.Text = "Change Action";
            this.butChangeAction.UseVisualStyleBackColor = true;
            this.butChangeAction.Click += new System.EventHandler(this.butChangeAction_Click);
            // 
            // butChangePasswd
            // 
            this.butChangePasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butChangePasswd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butChangePasswd.Location = new System.Drawing.Point(230, 305);
            this.butChangePasswd.Name = "butChangePasswd";
            this.butChangePasswd.Size = new System.Drawing.Size(160, 40);
            this.butChangePasswd.TabIndex = 6;
            this.butChangePasswd.Text = "Change Password";
            this.butChangePasswd.UseVisualStyleBackColor = true;
            this.butChangePasswd.Click += new System.EventHandler(this.butChangePasswd_Click);
            // 
            // tbOldPasswd
            // 
            this.tbOldPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldPasswd.Location = new System.Drawing.Point(3, 48);
            this.tbOldPasswd.Name = "tbOldPasswd";
            this.tbOldPasswd.Size = new System.Drawing.Size(284, 27);
            this.tbOldPasswd.TabIndex = 7;
            // 
            // tbNewPasswd
            // 
            this.tbNewPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPasswd.Location = new System.Drawing.Point(293, 48);
            this.tbNewPasswd.Name = "tbNewPasswd";
            this.tbNewPasswd.Size = new System.Drawing.Size(284, 27);
            this.tbNewPasswd.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(3, 48);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(284, 27);
            this.tbUsername.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbUsername, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(165, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 90);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelOldPasswd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNewPasswd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNewPasswd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbOldPasswd, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 90);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // ChangeAccPasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.butChangePasswd);
            this.Controls.Add(this.butChangeAction);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "ChangeAccPasswdForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeAccPasswdForm_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNewPasswd;
        private Label labelUsername;
        private Label labelTitle;
        private Label labelOldPasswd;
        private Button butQuit;
        private Button butChangeAction;
        private Button butChangePasswd;
        private TextBox tbOldPasswd;
        private TextBox tbNewPasswd;
        private TextBox tbUsername;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}