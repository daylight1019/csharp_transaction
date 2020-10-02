using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        SolidColorBrush activeBrush;
        SolidColorBrush inactiveBrush;

        public MainWindow()
        {
            InitializeComponent();

            activeBrush = new SolidColorBrush(Color.FromArgb(221, 255, 255, 255));
            inactiveBrush = new SolidColorBrush(Color.FromArgb(102, 255, 255, 255));

            List<User> users = new List<User>();
            users.Add(new User() { 
                Date = "01/09/2020", //new DateTime(2020,9,1), 
                Type= "Expense", 
                FromAccount = "Chase",
                ToAccount = "NA",
                Group = "Home",
                Category = "Food",
                PayeePayer = "McDonald",
                Amount = "$5",
                FromBalance = "$595",
                ToBalance = "NA",
                Receipt = "",
            });
            users.Add(new User()
            {
                Date = "01/09/2020", //new DateTime(2020, 9, 2),
                Type = "Expense",
                FromAccount = "Chase",
                ToAccount = "NA",
                Group = "Shopify Store",
                Category = "Server",
                PayeePayer = "Amazon",
                Amount = "$50",
                FromBalance = "$545",
                ToBalance = "NA",
                Receipt = "",
            });
            users.Add(new User()
            {
                Date = "01/09/2020", //new DateTime(2020, 9, 3),
                Type = "Expense",
                FromAccount = "Chase",
                ToAccount = "USB",
                Group = "NA",
                Category = "NA",
                PayeePayer = "NA",
                Amount = "$100",
                FromBalance = "$445",
                ToBalance = "100",
                Receipt = "",
            });
            dgTransaction.ItemsSource = users;

            List<Account> accounts = new List<Account>();
            accounts.Add(new Account()
            {
                Name = "Chase Bank",
                Balance = "$2000",
                CreatedDate = "01/09/2020" //new DateTime(2020,9,1), 
            });
            accounts.Add(new Account()
            {
                Name = "US Bank",
                Balance = "$100",
                CreatedDate = "05/09/2020" //new DateTime(2020,9,1), 
            });
            accounts.Add(new Account()
            {
                Name = "Great Bank",
                Balance = "$5000",
                CreatedDate = "20/09/2020" //new DateTime(2020,9,1), 
            });
            dgAccounts.ItemsSource = accounts;

            List<Summary> incomes = new List<Summary>();
            incomes.Add(new Summary()
            {
                Name = "Category1",
                Amount = "$1000",
            });
            incomes.Add(new Summary()
            {
                Name = "Category2",
                Amount = "$500",
            });
            dgIncome.ItemsSource = incomes;

            List<Summary> expenses = new List<Summary>();
            expenses.Add(new Summary()
            {
                Name = "Category1",
                Amount = "$100",
            });
            expenses.Add(new Summary()
            {
                Name = "Category2",
                Amount = "$50",
            });
            dgExpense.ItemsSource = expenses;

            AccountGrid.Visibility = Visibility.Hidden;
            SummaryGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            AddAccountCard.Visibility = Visibility.Hidden;
            MaskRectangle.Visibility = Visibility.Hidden;
        }

        private void NewTransaction_Click(object sender, RoutedEventArgs e)
        {
            TransactionWindow transactionWindow = new TransactionWindow();
            transactionWindow.ShowDialog();
        }

        private void TransactionTab_Click(object sender, RoutedEventArgs e)
        {
            TransactionIcon.Foreground = activeBrush; TransactionLabel.Foreground = activeBrush;
            AccountIcon.Foreground = inactiveBrush; AccountLabel.Foreground = inactiveBrush;
            SummaryIcon.Foreground = inactiveBrush; SummaryLabel.Foreground = inactiveBrush;
            TransferIcon.Foreground = inactiveBrush; TransferLabel.Foreground = inactiveBrush;
            SettingsIcon.Foreground = inactiveBrush; SettingsLabel.Foreground = inactiveBrush;

            TransactionGrid.Visibility = Visibility.Visible;
            AccountGrid.Visibility = Visibility.Hidden;
            SummaryGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
        }

        private void AccountTab_Click(object sender, RoutedEventArgs e)
        {
            TransactionIcon.Foreground = inactiveBrush; TransactionLabel.Foreground = inactiveBrush;
            AccountIcon.Foreground = activeBrush; AccountLabel.Foreground = activeBrush;
            SummaryIcon.Foreground = inactiveBrush; SummaryLabel.Foreground = inactiveBrush;
            TransferIcon.Foreground = inactiveBrush; TransferLabel.Foreground = inactiveBrush;
            SettingsIcon.Foreground = inactiveBrush; SettingsLabel.Foreground = inactiveBrush;

            AccountGrid.Margin = TransactionGrid.Margin;
            TransactionGrid.Visibility = Visibility.Hidden;
            AccountGrid.Visibility = Visibility.Visible;
            SummaryGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
        }

        private void SummaryTab_Click(object sender, RoutedEventArgs e)
        {
            TransactionIcon.Foreground = inactiveBrush; TransactionLabel.Foreground = inactiveBrush;
            AccountIcon.Foreground = inactiveBrush; AccountLabel.Foreground = inactiveBrush;
            SummaryIcon.Foreground = activeBrush; SummaryLabel.Foreground = activeBrush;
            TransferIcon.Foreground = inactiveBrush; TransferLabel.Foreground = inactiveBrush;
            SettingsIcon.Foreground = inactiveBrush; SettingsLabel.Foreground = inactiveBrush;

            SummaryGrid.Margin = TransactionGrid.Margin;
            TransactionGrid.Visibility = Visibility.Hidden;
            AccountGrid.Visibility = Visibility.Hidden;
            SummaryGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
        }

        private void TransferTab_Click(object sender, RoutedEventArgs e)
        {
            TransactionIcon.Foreground = inactiveBrush; TransactionLabel.Foreground = inactiveBrush;
            AccountIcon.Foreground = inactiveBrush; AccountLabel.Foreground = inactiveBrush;
            SummaryIcon.Foreground = inactiveBrush; SummaryLabel.Foreground = inactiveBrush;
            TransferIcon.Foreground = activeBrush; TransferLabel.Foreground = activeBrush;
            SettingsIcon.Foreground = inactiveBrush; SettingsLabel.Foreground = inactiveBrush;
        }

        private void SettingsTab_Click(object sender, RoutedEventArgs e)
        {
            TransactionIcon.Foreground = inactiveBrush; TransactionLabel.Foreground = inactiveBrush;
            AccountIcon.Foreground = inactiveBrush; AccountLabel.Foreground = inactiveBrush;
            SummaryIcon.Foreground = inactiveBrush; SummaryLabel.Foreground = inactiveBrush;
            TransferIcon.Foreground = inactiveBrush; TransferLabel.Foreground = inactiveBrush;
            SettingsIcon.Foreground = activeBrush; SettingsLabel.Foreground = activeBrush;

            SettingsGrid.Margin = TransactionGrid.Margin;
            TransactionGrid.Visibility = Visibility.Hidden;
            AccountGrid.Visibility = Visibility.Hidden;
            SummaryGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Visible;
        }

        private void NewAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccountCard.Visibility = Visibility.Visible;
            MaskRectangle.Visibility = Visibility.Visible;
            AccountNameTextBox.Text = "";
        }

        private void OnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccountCard.Visibility = Visibility.Hidden;
            MaskRectangle.Visibility = Visibility.Hidden;
            DateTime today = DateTime.Today;
            Account account = new Account() {
                Name = AccountNameTextBox.Text,
                Balance = "$0",
                CreatedDate = today.Day + "/" + today.Month + "/" + today.Year
                };
            var itemsList = (IList<Account>)dgAccounts.ItemsSource;
            itemsList.Add(account);
            dgAccounts.Items.Refresh();
        }

        private void OnCancelAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccountCard.Visibility = Visibility.Hidden;
            MaskRectangle.Visibility = Visibility.Hidden;
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ReceiptLocationSet_Click(object sender, RoutedEventArgs e)
        {
            /*using (var fbd = new FolderBrowserDialog())
            {
                *//*DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }*//*
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.RelativeOrAbsolute));
            }
        }

        private void GroupRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (TransferGrid != null)
            {
                TransferGrid.Visibility = Visibility.Hidden;
            }
        }

        private void AccountRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (TransferGrid != null)
            {
                TransferGrid.Visibility = Visibility.Visible;
            }
        }
    }

    public class User
    {
        public string Date { get; set; }

        public string Type { get; set; }

        public string FromAccount { get; set; }

        public string ToAccount{ get; set; }

        public string Group { get; set; }

        public string Category { get; set; }

        public string PayeePayer{ get; set; }

        public string Amount { get; set; }

        public string FromBalance { get; set; }

        public string ToBalance { get; set; }

        public string Receipt { get; set; }
    }

    public class Account
    {
        public string Name { get; set; }

        public string Balance { get; set; }

        public string CreatedDate { get; set; }
    }

    public class Summary
    {
        public string Name{ get; set; }

        public string Amount { get; set; }

    }
}
