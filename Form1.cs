using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true; //ЗАХИСТ ВІД ДУРНЯ
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox1.Text); //зміна типу даних
            string S = Convert.ToString((L*L) / (4 * Math.PI))+" m2"; //формула площі круга
            ResLbl.Text = S; //вивід результату на екран форми
        }

       
    }
}
