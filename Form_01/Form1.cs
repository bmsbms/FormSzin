using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gomb1.Click += (sender, e) =>
            {
                szoveg1.ForeColor = Color.Red;

            };
            gomb1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szoveg1.Text = String.Format("Hello {0}",gomb1.Text);
            szoveg1.ForeColor = Color.Blue;
        }
    }
}
