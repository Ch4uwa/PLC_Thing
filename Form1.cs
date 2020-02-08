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
        private NJCompolet myNJ2 = new NJCompolet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myNJ2.UseRoutePath = false;
                myNJ2.PeerAddress = "192.168.250.1";
                myNJ2.LocalPort = 2;
                myNJ2.Active = true;

                label2.Text = myNJ2.UnitName;
            
                
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }


        }

        private void Get_Temp(object sender, EventArgs e)
        {
            int nj2Temp = (int)myNJ2.ReadVariable("temperatur_verklig");
            chart1.Series["Temperature"].Points.AddXY(DateTime.Now, nj2Temp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_getvars(object sender, EventArgs e)
        {
            var var_names = myNJ2.VariableNames;

            listBox1.Items.Clear();

            foreach (var item in var_names)
            {
                listBox1.Items.Add(item);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)myNJ2.ReadVariable(listBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myNJ2.WriteVariable((string)listBox1.SelectedItem, textBox1.Text);
        }
    }
}
