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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Nothi_Next.View;

namespace Nothi_Next
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        IFirebaseClient client;
        public MainWindow()
        {
            InitializeComponent();


            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");

            }
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret= "hUjzV5JCIo7RFbKra1aFn8brDX1UAxdVPSZPVxzH",
            BasePath= "https://nothi-next.firebaseio.com/"

        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            string userName = box.Text;
            string auto = "";
            string[] zero = { };

            if (userName.Length >4)
            {
                int length = (12 - userName.Length);
                for (int i = 1; i <= length; i++)
                {
                    auto = auto + "0";  }
                



                string newUserName = userName[0] +auto+userName[1..];
                box.Text = newUserName;
            }



        }
       

        //private void TextBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    TextBox box = (TextBox)sender;
        //    string userName = box.Text;
        //    string auto = "";
        //    string[] zero = { };

        //    if (userName != null)
        //    {
        //        int length = (12 - userName.Length);
        //        for (int i = 1; i <= length; i++)
        //        {
        //            zero.Append("0");
        //        }
        //        auto = String.Join("", zero);

        //        string newUserName = userName[0] + auto + userName[1..];
        //        box.Text = newUserName;
        //    }
        //}
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
        
     
        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show(" Username or Password Input is not valid");
                return;
            }

               


                FirebaseResponse set = client.Get(@"Users/" + userNameTextBox.Text);
            User reUser = set.ResultAs<User>(); //databaase

            User user = new User()
            {
                UserName = userNameTextBox.Text,
                Password = passwordTextBox.Password.ToString(),



            };

            if (User.IsEqual(user, reUser))
            {
                Dashboard dashboard = new Dashboard();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Owner = this;
                this.Hide();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show(" You are not registered");
            }



        }

        }
    }

