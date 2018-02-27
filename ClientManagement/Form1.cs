using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String test = "Hello World";
            textBox1.Text = test.ToUpper();
        }
    }
}
