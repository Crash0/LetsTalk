using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Animation;

namespace LetsTalk.Client.AgentClient
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow
    {
        #region Storryboard for annimating the login poppup/down 

        private readonly Storyboard _loginDownStoryboard;
        private readonly Storyboard _loginUpStoryboard;

        #endregion

        public LoginWindow()
        {
            InitializeComponent();
            Loaded += LoginWindow_Loaded;

            LoginControllerGrid.Visibility = Visibility.Hidden;
            LoadingWheel.Visibility = Visibility.Hidden;

            //Bind Loging field to xaml source
            _loginDownStoryboard = FindResource("LoginPoppDown") as Storyboard;
            _loginUpStoryboard = FindResource("LoginPoppUP") as Storyboard;
            _loginDownStoryboard?.Begin();
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoginControllerGrid.Visibility = Visibility.Visible;
            _loginUpStoryboard.Begin();
        }

        private void LoginWindow_OnClosing(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Closing");
        }

        private void LoginWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
