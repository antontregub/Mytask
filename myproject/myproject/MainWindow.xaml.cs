using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace myproject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Person> People { get; set; }
        ObservableCollection<Person> peopleSort ;
        public MainWindow()
        {
            InitializeComponent();

            People = new ObservableCollection<Person>
            {
                new Person { Name="Toxa", Position="Junior" },
                new Person { Name="Oleh", Position="Midl" },
                new Person { Name="Bohdan", Position="Admin" },
            };
            Sort();
        }

        /// <summary>
        /// Open form for add workers
        /// </summary>
        private void AddForm(object sender, RoutedEventArgs e)
        {
            AddForm addform = new AddForm();
            addform.Show();
        }

        /// <summary>
        /// Sort workers for name
        /// </summary>
        public void Sort()
        {
            peopleSort = new ObservableCollection<Person>(People.OrderBy(Person => Person.Name));
            workers.ItemsSource = peopleSort;
        }

        /// <summary>
        /// Delete worker
        /// </summary>
        private void Del(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is Person)
            {
                Person deleteme = (Person)cmd.DataContext;
                People.Remove(deleteme);
                Sort();
            }
        }

        /// <summary>
        /// Refresh list after add
        /// </summary>
        private void Refresh(object sender, RoutedEventArgs e)
        {
            Sort();
        }
    }
    public class Person
    {
        public string Name { get; set; } // Name
        public string Position { get; set; } // Position              
        public int Age { get; set; } //Age
        public string Datastart { get; set; }
        public string Datefinish { get; set; }
    }
}
