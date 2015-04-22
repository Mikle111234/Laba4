using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    class MyClass
    {
        public void Fun1()
        {
            int a = 0;
            int b = 5;
            b = b + a;
        }
        public MyClass()
        {
            string s = "";
            int x = 12;

        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
