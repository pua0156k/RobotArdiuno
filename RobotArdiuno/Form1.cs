using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotArdiuno
{
    public partial class Form1 : Form
    {
        public Mainfrm mainfrm;
        int Run_Script_Count = 0;
        Stopwatch st = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button1":
                    trackBar1.Minimum = Convert.ToInt32(txt_min_1.Text);
                    trackBar1.Maximum = Convert.ToInt32(txt_max_1.Text);
                    break;
                case "button2":
                    trackBar2.Minimum = Convert.ToInt32(txt_min_2.Text);
                    trackBar2.Maximum = Convert.ToInt32(txt_max_2.Text);
                    break;
                case "button3":
                    trackBar3.Minimum = Convert.ToInt32(txt_min_3.Text);
                    trackBar3.Maximum = Convert.ToInt32(txt_max_3.Text);
                    break;
                case "button4":
                    trackBar4.Minimum = Convert.ToInt32(txt_min_4.Text);
                    trackBar4.Maximum = Convert.ToInt32(txt_max_4.Text);
                    break;
                case "button5":
                    trackBar5.Minimum = Convert.ToInt32(txt_min_5.Text);
                    trackBar5.Maximum = Convert.ToInt32(txt_max_5.Text);
                    break;
                case "button6":
                    trackBar6.Minimum = Convert.ToInt32(txt_min_6.Text);
                    trackBar6.Maximum = Convert.ToInt32(txt_max_6.Text);
                    break;
            }
            
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\Setting.txt"))
            {
                sw.WriteLine(txt_min_1.Text); sw.WriteLine(txt_max_1.Text);
                sw.WriteLine(txt_min_2.Text); sw.WriteLine(txt_max_2.Text);
                sw.WriteLine(txt_min_3.Text); sw.WriteLine(txt_max_3.Text);
                sw.WriteLine(txt_min_4.Text); sw.WriteLine(txt_max_4.Text);
                sw.WriteLine(txt_min_5.Text); sw.WriteLine(txt_max_5.Text);
                sw.WriteLine(txt_min_6.Text); sw.WriteLine(txt_max_6.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1 = mainfrm.serialPort1;
            if(serialPort1.IsOpen)
            {
                label1.Text = "手臂連接狀態 :　成功！";
            }else
                label1.Text = "手臂連接狀態 :　失敗！";
            LoadData();
           
            txt_max_1.ImeMode = ImeMode.OnHalf; txt_max_1.ImeMode = ImeMode.OnHalf;
            txt_max_2.ImeMode = ImeMode.OnHalf; txt_min_2.ImeMode = ImeMode.OnHalf;
            txt_max_3.ImeMode = ImeMode.OnHalf; txt_min_3.ImeMode = ImeMode.OnHalf;
            txt_max_4.ImeMode = ImeMode.OnHalf; txt_min_4.ImeMode = ImeMode.OnHalf;
            txt_max_5.ImeMode = ImeMode.OnHalf; txt_min_5.ImeMode = ImeMode.OnHalf;
            txt_max_6.ImeMode = ImeMode.OnHalf; txt_min_6.ImeMode = ImeMode.OnHalf;
        }
        void LoadData()
        {
            using (StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\Setting.txt"))
            {
                txt_min_1.Text = sr.ReadLine(); txt_max_1.Text = sr.ReadLine();
                txt_min_2.Text = sr.ReadLine(); txt_max_2.Text = sr.ReadLine();
                txt_min_3.Text = sr.ReadLine(); txt_max_3.Text = sr.ReadLine();
                txt_min_4.Text = sr.ReadLine(); txt_max_4.Text = sr.ReadLine();
                txt_min_5.Text = sr.ReadLine(); txt_max_5.Text = sr.ReadLine();
                txt_min_6.Text = sr.ReadLine(); txt_max_6.Text = sr.ReadLine();
            }
            button1.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
            button4.PerformClick();
            button5.PerformClick();
            button6.PerformClick();
        }
       

        

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|2" + trackBar2.Value.ToString());
            label3.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|3" + trackBar3.Value.ToString());
            label4.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|4" + trackBar4.Value.ToString());
            label5.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|5" + trackBar5.Value.ToString());
            label6.Text = trackBar5.Value.ToString();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|6" + trackBar6.Value.ToString());
            label7.Text = trackBar6.Value.ToString();
        }

   

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadLine();
            if(str == "end\r")
            {
                st.Stop();
                Debug.Print(st.Elapsed.TotalMilliseconds.ToString());
            }
            /*this.Invoke(new Action(() => { 
            listBox1.Items.Add(str);
            }));*/
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            serialPort1.WriteLine("|1" + trackBar1.Value.ToString());
            label2.Text = trackBar1.Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            st.Restart();
        }
    }
}
