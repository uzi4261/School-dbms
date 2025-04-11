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

namespace littlescholarsdbms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void ManageUsers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to User Management");
        }

        private void Timetable_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Timetable");
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Reports");
        }

        private void Attendance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Attendance");
        }

        private void Homework_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Homework");
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Result");
        }

        private void ExamRoutine_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Exam Routine");
        }

        private void Solution_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Solution");
        }

        private void Notice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigate to Notices & Events");
        }
    }
}
