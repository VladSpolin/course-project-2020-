using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_ООП
{
    class zakaz
    {
        public bool terapevt { get; set; }
        public bool oculist { get; set; }
        public bool hirurg { get; set; }
        public bool otolaringolog { get; set; }
        public bool narkolog { get; set; }
        public bool psycologist { get; set; }
        public bool ginecolog { get; set; }
        public bool analizKrovi { get; set; }
        public bool analizMochi { get; set; }
        Doctors Oculist = new Doctors("Дарья", "Игоревна", "Муха", 3.3);
        Doctors Otolaryngologist = new Doctors("Павел", "Михайлович", "Жмышенко", 2.75);
        Doctors Hirurg = new Doctors("Валерий", "Альбертович", "Жук", 5.6);
        Doctors Therapist = new Doctors("Наталья", "Михайловна", "Мелехевец", 2.08);
        Doctors Narkolog = new Doctors("Егор", "Витальевич", "Романенко", 3.2);
        Doctors Psychologist = new Doctors("Лилия", "Эдуардовна", "Скепко", 4.5);
        Doctors Ginecolog = new Doctors("Иван", "Натанович", "Купитман", 5.6);
        Doctors Gematolog = new Doctors("Эдуард", "Александрович", "Карпенко", 1.7);
        Doctors Laborant = new Doctors("Антон", "Александрович", "Воронков", 1.7);
        double totalprice = 0;
        public string TextBoxInfo(string patient)
        {
            string textinside = $"Пациент - {patient}" + Environment.NewLine + "Пройти необходимо:";
            if (terapevt == true)
            {
                textinside = textinside + Environment.NewLine + $"Терапевт - {Therapist.Info()}";
                totalprice = totalprice + Therapist.GetPrice();
            }
            if (oculist == true)
            {
                textinside = textinside + Environment.NewLine + $"Окулист - {Oculist.Info()}";
                totalprice = totalprice + Oculist.GetPrice();
            }
            if (hirurg == true)
            {
                textinside = textinside + Environment.NewLine + $"Хирург - {Hirurg.Info()}";
                totalprice = totalprice + Hirurg.GetPrice();
            }
            if (otolaringolog == true)
            {
                textinside = textinside + Environment.NewLine + $"Отоларинголог - {Otolaryngologist.Info()}";
                totalprice = totalprice + Otolaryngologist.GetPrice();
            }
            if (narkolog == true)
            {
                textinside = textinside + Environment.NewLine + $"Нарколог - {Narkolog.Info()}";
                totalprice = totalprice + Narkolog.GetPrice();
            }
            if (psycologist == true)
            {
                textinside = textinside + Environment.NewLine + $"Психолог - {Psychologist.Info()}";
                totalprice = totalprice + Psychologist.GetPrice();
            }
            if (ginecolog == true)
            {
                textinside = textinside + Environment.NewLine + $"Гинеколог - {Ginecolog.Info()}";
                totalprice = totalprice + Ginecolog.GetPrice();
            }
            if (analizKrovi == true)
            {
                textinside = textinside + Environment.NewLine + $"Анализ крови - {Gematolog.Info()}";
                totalprice = totalprice + Gematolog.GetPrice();
            }
            if (analizMochi == true)
            {
                textinside = textinside + Environment.NewLine + $"Анализ мочи - {Laborant.Info()}";
                totalprice = totalprice + Laborant.GetPrice();
            }
            textinside = textinside + Environment.NewLine + $"Стоимость медосмотра - {totalprice}р"+Environment.NewLine+Environment.NewLine;
            return textinside;
        }
    }
    
}
