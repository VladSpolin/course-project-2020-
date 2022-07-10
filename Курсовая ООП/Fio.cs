using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ООП
{
    public partial class Fio : Form
    {
        public string fio;
        public Fio()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!="")
            {
                fio = $"{textBox2.Text} {textBox3.Text} {textBox1.Text}";
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else { MessageBox.Show("Введите все данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
