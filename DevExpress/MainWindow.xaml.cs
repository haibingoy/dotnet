
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Net.Mime;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using DevExpress.Data.Browsing;
using Image = System.Drawing.Image;

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

            for (int i = 0; i < 400; i++)
            {
                _originalPersons.Add(new Person
                    {
                        Id = i, 
                        Name = "Name" + i, 
                        Bool = i % 2 == 0,
                        Head = Image.FromFile("fdtCONTAINER.ico"),
                        Border = Image.FromFile("fdtCONTAINER.ico"),
                        DeviceName = "DeviceNameDeviceName",
                        DeviceVersion = "DeviceNameDeviceName",
                        DtmDate = "DeviceNameDeviceName",
                        DtmName = "DeviceNameDeviceName",
                        DeviceVendor = "DeviceNameDeviceName",
                        DtmVersion = "DeviceNameDeviceName",
                        FdtVersion = "DeviceNameDeviceName",
                        Group = "DeviceNameDeviceName",
                        Protocol = "DeviceNameDeviceName"
                    });

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

        private void MainWindow_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            FieldInfo mostRecentInputDeviceField = typeof(InputManager).GetMember("_mostRecentInputDevice", MemberTypes.Field, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)[0] as FieldInfo;

            mostRecentInputDeviceField.SetValue(InputManager.Current, InputManager.Current.PrimaryKeyboardDevice);
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

        public Image Head { get; set; }

        public Image Border { get; set; }

        public string Name { get; set; }
  
        public bool Bool { get; set; }

        public string Profession { get; set; }

        public string DeviceName { get; set; }

        public string DeviceVendor { get; set; }

        public string DeviceVersion { get; set; }

        public string DtmDate { get; set; }

        public string DtmName { get; set; }

        public string DtmVendor { get; set; }

        public string DtmVersion { get; set; }

        public string FdtVersion { get; set; }

        public string Group { get; set; }

        public string Protocol { get; set; }

        public Person Copy()
        {
          return new Person() { Id = this.Id, Bool = this.Bool, Name = this.Name, Profession = this.Profession };
        }
    }
}