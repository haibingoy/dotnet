using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;

namespace DXGridSample
{
    public class PersonDataProvider
    {
        private static PersonDataProvider _instance;

        public event EventHandler PrepareDataFinished = delegate { };

        public List<Person> People { get; set; }

        public bool IsDataReady { get; set; }

        public PersonDataProvider()
        {
            People = new List<Person>();
        }

        public static PersonDataProvider Instance
        {
            get 
            { 
                _instance = _instance ?? new PersonDataProvider();
                return _instance;
            }
        }

        /// <summary>
        /// The prepare data.
        /// </summary>
        public void PrepareData()
        {
            for (int i = 0; i < 400; i++)
            {
                People.Add(new Person
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

                if (i % 2 == 0)
                {
                    People[i].Profession = new Profession {age = 32, Occupation = "IT, Teacher"};
                }
                else
                {
                    People[i].Profession = new Profession { age = 58, Occupation = "Teacher" };
                }
            }

            IsDataReady = true;
            Application.Current.Dispatcher.Invoke((Action)(() => PrepareDataFinished(this, new EventArgs())));
        }
    }
}
