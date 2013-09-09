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
            var winformButton = new Button();
            winformButton.Width = 200;
            winformButton.Height = 30;
            winformButton.Text = "OK";
            this.Controls.Add(winformButton);
        }
    }
}
