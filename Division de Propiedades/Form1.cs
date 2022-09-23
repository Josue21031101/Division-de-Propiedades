using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_de_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Division s = new Division();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.Dividir().ToString();

        }
    }
}
