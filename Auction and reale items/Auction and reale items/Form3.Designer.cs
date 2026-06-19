namespace Auction_and_reale_items
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            lblOverallProfit = new Label();
            btnLogout = new Button();
            txtName = new TextBox();
            txtOriginalPrice = new TextBox();
            cmbType = new ComboBox();
            btnAdd = new Button();
            txtBid = new TextBox();
            btnBuy = new Button();
            btnBid = new Button();
            lstItems = new ListBox();
            txtMarkup = new TextBox();
            txtCardNumber = new TextBox();
            txtCardPassword = new TextBox();
            btnAddFunds = new Button();
            lblTimer = new Label();
            lblWallet = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            cmbCategory = new ComboBox();
            lstHistory = new ListBox();
            txtStartBid = new TextBox();
            btnStartAuction = new Button();
            SuspendLayout();
            // 
            // lblOverallProfit
            // 
            lblOverallProfit.AutoSize = true;
            lblOverallProfit.Location = new Point(42, 511);
            lblOverallProfit.Name = "lblOverallProfit";
            lblOverallProfit.Size = new Size(98, 15);
            lblOverallProfit.TabIndex = 1;
            lblOverallProfit.Text = "Overall Profit: 0%";
            lblOverallProfit.Click += lblProfit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(526, 595);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtOriginalPrice
            // 
            txtOriginalPrice.Location = new Point(25, 222);
            txtOriginalPrice.Name = "txtOriginalPrice";
            txtOriginalPrice.Size = new Size(181, 23);
            txtOriginalPrice.TabIndex = 4;
            txtOriginalPrice.TextChanged += txtPrice_TextChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(25, 312);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(181, 23);
            cmbType.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(25, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 33);
            btnAdd.TabIndex = 6;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBid
            // 
            txtBid.Location = new Point(244, 524);
            txtBid.Name = "txtBid";
            txtBid.Size = new Size(127, 23);
            txtBid.TabIndex = 8;
            txtBid.TextChanged += txtBid_TextChanged;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Transparent;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Location = new Point(469, 524);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(98, 32);
            btnBuy.TabIndex = 9;
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnBid
            // 
            btnBid.BackColor = Color.Transparent;
            btnBid.FlatAppearance.BorderSize = 0;
            btnBid.FlatStyle = FlatStyle.Flat;
            btnBid.Location = new Point(388, 524);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(66, 32);
            btnBid.TabIndex = 10;
            btnBid.UseVisualStyleBackColor = false;
            btnBid.Click += btnBid_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(237, 121);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(330, 364);
            lstItems.TabIndex = 11;
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(25, 268);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(181, 23);
            txtMarkup.TabIndex = 12;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(607, 428);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(224, 23);
            txtCardNumber.TabIndex = 13;
            txtCardNumber.TextChanged += textBox1_TextChanged;
            // 
            // txtCardPassword
            // 
            txtCardPassword.Location = new Point(607, 470);
            txtCardPassword.Name = "txtCardPassword";
            txtCardPassword.Size = new Size(224, 23);
            txtCardPassword.TabIndex = 14;
            // 
            // btnAddFunds
            // 
            btnAddFunds.BackColor = Color.Transparent;
            btnAddFunds.FlatAppearance.BorderSize = 0;
            btnAddFunds.FlatStyle = FlatStyle.Flat;
            btnAddFunds.Location = new Point(607, 503);
            btnAddFunds.Name = "btnAddFunds";
            btnAddFunds.Size = new Size(224, 32);
            btnAddFunds.TabIndex = 15;
            btnAddFunds.UseVisualStyleBackColor = false;
            btnAddFunds.Click += btnAddFunds_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(744, 43);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(38, 15);
            lblTimer.TabIndex = 16;
            lblTimer.Text = "label1";
            // 
            // lblWallet
            // 
            lblWallet.AutoSize = true;
            lblWallet.Location = new Point(621, 393);
            lblWallet.Name = "lblWallet";
            lblWallet.Size = new Size(38, 15);
            lblWallet.TabIndex = 18;
            lblWallet.Text = "label2";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(26, 179);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 23);
            cmbCategory.TabIndex = 19;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(590, 121);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(251, 199);
            lstHistory.TabIndex = 20;
            lstHistory.SelectedIndexChanged += lstHistory_SelectedIndexChanged;
            // 
            // txtStartBid
            // 
            txtStartBid.Location = new Point(25, 354);
            txtStartBid.Name = "txtStartBid";
            txtStartBid.Size = new Size(181, 23);
            txtStartBid.TabIndex = 21;
            txtStartBid.TextChanged += txtStartBid_TextChanged;
            // 
            // btnStartAuction
            // 
            btnStartAuction.BackColor = Color.Transparent;
            btnStartAuction.FlatAppearance.BorderSize = 0;
            btnStartAuction.FlatStyle = FlatStyle.Flat;
            btnStartAuction.Location = new Point(25, 422);
            btnStartAuction.Name = "btnStartAuction";
            btnStartAuction.Size = new Size(181, 28);
            btnStartAuction.TabIndex = 26;
            btnStartAuction.UseVisualStyleBackColor = false;
            btnStartAuction.Click += btnStartAuction_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.form31;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 630);
            Controls.Add(btnStartAuction);
            Controls.Add(txtStartBid);
            Controls.Add(lstHistory);
            Controls.Add(cmbCategory);
            Controls.Add(lblWallet);
            Controls.Add(lblTimer);
            Controls.Add(btnAddFunds);
            Controls.Add(txtCardPassword);
            Controls.Add(txtCardNumber);
            Controls.Add(txtMarkup);
            Controls.Add(lstItems);
            Controls.Add(btnBid);
            Controls.Add(btnBuy);
            Controls.Add(txtBid);
            Controls.Add(btnAdd);
            Controls.Add(cmbType);
            Controls.Add(txtOriginalPrice);
            Controls.Add(txtName);
            Controls.Add(btnLogout);
            Controls.Add(lblOverallProfit);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcome;
        private Label lblOverallProfit;
        private Button btnLogout;
        private TextBox txtName;
        private TextBox txtOriginalPrice;
        private ComboBox cmbType;
        private Button btnAdd;
        private TextBox txtBid;
        private Button btnBuy;
        private Button btnBid;
        private ListBox lstItems;
        private TextBox txtMarkup;
        private TextBox txtCardNumber;
        private TextBox txtCardPassword;
        private Button btnAddFunds;
        private Label lblTimer;
        private Label lblWallet;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cmbCategory;
        private ListBox lstHistory;
        private TextBox txtStartBid;
        private Button btnStartAuction;
    }
}