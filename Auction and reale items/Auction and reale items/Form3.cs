using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Auction_and_reale_items
{
    public partial class Form3 : Form
    {
        public static string currentUser = "";

        public static List<double> highestBids = new List<double>();
        public static List<double> userBalances = new List<double>();
        public static List<string> highestBidders = new List<string>();
        public static List<string> salesHistory = new List<string>();
        public static List<string> itemNames = new List<string>();
        public static List<double> itemPrices = new List<double>();
        public static List<string> itemTypes = new List<string>();
        public static List<string> itemCategories = new List<string>();
        public static List<bool> auctionEnded = new List<bool>();
        public static List<double> originalPrices = new List<double>();
        public static double totalOriginalCost = 0;
        public static double totalExpectedProfit = 0;
        public static List<double> markups = new List<double>();

        public static List<double> profits = new List<double>();

        private string username;

        public static double totalProfitEarned = 0;
        public static double totalOriginalSold = 0;

        public static bool auctionRunning = false;

        public static int auctionTime = 60;

        public static int auctionItemIndex = -1;

        public static Dictionary<string, double> userWallets =
    new Dictionary<string, double>();

        public Form3()
        {
            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Current User = " + currentUser);



            bool isAdmin = currentUser == "admin";

            cmbCategory.Visible = isAdmin;
            cmbType.Visible = isAdmin;
            txtStartBid.Visible = isAdmin;
            btnStartAuction.Visible = isAdmin;
            lblOverallProfit.Visible = isAdmin;
            lstHistory.Visible = isAdmin;

            lblWallet.Visible = !isAdmin;
            txtCardNumber.Visible = !isAdmin;
            txtCardPassword.Visible = !isAdmin;
            btnAddFunds.Visible = !isAdmin;
            lstItems.Visible = true;
            txtBid.Visible = !isAdmin;
            btnBuy.Visible = !isAdmin;
            btnBid.Visible = !isAdmin;
            btnBid.Enabled = auctionRunning;


            timer1.Interval = 1000;
            if (auctionRunning)
            {
                lblTimer.Text = auctionTime.ToString();

                btnBid.Enabled = true;

                timer1.Start();
            }
            else
            {
                lblTimer.Text = "Not Started";

                btnBid.Enabled = false;
            }

            lblTimer.Text = auctionTime.ToString();

            RefreshList();
            if (userWallets.ContainsKey(currentUser))
            {
                lblWallet.Text = "Wallet: ₱" + userWallets[currentUser];
            }
            UpdateOverallProfit();
            lstHistory.Items.Clear();

            foreach (string item in salesHistory)
            {
                lstHistory.Items.Add(item);
            }


            cmbType.Items.Add("Buy");
            cmbType.Items.Add("Bid");
            cmbType.SelectedIndex = 0;

            cmbCategory.Items.Add("Tech");
            cmbCategory.Items.Add("Toys");
            cmbCategory.Items.Add("Sports");
            cmbCategory.Items.Add("Others");

            cmbCategory.SelectedIndex = 0;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();

                login.Show();

                this.Close();
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {


            double originalPrice =
Convert.ToDouble(txtOriginalPrice.Text);

            double markup =
            Convert.ToDouble(txtMarkup.Text);

            double sellingPrice =
            originalPrice + markup;

            if (cmbType.Text == "Bid")
            {
                sellingPrice =
                Convert.ToDouble(txtStartBid.Text);

                highestBids.Add(sellingPrice);

                highestBidders.Add("No Bidder");
            }
            else
            {
                highestBids.Add(0);
                highestBidders.Add("");
            }

            double percentage =
            (markup / originalPrice) * 100;

            lblOverallProfit.Text =
            percentage.ToString("F2") + "%";

            itemNames.Add(txtName.Text);

            itemPrices.Add(sellingPrice);

            itemTypes.Add(cmbType.Text);

            itemCategories.Add(cmbCategory.Text);

            originalPrices.Add(originalPrice);

            markups.Add(markup);

            profits.Add(markup);
            totalOriginalCost += originalPrice;
            totalExpectedProfit += markup;

            UpdateOverallProfit();
            RefreshList();
        }


        private void RefreshList()
        {
            lstItems.Items.Clear();

            for (int i = 0; i < itemNames.Count; i++)
            {
                lstItems.Items.Add(

                itemNames[i] + " | " +

                itemCategories[i] + " | " +

                itemTypes[i] + " | ₱" +

                itemPrices[i]

                );
            }
        }
        private void RefreshHistory()
        {
            lstHistory.Items.Clear();

            foreach (string item in salesHistory)
            {
                lstHistory.Items.Add(item);
            }



        }

        private void UpdateOverallProfit()
        {
            if (totalOriginalSold > 0)
            {
                double percent =
                    (totalProfitEarned / totalOriginalSold) * 100;

                lblOverallProfit.Text =
                    "Overall Profit: " +
                    percent.ToString("F2") + "%";
            }
            else
            {
                lblOverallProfit.Text =
                    "Overall Profit: 0%";
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int index = lstItems.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            if (itemTypes[index] == "Bid")
            {
                MessageBox.Show("This item is for bidding only!");
                return;
            }



            if (index >= 0)
            {
                if (userWallets[currentUser] >= itemPrices[index])
                {
                    userWallets[currentUser] -= itemPrices[index];

                    lblWallet.Text =
                    "Wallet: ₱" + userWallets[currentUser];

                    MessageBox.Show("Adding to history");
                    salesHistory.Add(
    itemNames[index] +
    " | Original: " +
    originalPrices[index] +
    " | Markup: " +
    markups[index] +
    " | Profit: " +
    profits[index]

);
                    totalOriginalSold += originalPrices[index];
                    totalProfitEarned += profits[index];

                    UpdateOverallProfit();

                    UpdateOverallProfit();
                    if (auctionItemIndex > index)
                    {
                        auctionItemIndex--;
                    }
                    else if (auctionItemIndex == index)
                    {
                        auctionRunning = false;
                        auctionItemIndex = -1;
                        timer1.Stop();
                    }
                    itemNames.RemoveAt(index);
                    itemPrices.RemoveAt(index);
                    itemTypes.RemoveAt(index);
                    itemCategories.RemoveAt(index);

                    originalPrices.RemoveAt(index);
                    markups.RemoveAt(index);
                    profits.RemoveAt(index);

                    highestBids.RemoveAt(index);
                    highestBidders.RemoveAt(index);
                    RefreshList();
                }
            }
        }

        private void btnBid_Click(object sender, EventArgs e)
        {

            int index = auctionItemIndex;

            if (index < 0 || index >= itemTypes.Count)
            {
                MessageBox.Show("No active auction.");
                return;
            }

            if (itemTypes[index] != "Bid")
            {
                MessageBox.Show("This item is not for auction.");
                return;
            }



            if (index < 0 || //test
    index >= itemNames.Count ||
    index >= highestBids.Count ||
    index >= highestBidders.Count)
            {
                MessageBox.Show("Lists are out of sync!");
                return;
            }


            if (index >= 0 &&
      index < itemNames.Count &&
      index < highestBids.Count)
            {
                if (itemTypes[index] == "Bid")
                {
                    double bidAmount;

                    if (!double.TryParse(txtBid.Text, out bidAmount))
                    {
                        MessageBox.Show("Please enter a valid bid amount.");
                        return;
                    }


                    if (bidAmount > highestBids[index])
                    {
                        highestBids[index] = bidAmount;

                        highestBidders[index] =
                        currentUser;

                        itemPrices[index] =
                        bidAmount;

                        RefreshList();

                        MessageBox.Show(
                        "Bid Successful!"

                        );
                    }
                    else
                    {
                        MessageBox.Show(
                        "Bid must be higher!"
                        );
                    }
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!auctionRunning)
                return;

            auctionTime--;

            lblTimer.Text = auctionTime.ToString();

            if (auctionTime <= 0)
            {
                auctionRunning = false;

                timer1.Stop();

                btnBid.Enabled = false;

                int i = auctionItemIndex;



                if (i < 0 ||
                    i >= itemNames.Count ||
                    i >= itemPrices.Count ||
                    i >= itemTypes.Count ||
                    i >= highestBids.Count ||
                    i >= highestBidders.Count)
                {
                    MessageBox.Show("Auction data invalid.");
                    timer1.Stop();
                    auctionRunning = false;
                    return;
                }

                if (i >= 0)
                {
                    double finalPrice = highestBids[i];


                    if (highestBidders[i] != "No Bidder")
                    {
                        string winner = highestBidders[i];

                        if (userWallets.ContainsKey(winner))
                        {


                            if (userWallets[winner] >= finalPrice)
                            {
                                userWallets[winner] -= finalPrice;

                                if (currentUser == winner)
                                {
                                    lblWallet.Text =
                                    "Wallet: ₱" + userWallets[winner];
                                }

                            }
                            else
                            {
                                MessageBox.Show(
                                    winner + " does not have enough wallet balance!"
                                );
                            }
                        }
                    }
                    double profit =
                        finalPrice - originalPrices[i];

                    totalOriginalSold += originalPrices[i];
                    totalProfitEarned += profit;

                    UpdateOverallProfit();

                    salesHistory.Add(
                        itemNames[i] +
                        " | Winner: " +
                        highestBidders[i] +
                        " | Original: " +
                        originalPrices[i] +
                        " | Sold: " +
                        finalPrice +
                        " | Profit: " +
                        profit
                    );

                    UpdateOverallProfit();

                    itemNames.RemoveAt(i);
                    itemPrices.RemoveAt(i);
                    itemTypes.RemoveAt(i);
                    itemCategories.RemoveAt(i);

                    originalPrices.RemoveAt(i);
                    markups.RemoveAt(i);
                    profits.RemoveAt(i);

                    highestBids.RemoveAt(i);
                    highestBidders.RemoveAt(i);

                    auctionItemIndex = -1;

                    RefreshList();
                    RefreshHistory();
                }



                MessageBox.Show("Auction Ended!");
                MessageBox.Show(
    "Item Count = " + itemNames.Count +
    "\nHighest Bid Count = " + highestBids.Count +
    "\nAuction Index = " + auctionItemIndex
);
            }
        }

      

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "123" &&
     txtCardPassword.Text == "123")
            {
                userWallets[currentUser] += 1000;

                lblWallet.Text =
                "Wallet: ₱" + userWallets[currentUser];

                MessageBox.Show("₱1000 Added!");
            }
            else
            {
                MessageBox.Show("Invalid Card");
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartAuction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auction Started");

            int index = lstItems.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select a bid item first.");
                return;
            }

            if (itemTypes[index] != "Bid")
            {
                MessageBox.Show("Selected item is not a bid item.");
                return;
            }

            if (index >= highestBids.Count ||
    index >= highestBidders.Count)
            {
                MessageBox.Show("Auction lists are not synchronized.");
                return;
            }

            auctionItemIndex = index;

            auctionRunning = true;

            auctionTime = 60;

            lblTimer.Text = auctionTime.ToString();

            btnBid.Enabled = true;

            timer1.Start();

            MessageBox.Show("Auction Started");
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }

        private void txtStartBid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
