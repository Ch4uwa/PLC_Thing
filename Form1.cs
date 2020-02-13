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
            Get_Tags();
            set_vars();
        }

        private void set_vars()
        {
            
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
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void Get_Temp()
        {
            double nj2Temp;
            try
            {
                nj2Temp = (int)myNJ2.ReadVariable("TempsensorInput") * 0.1;
            
            }
            catch(Exception)
            {
                var rnd = new Random();
                nj2Temp = rnd.Next(6, 22);
            }
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

        private void Set_Clock()
        {
            try
            {
                label1.Text = DateTime.Now.ToString("T");
            }
            catch (Exception)
            {
            }
        }


        // Button click methods
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (prog_bar_btn1.Value > 0)
                {
                    myNJ2.WriteVariable("DataInt", 0);
                    button1.Text = string.Format("Flushing {0}", prog_bar_btn1.Value);
                }
            }
            catch (Exception)
            {
            }

        }

        private void btn_getvars(object sender, EventArgs e)
        {
            Get_Tags();
        }

        private void btn_changevalue_Click(object sender, EventArgs e)
        {
            try
            {
                myNJ2.WriteVariable(listBox1.GetItemText(listBox1.SelectedItem), textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = "Error writing to variable.";
            }
        }
        
        // Show value of selected item in textbox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ResetText();
                string variableName = listBox1.GetItemText(listBox1.SelectedItem);
                var variableValue = "";
                btn_changevalue.Enabled = true;
                
                // format value from temp sensor to human readable
                // disable set value button for sensor and bool item
                if (myNJ2.ReadVariable(variableName).GetType() == typeof(int) && variableName == "TempsensorInput")
                {
                    btn_changevalue.Enabled = false;
                    int a = (int)myNJ2.ReadVariable(variableName);
                    variableValue = ((float)a * 0.1).ToString();
                }
                else
                {
                    variableValue = myNJ2.ReadVariable(variableName).ToString();
                    if (variableName == "DataBit")
                    {
                        btn_changevalue.Enabled = false;
                    }
                }
                textBox1.Text = variableValue;
            }
            catch (Exception exVal)
            {
                textBox1.Text = exVal.Message;
            }
        }



        // Update functions
        private void timer1_Tick(object sender, EventArgs e)
        {
            Get_Temp();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Set_Clock();
            try
            {
                int prog_b_val = (int)myNJ2.ReadVariable("Dataint");
                prog_bar_btn1.Value = prog_b_val;
            }
            catch (Exception)
            {
            }
        }
    }
}
