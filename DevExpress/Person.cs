using System;
using System.Drawing;

namespace DXGridSample
{
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

        public Profession Profession { get; set; }

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

    public class Profession : IComparable
    {
        public int age { get; set; }

        public string Occupation { get; set; }

        public override string ToString()
        {
            return Occupation;
        }

        public int CompareTo(object obj)
        {
            var target = obj as Profession;
            if (target == null)
            {
                return -1;
            }
            else
            {
                return Occupation.CompareTo(target.Occupation);
            }
        }
    }
}