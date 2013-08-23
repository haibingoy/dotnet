
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DXGridSample
{
    public partial class MainWindow : Window
    {
        private readonly List<Person> _originalPersons;

        public ObservableCollection<Person> Persons { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            _originalPersons = new List<Person>();

            Persons = new ObservableCollection<Person>();

            for (int i = 0; i < 10; i++)
            {
                _originalPersons.Add(new Person { Id = i, Name = "Name" + i, Bool = i % 2 == 0 });

                if (i%2 == 0)
                {
                    _originalPersons[i].Profession = "IT, Teacher";
                }
                else
                {
                    _originalPersons[i].Profession = "Teacher";
                }
            }

            foreach (var originalPerson in _originalPersons)
            {
                Persons.Add(originalPerson);
            }
        }

        private void Grid_OnStartGrouping(object sender, RoutedEventArgs e)
        {
            if (grid.Columns["Profession"].IsGrouped)
            {
                Persons.Clear();
                foreach (var originalPerson in _originalPersons)
                {
                    foreach (var item in originalPerson.Profession.Split(','))
                    {
                        var person = originalPerson.Copy();
                        person.Profession = item.Trim();
                        Persons.Add(person);
                        Debug.WriteLine(person.Id + " " + person.Profession);
                    }
                }
            }
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

        public Person Copy()
        {
          return new Person() { Id = this.Id, Bool = this.Bool, Name = this.Name, Profession = this.Profession };
        }
    }
}