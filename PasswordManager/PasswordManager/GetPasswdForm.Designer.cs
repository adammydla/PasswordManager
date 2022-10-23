namespace PasswordManager
{
    partial class GetPasswdForm
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
            this.cbPasswords = new System.Windows.Forms.ComboBox();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.labelSuitable = new System.Windows.Forms.Label();
            this.labelAlias = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.butFilter = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSortAsc = new System.Windows.Forms.RadioButton();
            this.rbSortDesc = new System.Windows.Forms.RadioButton();
            this.rbSortDef = new System.Windows.Forms.RadioButton();
            this.labelSort = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butChangeAction
            // 
            this.butChangeAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butChangeAction.Location = new System.Drawing.Point(490, 391);
            this.butChangeAction.Name = "butChangeAction";
            this.butChangeAction.Size = new System.Drawing.Size(120, 30);
            this.butChangeAction.TabIndex = 0;
            this.butChangeAction.Text = "Change Action";
            this.butChangeAction.UseVisualStyleBackColor = true;
            this.butChangeAction.Click += new System.EventHandler(this.butChangeAction_Click);
            // 
            // cbPasswords
            // 
            this.cbPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPasswords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasswords.FormattingEnabled = true;
            this.cbPasswords.Location = new System.Drawing.Point(0, 108);
            this.cbPasswords.Name = "cbPasswords";
            this.cbPasswords.Size = new System.Drawing.Size(284, 28);
            this.cbPasswords.TabIndex = 1;
            // 
            // tbAlias
            // 
            this.tbAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlias.Location = new System.Drawing.Point(0, 108);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(284, 27);
            this.tbAlias.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(0, 207);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(284, 27);
            this.tbUsername.TabIndex = 3;
            // 
            // labelSuitable
            // 
            this.labelSuitable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuitable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuitable.Location = new System.Drawing.Point(52, 27);
            this.labelSuitable.Name = "labelSuitable";
            this.labelSuitable.Size = new System.Drawing.Size(180, 30);
            this.labelSuitable.TabIndex = 4;
            this.labelSuitable.Text = "Suitable Passwords";
            // 
            // labelAlias
            // 
            this.labelAlias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(92, 75);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(99, 20);
            this.labelAlias.TabIndex = 5;
            this.labelAlias.Text = "Account Alias";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(104, 165);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 20);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // butFilter
            // 
            this.butFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butFilter.Location = new System.Drawing.Point(71, 283);
            this.butFilter.Name = "butFilter";
            this.butFilter.Size = new System.Drawing.Size(125, 29);
            this.butFilter.TabIndex = 9;
            this.butFilter.Text = "Filter";
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
            // 
            // butShow
            // 
            this.butShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butShow.Location = new System.Drawing.Point(52, 165);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(180, 30);
            this.butShow.TabIndex = 10;
            this.butShow.Text = "Show Password";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butQuit.Location = new System.Drawing.Point(12, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 11;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(112, 30);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(60, 30);
            this.labelFilter.TabIndex = 12;
            this.labelFilter.Text = "Filter";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(105, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(410, 40);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Access your selected password";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbSortAsc);
            this.panel1.Controls.Add(this.rbSortDesc);
            this.panel1.Controls.Add(this.rbSortDef);
            this.panel1.Controls.Add(this.labelSort);
            this.panel1.Controls.Add(this.cbPasswords);
            this.panel1.Controls.Add(this.butShow);
            this.panel1.Controls.Add(this.labelSuitable);
            this.panel1.Location = new System.Drawing.Point(293, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 331);
            this.panel1.TabIndex = 15;
            // 
            // rbSortAsc
            // 
            this.rbSortAsc.AutoSize = true;
            this.rbSortAsc.Location = new System.Drawing.Point(68, 276);
            this.rbSortAsc.Name = "rbSortAsc";
            this.rbSortAsc.Size = new System.Drawing.Size(139, 24);
            this.rbSortAsc.TabIndex = 18;
            this.rbSortAsc.TabStop = true;
            this.rbSortAsc.Text = "Ascending order";
            this.rbSortAsc.UseVisualStyleBackColor = true;
            this.rbSortAsc.CheckedChanged += new System.EventHandler(this.rbSortAsc_CheckedChanged);
            // 
            // rbSortDesc
            // 
            this.rbSortDesc.AutoSize = true;
            this.rbSortDesc.Location = new System.Drawing.Point(68, 306);
            this.rbSortDesc.Name = "rbSortDesc";
            this.rbSortDesc.Size = new System.Drawing.Size(148, 24);
            this.rbSortDesc.TabIndex = 19;
            this.rbSortDesc.TabStop = true;
            this.rbSortDesc.Text = "Descending order";
            this.rbSortDesc.UseVisualStyleBackColor = true;
            this.rbSortDesc.CheckedChanged += new System.EventHandler(this.rbSortDesc_CheckedChanged);
            // 
            // rbSortDef
            // 
            this.rbSortDef.AutoSize = true;
            this.rbSortDef.Location = new System.Drawing.Point(68, 246);
            this.rbSortDef.Name = "rbSortDef";
            this.rbSortDef.Size = new System.Drawing.Size(79, 24);
            this.rbSortDef.TabIndex = 17;
            this.rbSortDef.TabStop = true;
            this.rbSortDef.Text = "Default";
            this.rbSortDef.UseVisualStyleBackColor = true;
            this.rbSortDef.CheckedChanged += new System.EventHandler(this.rbSortDef_CheckedChanged);
            // 
            // labelSort
            // 
            this.labelSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(83, 218);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(113, 20);
            this.labelSort.TabIndex = 14;
            this.labelSort.Text = "Sorting Options";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.butFilter);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.labelFilter);
            this.panel2.Controls.Add(this.tbAlias);
            this.panel2.Controls.Add(this.labelAlias);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 331);
            this.panel2.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 337);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // GetPasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butChangeAction);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "GetPasswdForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetPasswdForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button butChangeAction;
        private ComboBox cbPasswords;
        private TextBox tbAlias;
        private TextBox tbUsername;
        private Label labelSuitable;
        private Label labelAlias;
        private Label labelUsername;
        private Button butFilter;
        private Button butShow;
        private Button butQuit;
        private Label labelFilter;
        private Label labelTitle;
        private Panel panel1;
        private Label labelSort;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton rbSortAsc;
        private RadioButton rbSortDesc;
        private RadioButton rbSortDef;
    }
}