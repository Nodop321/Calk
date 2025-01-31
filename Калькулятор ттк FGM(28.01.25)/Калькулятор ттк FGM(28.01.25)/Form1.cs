using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace Калькулятор_ттк_FGM_28._01._25_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Damage - урон оружия
        //ВВ - Бронебойность оружия
        //Speed - скорострельность оружия в минуту
        //Armor - % Пулестойкости брони
        //Result - ПУ брони - бронебойнсть гана = какой % ПУ останется по итогу у противника
        //SpeedBullet - скорострельность в секунду
        //x - множитель урона в голову
        //minB - интервал выстрелов пуль
        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo ruCulture = new CultureInfo("ru-RU");
            double Damage = Convert.ToDouble(textBox1.Text);
            double BB = Convert.ToDouble(textBox2.Text);
            double Speed = Convert.ToDouble(textBox3.Text);
            double Armor = Convert.ToDouble(textBox4.Text);

            double Result;
            if (BB > Armor)
            {
                Result = BB - Armor;
            }
            else
            {
                Result = Armor - BB;
            }

            double procent = Damage * (Result / 100);
            Damage -= procent;

            double SpeedBullet = Speed / 60;
            label11.Text = "Нанесенный DPS: " + (Damage * SpeedBullet).ToString();
            label7.Text = "Нанесенный DPS: " + ((Damage * 1.3) * SpeedBullet).ToString();

            double minB = 100 / SpeedBullet;
            double copy = minB;
            double copy1 = copy;
            double HP = 100;
            int i = 0;
            
            while (HP > 0)
            {
                HP -= Damage;
                minB += copy;
                i++;
            }

            label8.Text = "Кол-во попаданий: " + i.ToString();
            label9.Text = "В ттк тело: " + minB;
            Damage *= 1.3;
            HP = 100;
            i = 0;
            while (HP > 0)
            {
                MessageBox.Show(copy+"");
                HP -= Damage;
                copy += copy1;
                i++;
            }

            label5.Text = "В ттк голову: " + copy;
            label10.Text = "Кол-во попаданий: " + i.ToString();
        }
    }
    }
