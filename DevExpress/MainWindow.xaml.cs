
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DXGridSample
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The persons.
        /// </summary>
        private readonly ObservableCollection<Person> Persons;

        public MainWindow()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>();

            for (int i = 0; i < 10; i++)
            {
                Persons.Add(new Person { Id = i, Name = "Name" + i, Bool = i % 2 == 0 });

                if (i%2 == 0)
                {
                    Persons[i].Profession = "IT, Teacher";
                }
                else
                {
                    Persons[i].Profession = "Teacher";
                }
            }

            grid.ItemsSource = Persons;
        }
    }

    /// <summary>
    /// The person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }
  
        public bool Bool { get; set; }

        public string Profession { get; set; }
    }
}