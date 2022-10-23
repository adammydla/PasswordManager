namespace PasswordManager
{
    partial class ChooseActionForm
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
            this.butChoose = new System.Windows.Forms.Button();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.butQuit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butChoose
            // 
            this.butChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.butChoose.Location = new System.Drawing.Point(250, 246);
            this.butChoose.Name = "butChoose";
            this.butChoose.Size = new System.Drawing.Size(120, 30);
            this.butChoose.TabIndex = 0;
            this.butChoose.Text = "Choose";
            this.butChoose.UseVisualStyleBackColor = true;
            this.butChoose.Click += new System.EventHandler(this.butChoose_Click);
            // 
            // cbActions
            // 
            this.cbActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActions.Location = new System.Drawing.Point(140, 162);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(340, 28);
            this.cbActions.TabIndex = 1;
            // 
            // butQuit
            // 
            this.butQuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butQuit.Location = new System.Drawing.Point(250, 391);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(120, 30);
            this.butQuit.TabIndex = 2;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(140, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(340, 40);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Choose your desired action";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.cbActions);
            this.Controls.Add(this.butChoose);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "ChooseActionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseActionForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button butChoose;
        private ComboBox cbActions;
        private Button butQuit;
        private Label labelTitle;
    }
}