using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CizimDersi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cizbtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();//this deyimi formu işaret eder.
         
            g.DrawString("MEHMET EMİN KURT", new Font("Arial", 30), Brushes.Red, 200, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
