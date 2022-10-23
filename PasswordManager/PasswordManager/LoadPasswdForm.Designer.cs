namespace PasswordManager
{
    partial class LoadPasswdForm
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
            this.butChangeAction = new System.Windows.Forms.Button();
            this.butGenerate = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labeUsername = new System.Windows.Forms.Label();
            this.labelPaswd = new System.Windows.Forms.Label();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.butLoad = new System.Windows.Forms.Button();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butChangeAction
            // 
            this.butChangeAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butChangeAction.Location = new System.Drawing.Point(462, 392);
            this.butChangeAction.Name = "butChangeAction";
            this.butChangeAction.Size = new System.Drawing.Size(148, 29);
            this.butChangeAction.TabIndex = 0;
            this.butChangeAction.Text = "Change Action";
            this.butChangeAction.UseVisualStyleBackColor = true;
            this.butChangeAction.Click += new System.EventHandler(this.butChangeAction_Click);
            // 
            // butGenerate
            // 
            this.butGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butGenerate.Location = new System.Drawing.Point(3, 179);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(284, 30);
            this.butGenerate.TabIndex = 7;
            this.butGenerate.Text = "Generate";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butQuit.Location = new System.Drawing.Point(12, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 9;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(135, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 40);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Upload your new password";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeUsername
            // 
            this.labeUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeUsername.AutoSize = true;
            this.labeUsername.Location = new System.Drawing.Point(397, 5);
            this.labeUsername.Name = "labeUsername";
            this.labeUsername.Size = new System.Drawing.Size(75, 20);
            this.labeUsername.TabIndex = 5;
            this.labeUsername.Text = "Username";
            // 
            // labelPaswd
            // 
            this.labelPaswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPaswd.AutoSize = true;
            this.labelPaswd.Location = new System.Drawing.Point(400, 124);
            this.labelPaswd.Name = "labelPaswd";
            this.labelPaswd.Size = new System.Drawing.Size(70, 20);
            this.labelPaswd.TabIndex = 6;
            this.labelPaswd.Text = "Password";
            // 
            // tbPasswd
            // 
            this.tbPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswd.Location = new System.Drawing.Point(293, 180);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(284, 27);
            this.tbPasswd.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(293, 61);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(284, 27);
            this.tbUsername.TabIndex = 2;
            // 
            // butLoad
            // 
            this.butLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoad.Location = new System.Drawing.Point(245, 335);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(130, 30);
            this.butLoad.TabIndex = 8;
            this.butLoad.Text = "Load password";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // tbAlias
            // 
            this.tbAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlias.Location = new System.Drawing.Point(3, 61);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(284, 27);
            this.tbAlias.TabIndex = 1;
            // 
            // labelAlias
            // 
            this.labelAlias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(96, 5);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(97, 20);
            this.labelAlias.TabIndex = 4;
            this.labelAlias.Text = "Account alias";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Generate secure password";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbPasswd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPaswd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.butGenerate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labeUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAlias, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbAlias, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 239);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // LoadPasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butChangeAction);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "LoadPasswdForm";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadPasswdForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button butChangeAction;
        private Button butGenerate;
        private Button butQuit;
        private Label labelTitle;
        private Label labeUsername;
        private Label labelPaswd;
        private TextBox tbPasswd;
        private TextBox tbUsername;
        private Button butLoad;
        private TextBox tbAlias;
        private Label labelAlias;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}