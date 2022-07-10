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
    public partial class Form1 : Form
    {
        Doctors oculist = new Doctors("Дарья", "Игоревна", "Муха",3.3);
        Doctors otolaryngologist = new Doctors("Павел", "Михайлович", "Жмышенко", 2.75);
        Doctors hirurg = new Doctors("Валерий", "Альбертович", "Жук", 5.6);
        Doctors therapist = new Doctors("Наталья", "Михайловна", "Мелехевец", 2.08);
        Doctors narkolog = new Doctors("Егор", "Витальевич", "Романенко", 3.2);
        Doctors psychologist = new Doctors("Лилия", "Эдуардовна", "Скепко", 4.5);
        Doctors ginecolog = new Doctors("Иван", "Натанович", "Купитм ан", 5.6);
        Doctors gematolog = new Doctors("Эдуард", "Александрович", "Карпенко", 1.7);
        Doctors laborant = new Doctors("Антон", "Александрович", "Воронков", 1.7);
        Person patient1 = new Person("Анастасия","Сергеевна","Оскерко");
        Person patient2 = new Person("Артем","Витальевич","Шеин");
        Person patient3 = new Person("Максим","Николаевич","Скепко");
        Form2 form2 = new Form2();
        Fio fio = new Fio();
        

        public Form1()
        {

            
            InitializeComponent();
            comboBox1.Items.Add("Плановый мужской");
            comboBox1.Items.Add("Плановый женский");
            comboBox2.Items.Add(patient3.Info());
            comboBox2.Items.Add(patient2.Info());
            comboBox2.Items.Add(patient1.Info());
            textBox1.ReadOnly = true;
            textBox1.Multiline = true;
            textBox1.Text = "";
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.Show();
            comboBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Терапевт:\n{therapist.InfoDoctor()}\n\nОкулист:\n{oculist.InfoDoctor()}\n\nОтоларинголог:\n{otolaryngologist.InfoDoctor()}\n\nХирург:\n{hirurg.InfoDoctor()}\n\nНарколог:\n{narkolog.InfoDoctor()}\n\nПсихолог:\n{psychologist.InfoDoctor()}\n\nГинеколог:\n{ginecolog.InfoDoctor()}\n\nВрач-гематолог(анализ крови):\n{gematolog.InfoDoctor()}\n\nЛаборант(анализ мочи):\n{laborant.InfoDoctor()}", "Список врачей");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Плановый мужской")
            {
                form2.checkBox1.Checked = true;
                form2.checkBox2.Checked = true;
                form2.checkBox3.Checked = true;
                form2.checkBox8.Checked = true;
                form2.checkBox9.Checked = true;
            }
            if (comboBox1.Text == "Плановый женский")
            {
                form2.checkBox1.Checked = true;
                form2.checkBox2.Checked = true;
                form2.checkBox3.Checked = true;
                form2.checkBox8.Checked = true;
                form2.checkBox9.Checked = true;
                form2.checkBox7.Checked = true;
            }
            if(comboBox2.Text=="")
            {
                MessageBox.Show("Выберите пациента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
            if (form2.checkBox1.Checked == false && form2.checkBox2.Checked == false && form2.checkBox3.Checked == false && form2.checkBox4.Checked == false && form2.checkBox5.Checked == false && form2.checkBox6.Checked == false && form2.checkBox7.Checked == false && form2.checkBox8.Checked == false && form2.checkBox9.Checked == false)
            {
                MessageBox.Show("Не выбран ни один врач!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    zakaz Zakaz = new zakaz { terapevt = form2.checkBox1.Checked, oculist= form2.checkBox2.Checked, hirurg= form2.checkBox3.Checked, otolaringolog= form2.checkBox4.Checked, narkolog= form2.checkBox5.Checked, psycologist= form2.checkBox6.Checked, ginecolog= form2.checkBox7.Checked, analizKrovi= form2.checkBox8.Checked, analizMochi= form2.checkBox9.Checked };
                    textBox1.Text = textBox1.Text + Zakaz.TextBoxInfo(comboBox2.Text);
            }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(fio.ShowDialog()==DialogResult.OK)
            {
                comboBox2.Items.Add(fio.fio);
                comboBox2.Text = fio.fio;
                fio.textBox3.Text = "";
                fio.textBox2.Text = "";
                fio.textBox1.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
