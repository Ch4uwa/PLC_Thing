using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMRON.Compolet.CIP;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly NJCompolet myNJ2 = new NJCompolet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                myNJ2.UseRoutePath = false;
                myNJ2.PeerAddress = "192.168.250.1";
                myNJ2.LocalPort = 2;
                myNJ2.Active = true;

                Text = myNJ2.UnitName;
                Get_Tags();    
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void Get_Temp()
        {
            try
            {
                int nj2Temp = (int)myNJ2.ReadVariable("temperatur_verklig");
                chart1.Series["Temperature"].Points.AddXY(DateTime.Now.ToString("T"), nj2Temp);
            }
            catch (Exception)
            {
            }
        }

        private void Get_Tags()
        {
            try
            {
                var var_names = myNJ2.VariableNames;

                listBox1.Items.Clear();

                foreach (var item in var_names)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch(Exception e)
            {
                label5.Text = e.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Hej";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_getvars(object sender, EventArgs e)
        {
            Get_Tags();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (string)myNJ2.ReadVariable(listBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                textBox1.Text = "Failed to fetch selected";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                myNJ2.WriteVariable((string)listBox1.SelectedItem, textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");
            Get_Temp();
        }
    }
}
