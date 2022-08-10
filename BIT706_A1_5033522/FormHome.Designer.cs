namespace BIT706_A1_5033522
{
    partial class FormHome
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.buttonLastTrans = new System.Windows.Forms.Button();
            this.textBoxTransHistory = new System.Windows.Forms.TextBox();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.upDown = new System.Windows.Forms.NumericUpDown();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.labelAccounts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTitle.Location = new System.Drawing.Point(173, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "The Bank.";
            this.labelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(186, 56);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(290, 95);
            this.listBoxAccounts.TabIndex = 1;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // buttonLastTrans
            // 
            this.buttonLastTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLastTrans.Location = new System.Drawing.Point(30, 364);
            this.buttonLastTrans.Name = "buttonLastTrans";
            this.buttonLastTrans.Size = new System.Drawing.Size(150, 40);
            this.buttonLastTrans.TabIndex = 2;
            this.buttonLastTrans.Text = "Last Transaction";
            this.buttonLastTrans.UseVisualStyleBackColor = true;
            this.buttonLastTrans.Click += new System.EventHandler(this.ButtonLastTrans_Click);
            // 
            // textBoxTransHistory
            // 
            this.textBoxTransHistory.Location = new System.Drawing.Point(186, 276);
            this.textBoxTransHistory.Multiline = true;
            this.textBoxTransHistory.Name = "textBoxTransHistory";
            this.textBoxTransHistory.Size = new System.Drawing.Size(290, 147);
            this.textBoxTransHistory.TabIndex = 3;
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountInfo.Location = new System.Drawing.Point(30, 82);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(150, 40);
            this.buttonAccountInfo.TabIndex = 4;
            this.buttonAccountInfo.Text = "Account Info";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            this.buttonAccountInfo.Click += new System.EventHandler(this.ButtonAccountInfo_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(186, 173);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(150, 40);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.ButtonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(186, 219);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(150, 40);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.ButtonWithdraw_Click);
            // 
            // upDown
            // 
            this.upDown.DecimalPlaces = 2;
            this.upDown.Location = new System.Drawing.Point(345, 210);
            this.upDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDown.Name = "upDown";
            this.upDown.Size = new System.Drawing.Size(84, 20);
            this.upDown.TabIndex = 7;
            this.upDown.ValueChanged += new System.EventHandler(this.upDown_ValueChanged);
            // 
            // buttonInterest
            // 
            this.buttonInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterest.Location = new System.Drawing.Point(30, 304);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(150, 40);
            this.buttonInterest.TabIndex = 8;
            this.buttonInterest.Text = "Interest";
            this.buttonInterest.UseVisualStyleBackColor = true;
            this.buttonInterest.Click += new System.EventHandler(this.ButtonInterest_Click);
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccounts.Location = new System.Drawing.Point(292, 33);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(84, 20);
            this.labelAccounts.TabIndex = 9;
            this.labelAccounts.Text = "Accounts";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(544, 458);
            this.Controls.Add(this.labelAccounts);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.upDown);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.textBoxTransHistory);
            this.Controls.Add(this.buttonLastTrans);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormHome";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button buttonLastTrans;
        private System.Windows.Forms.TextBox textBoxTransHistory;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.NumericUpDown upDown;
        private System.Windows.Forms.Button buttonInterest;
        private System.Windows.Forms.Label labelAccounts;
    }
}

