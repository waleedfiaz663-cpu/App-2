using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Waleed", Marks1 = 77, Marks2 = 88, Marks3 = 99 },
                new Student { Id = 2, Name = "Ahsan",  Marks1 = 65, Marks2 = 72, Marks3 = 80 },
                new Student { Id = 3, Name = "Hamza",   Marks1 = 85, Marks2 = 90, Marks3 = 94 },
                new Student { Id = 4, Name = "Sahab",  Marks1 = 50, Marks2 = 60, Marks3 = 58 },
                new Student { Id = 5, Name = "Romaisa", Marks1 = 91, Marks2 = 89, Marks3 = 95 }
            };

            
            myListView.ItemsSource = students;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}