using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoveBees.Model
{
    public class UserDataProvider
    {
        public UserDataProvider()
        {
            Users = new List<User>();
            PrepareData();
        }

        private void PrepareData()
        {
            XmlDocument doc = new XmlDocument();
            if (!File.Exists("UserData.xml"))
            {
                return;
            }

            doc.Load("UserData.xml");
            XmlNode node = doc.SelectSingleNode("Users");
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name.Equals("User"))
                {
                    var user = new User { 
                        Name = child.Attributes["Name"].Value,
                        PW = child.Attributes["Password"].Value
                    };

                    Users.Add(user);
                }
            }
        }

        private static UserDataProvider _Instance;
        public static UserDataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UserDataProvider();
                }

                return _Instance;
            }
        }

        public User SelectedUser { get; set; }

        public List<User> Users { get; private set; }

        internal void AddUser(User user)
        {
            XmlDocument doc = new XmlDocument();
            if (!File.Exists("UserData.xml"))
            {
                return;
            }

            doc.Load("UserData.xml");
            XmlNode node = doc.SelectSingleNode("Users");
            XmlElement element = doc.CreateElement("User");
            XmlAttribute atr1 = doc.CreateAttribute("Name");
            atr1.Value = user.Name;
            element.Attributes.Append(atr1);
            XmlAttribute atr2 = doc.CreateAttribute("Password");
            atr2.Value = user.PW;
            element.Attributes.Append(atr2);
            node.AppendChild(element);
            doc.Save("UserData.xml");
        }
    }
}
