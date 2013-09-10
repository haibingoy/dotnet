using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            AddMyButton();
        }

        // Add a button to a form and set some of its common properties. 
        private void AddMyButton()
        {
            var panel = new Panel();
            panel.Size = new System.Drawing.Size(534, 318);
            panel.BackColor = System.Drawing.SystemColors.ControlDark;
            var listBox = new ListBox();
            listBox.Items.Add("item 1");
            listBox.Items.Add("item 2");
            listBox.Height = 200;
            listBox.Width = 200;
            listBox.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            panel.Controls.Add(listBox);
            var button = new Button();
            button.Height = 100;
            button.Width = 100;
            button.Text = "Click me.";
            button.Location = new Point(202, 202);
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel.Controls.Add(button);
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
        }
    }
}
