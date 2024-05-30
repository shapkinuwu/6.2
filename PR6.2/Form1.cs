using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хорошо, иследователь, вы сделали свой выбор");
            Close();
        }

        private void Положительный_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствуем вас в мире ужаса и мерзости, иследователь");
            Hide();
            Form2 newForm = new Form2();
            newForm.Show();
            
        }
    }
}
