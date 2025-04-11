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
using System.Windows.Threading;

namespace littlescholarsdbms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer loadingTimer;

        public MainWindow()
        {
            InitializeComponent();
            StartLoadingSequence();
        }

        private void StartLoadingSequence()
        {
            loadingTimer = new DispatcherTimer();
            loadingTimer.Interval = TimeSpan.FromSeconds(3); // Delay for 3 seconds
            loadingTimer.Tick += LoadingTimer_Tick;
            loadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Stop();

            // Navigate to LoginPage
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            // Close the loading screen
            this.Close();
        }
    }
}
