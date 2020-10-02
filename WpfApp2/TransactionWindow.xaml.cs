using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Fluent.RibbonWindow
    {
        public TransactionWindow()
        {
            InitializeComponent();
        }

        private void SaveTransaction_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CloseTransaction_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ReceiptBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.RelativeOrAbsolute));
                ReceiptImageView.Source = image;
            }
        }
    }
}
