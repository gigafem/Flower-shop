using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Core;

namespace WpfApp1
{
    public partial class ReviewsForAuthorizedUser : Window
    {
        public ReviewsForAuthorizedUser()
        {
            InitializeComponent();
        }
        private void OpenPopup_Click(object sender, RoutedEventArgs e)
        {
            WriteReviewPopup.Visibility = Visibility.Visible;
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            WriteReviewPopup.Visibility = Visibility.Collapsed;
        }

        private void SendReview_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text.Trim();
            string review = ReviewTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(review))
            {
                MessageBox.Show("You need to enter your name and review!");
                return;
            }

            MessageBox.Show("Thank you for your review!");
            Logger.Log("Left a review");

            NameBox.Text = "";
            ReviewTextBox.Text = "";

            WriteReviewPopup.Visibility = Visibility.Collapsed;
        }
        

    }
}
