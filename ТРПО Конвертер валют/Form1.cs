using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО_Конвертер_валют
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0)
            {
              MessageBox.Show("Выбранны одинаковые валюты " + "\nВыберите другую валюту");
            }


            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.90).ToString();
            }

            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 72.55).ToString();
            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 2.342).ToString();
            }
            
            //------------------------------------------------------------------


            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
              string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) / 1.11).ToString();
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1)
            {
                MessageBox.Show("Выбранны одинаковые валюты " + "\nВыберите другую валюту");
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 80.33).ToString();
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 2.61).ToString();
            }

            //------------------------------------------------------------------

            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.01).ToString();
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.01).ToString();
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 2)
            {
                MessageBox.Show("Выбранны одинаковые валюты " + "\nВыберите другую валюту");
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.03).ToString();


            }
            //------------------------------------------------------------------

            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.43).ToString();
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.38).ToString();
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 2)
            {
                string result = textBox1.Text;
                Convert.ToUInt32(result);
                textBox2.Text = (Convert.ToDouble(textBox1.Text) * 30.77).ToString();
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 3)
            {
                MessageBox.Show("Выбранны одинаковые валюты " + "\nВыберите другую валюту");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Close();
           
        }
    }
}
