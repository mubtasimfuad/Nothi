using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nothi_Next.View
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    using System.Windows.Controls;

    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

            if (GetMessages().Count > 0)
            {
                ListViewMessages.ItemsSource = GetMessages();
            }
        }

        public List<Message> GetMessages()
        {
            return new List<Message>()
      {
        new Message("জশিম", "ফুয়াদ", "বদলি নোটিশ","কামাল","ঢাকা বদলি করা হইলো এই মর্মে যে উহাকে ১ মাস বেতন কর্তন করা হইবে "),
        new Message("মুহিত", "মুবতাসিম", "ছুটিনোটিশ","কামাল","ছুটি মনজুর করা হলো। সুস্থতা কামনা করা হচ্ছে  "),
        new Message("জামশেদ", "তানভীর", "নিয়োগ বিজ্ঞপ্তি","কামাল","নিয়োগ দেয়া হলো"),
        new Message("হাশেম", "নিলয়", "মালামাল পরিবহন","কামাল","বাজেট নির্ধারিত হলো"),
        new Message("জাবেদ", "ফয়সাল", "বনভোজনের নোটিশ","কামাল"," কমিটি করা হলো"),
        new Message("সায়েম", "ফুয়াদ", "বদলি নোটিশ","কামাল","চট্টগ্রামে বদলি"),
        new Message("হাসনাত", "সিরাজ", "বদলি নোটিশ","জামাল"," কুমিলায় ল্বদলি"),
        new Message("আবুল", "অয়ন", "বদলি নোটিশ","কা","ঢাকা বদলি"),
        new Message("হৃদয়", "অমি", "বদলি নোটিশ","কামাল","ঢাকা বদলি"),

      
      };
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dashboard mn = new Dashboard();
            mn.Owner = this;
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
