namespace PasswordManager
{
    partial class DeletePasswdForm
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
            this.labelSuitable = new System.Windows.Forms.Label();
            this.labelAlias = new System.Windows.Forms.Label();
            this.butChangeAction = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butFilter = new System.Windows.Forms.Button();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.cbPasswords = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSort = new System.Windows.Forms.Label();
            this.rbSortAsc = new System.Windows.Forms.RadioButton();
            this.rbSortDesc = new System.Windows.Forms.RadioButton();
            this.rbSortDef = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSuitable
            // 
            this.labelSuitable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuitable.AutoSize = true;
            this.labelSuitable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuitable.Location = new System.Drawing.Point(53, 14);
            this.labelSuitable.Name = "labelSuitable";
            this.labelSuitable.Size = new System.Drawing.Size(177, 28);
            this.labelSuitable.TabIndex = 0;
            this.labelSuitable.Text = "Suitable Passwords";
            // 
            // labelAlias
            // 
            this.labelAlias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(92, 60);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(99, 20);
            this.labelAlias.TabIndex = 2;
            this.labelAlias.Text = "Account Alias";
            // 
            // butChangeAction
            // 
            this.butChangeAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butChangeAction.Location = new System.Drawing.Point(490, 391);
            this.butChangeAction.Name = "butChangeAction";
            this.butChangeAction.Size = new System.Drawing.Size(120, 30);
            this.butChangeAction.TabIndex = 3;
            this.butChangeAction.Text = "Change Action";
            this.butChangeAction.UseVisualStyleBackColor = true;
            this.butChangeAction.Click += new System.EventHandler(this.butChangeAction_Click);
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butQuit.Location = new System.Drawing.Point(12, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 4;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butDelete.Location = new System.Drawing.Point(57, 137);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(170, 30);
            this.butDelete.TabIndex = 5;
            this.butDelete.Text = "Delete Password";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butFilter
            // 
            this.butFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butFilter.Location = new System.Drawing.Point(94, 137);
            this.butFilter.Name = "butFilter";
            this.butFilter.Size = new System.Drawing.Size(95, 30);
            this.butFilter.TabIndex = 6;
            this.butFilter.Text = "Filter";
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
            // 
            // tbAlias
            // 
            this.tbAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlias.Location = new System.Drawing.Point(0, 98);
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(284, 27);
            this.tbAlias.TabIndex = 7;
            // 
            // cbPasswords
            // 
            this.cbPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPasswords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasswords.FormattingEnabled = true;
            this.cbPasswords.Location = new System.Drawing.Point(0, 98);
            this.cbPasswords.Name = "cbPasswords";
            this.cbPasswords.Size = new System.Drawing.Size(284, 28);
            this.cbPasswords.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(120, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(380, 40);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Delete your selected password";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(114, 14);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(56, 28);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelSort);
            this.panel1.Controls.Add(this.labelSuitable);
            this.panel1.Controls.Add(this.rbSortAsc);
            this.panel1.Controls.Add(this.cbPasswords);
            this.panel1.Controls.Add(this.rbSortDesc);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.rbSortDef);
            this.panel1.Location = new System.Drawing.Point(293, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 309);
            this.panel1.TabIndex = 11;
            // 
            // labelSort
            // 
            this.labelSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(85, 193);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(113, 20);
            this.labelSort.TabIndex = 10;
            this.labelSort.Text = "Sorting Options";
            // 
            // rbSortAsc
            // 
            this.rbSortAsc.AutoSize = true;
            this.rbSortAsc.Location = new System.Drawing.Point(68, 251);
            this.rbSortAsc.Name = "rbSortAsc";
            this.rbSortAsc.Size = new System.Drawing.Size(139, 24);
            this.rbSortAsc.TabIndex = 15;
            this.rbSortAsc.TabStop = true;
            this.rbSortAsc.Text = "Ascending order";
            this.rbSortAsc.UseVisualStyleBackColor = true;
            this.rbSortAsc.CheckedChanged += new System.EventHandler(this.rbSortAsc_CheckedChanged);
            // 
            // rbSortDesc
            // 
            this.rbSortDesc.AutoSize = true;
            this.rbSortDesc.Location = new System.Drawing.Point(68, 281);
            this.rbSortDesc.Name = "rbSortDesc";
            this.rbSortDesc.Size = new System.Drawing.Size(148, 24);
            this.rbSortDesc.TabIndex = 16;
            this.rbSortDesc.TabStop = true;
            this.rbSortDesc.Text = "Descending order";
            this.rbSortDesc.UseVisualStyleBackColor = true;
            this.rbSortDesc.CheckedChanged += new System.EventHandler(this.rbSortDesc_CheckedChanged);
            // 
            // rbSortDef
            // 
            this.rbSortDef.AutoSize = true;
            this.rbSortDef.Location = new System.Drawing.Point(68, 221);
            this.rbSortDef.Name = "rbSortDef";
            this.rbSortDef.Size = new System.Drawing.Size(79, 24);
            this.rbSortDef.TabIndex = 14;
            this.rbSortDef.TabStop = true;
            this.rbSortDef.Text = "Default";
            this.rbSortDef.UseVisualStyleBackColor = true;
            this.rbSortDef.CheckedChanged += new System.EventHandler(this.rbSortDef_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelFilter);
            this.panel2.Controls.Add(this.labelAlias);
            this.panel2.Controls.Add(this.tbAlias);
            this.panel2.Controls.Add(this.butFilter);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 309);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 315);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // DeletePasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butChangeAction);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "DeletePasswdForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeletePasswdForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelSuitable;
        private Label labelAlias;
        private Button butChangeAction;
        private Button butQuit;
        private Button butDelete;
        private Button butFilter;
        private TextBox tbAlias;
        private ComboBox cbPasswords;
        private Label labelTitle;
        private Label labelFilter;
        private Panel panel1;
        private Panel panel2;
        private Label labelSort;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton rbSortAsc;
        private RadioButton rbSortDesc;
        private RadioButton rbSortDef;
    }
}