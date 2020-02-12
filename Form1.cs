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
            connect();
        }

        private void connect() 
        {
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
            var nj2Temp = (int)myNJ2.ReadVariable("TempsensorInput") * 0.1;
            
            if (chart1.Series["Temperature"].Points.Count > 5)
            {
                chart1.Series["Temperature"].Points.AddXY(label1.Text, nj2Temp);
                chart1.Series["Temperature"].Points.RemoveAt(0);
            }
            else
            {
                chart1.Series["Temperature"].Points.AddXY(label1.Text, nj2Temp);
            }
        }

        private void Get_Tags()
        {
            try
            {
                var var_names = myNJ2.VariableNames;

                listBox1.Items.Clear();
                textBox1.ResetText();

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
            switch (button1.Text)
            {
                case "0":
                    button1.Text = "1";
                    break;
                case "1":
                    button1.Text = "0";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "0":
                    button1.Text = "1";
                    break;
                case "1":
                    button1.Text = "0";
                    break;
                default:
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "0":
                    button1.Text = "1";
                    break;
                case "1":
                    button1.Text = "0";
                    break;
                default:
                    break;
            }
        }

        private void btn_getvars(object sender, EventArgs e)
        {
            Get_Tags();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ResetText();
                string variableName = listBox1.GetItemText(listBox1.SelectedItem);
                var variableValue = "";

                if (myNJ2.ReadVariable(variableName).GetType() == typeof(int) && variableName == "TempsensorInput")
                {
                    int a = (int)myNJ2.ReadVariable(variableName);
                    variableValue = ((float)a*0.1).ToString();
                }
                else
                {
                    variableValue = myNJ2.ReadVariable(variableName).ToString();
                }

                textBox1.Text = variableValue;
            }
            catch (Exception exVal)
            {
                textBox1.Text = exVal.Message;
            }
        }

        private void btn_changevalue_Click(object sender, EventArgs e)
        {
            try
            {
                myNJ2.WriteVariable(listBox1.GetItemText(listBox1.SelectedItem), textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Get_Temp();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Set_Clock();
        }
        private void Set_Clock()
        {
            label1.Text = DateTime.Now.ToString("t");
        }
    }
}
