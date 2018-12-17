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

namespace myproject
{
    /// <summary>
    /// Логика взаимодействия для AddForm.xaml
    /// </summary>
    public partial class AddForm : Window
    {
        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Function for add workwrs
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? bda = datePicker1.SelectedDate;
            DateTime bday = bda.Value;
            DateTime now = DateTime.Today;
            int age = now.Year - bday.Year;
            if (now < bday.AddYears(age)) age--;
            MainWindow.People.Add(new Person() { Name = txtName.Text, Position = txtAddress.Text, Age = age });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
