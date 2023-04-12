using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabric
{
    public partial class Form1 : Form
    {
        AbstractLevel a;
        Taxi tax;
        City city;
        Driver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            a = new First();
            a.Play();
            tax = a.createTaxi();
            city = a.createCity();
            driver = a.createDriver();
            richTextBox1.Text += tax.type;
            richTextBox1.Text += "\n";
            richTextBox1.Text += city.name +" "+ city.color;
            richTextBox1.Text += "\n";
            richTextBox1.Text += driver.name + " speed=" + driver.speed + " stars" + driver.stars;
            richTextBox1.Text += "\n";
            richTextBox1.Text += "pice=" + city.price * driver.stars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
           a = new Second();
            a.Play();
            tax = a.createTaxi();
            city = a.createCity();
            driver = a.createDriver();
            richTextBox1.Text += tax.type;
            richTextBox1.Text += "\n";
            richTextBox1.Text += city.name + " " + city.color;
            richTextBox1.Text += "\n";
            richTextBox1.Text += driver.name +  "speed=" + driver.speed + " stars" + driver.stars; 
            richTextBox1.Text += "\n";
            richTextBox1.Text += "pice=" + city.price * driver.stars;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            a = new Third();
            a.Play();
            tax = a.createTaxi();
            city = a.createCity();
            driver = a.createDriver();
            richTextBox1.Text += tax.type;
            richTextBox1.Text += "\n";
            richTextBox1.Text += city.name + " " + city.color;
            richTextBox1.Text += "\n";
            richTextBox1.Text += driver.name + " speed=" + driver.speed + " stars" + driver.stars;
            richTextBox1.Text += "\n";
            richTextBox1.Text += "pice=" + city.price*driver.stars;
        }
    }
}
