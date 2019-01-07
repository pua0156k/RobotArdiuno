using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RobotArdiuno
{
    public partial class Mainfrm : Form
    {
        Form1 frm = new Form1();
        U3D u3d = new U3D();
        int Script_Count = 0;
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_Delay.Text == string.Empty)
            {
                MessageBox.Show("請設定延時");
                return;
            }
            ListViewItem lvi = new ListViewItem((listView1.Items.Count+1).ToString());
            lvi.SubItems.Add(txt_Axis_1.Text);
            lvi.SubItems.Add(txt_Axis_2.Text);
            lvi.SubItems.Add(txt_Axis_3.Text);
            lvi.SubItems.Add(txt_Axis_4.Text);
            lvi.SubItems.Add(txt_Axis_5.Text);
            lvi.SubItems.Add(txt_Axis_6.Text);
            lvi.SubItems.Add(txt_Delay.Text);
            listView1.Items.Add(lvi);

            txt_Axis_1.Text = string.Empty;
            txt_Axis_2.Text = string.Empty;
            txt_Axis_3.Text = string.Empty;
            txt_Axis_4.Text = string.Empty;
            txt_Axis_5.Text = string.Empty;
            txt_Axis_6.Text = string.Empty;
            txt_Delay.Text = string.Empty;
        }
        string encrypt(string str)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            string str16 = string.Empty;
            for (int i = 0; i < bytes.Length; i++)
            {
                str16 += Convert.ToString(Convert.ToInt32(bytes[i]), 16);
            }
            return str16;

        }
        string Decrypt(string str)
        {
            string Unstr = string.Empty;
            List<byte> strUn16 = new List<byte>();
            for (int i = 0; i < (str.Length / 2); i++)
            {
                string st = str.Substring(i * 2, 2);
                int ab = Convert.ToInt32(st, 16);
                byte stb = Convert.ToByte(ab);
                strUn16.Add(stb);
            }
            byte[] Unbyte = strUn16.ToArray();
            Unstr = System.Text.Encoding.UTF8.GetString(Unbyte);
            return Unstr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.RestoreDirectory = false;
            
            /*
            if (OpenDir == string.Empty)
                ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            else
                ofd.InitialDirectory = OpenDir;
                */
            ofd.Filter = "tankong files (*.tankong)|*.tankong|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    if (MessageBox.Show(this, "確定要覆蓋函數表嗎?", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                listView1.Items.Clear();
                string Unstr = string.Empty;
                using (StreamReader sw = new StreamReader(ofd.FileName))
                {
                    string str = sw.ReadLine();
                    Unstr = Decrypt(str);

                }

                string[] Process_row = Unstr.Split('|');
                for (int i = 0; i < Process_row.Length; i++)
                {
                    string[] Process_field = Process_row[i].Split('+');
                    ListViewItem lv = new ListViewItem((i+1).ToString());
                    lv.SubItems.Add(Process_field[0]);
                    lv.SubItems.Add(Process_field[1]);
                    lv.SubItems.Add(Process_field[2]);
                    lv.SubItems.Add(Process_field[3]);
                    lv.SubItems.Add(Process_field[4]);
                    lv.SubItems.Add(Process_field[5]);
                    lv.SubItems.Add(Process_field[6]);
            
                    listView1.Items.Add(lv);
                }

                lb_script_filename.Text = ofd.SafeFileName;


            }
        }

        private void btn_Run_Script_Click(object sender, EventArgs e)
        {
            Script_Count = 0;
            listBox1.Items.Clear();
            string str1 = (listView1.Items[0].SubItems[1].Text == "") ? "-,-," : "0," + listView1.Items[0].SubItems[1].Text + ",";
            string str2 = (listView1.Items[0].SubItems[2].Text == "")?  "-,-," : "0," + listView1.Items[0].SubItems[2].Text + ",";
            string str3 = (listView1.Items[0].SubItems[3].Text == "") ? "-,-," : "0," + listView1.Items[0].SubItems[3].Text + ",";
            string str4 = (listView1.Items[0].SubItems[4].Text == "") ? "-,-," : "0," + listView1.Items[0].SubItems[4].Text + ",";
            string str5 = (listView1.Items[0].SubItems[5].Text == "") ? "-,-," : "0," + listView1.Items[0].SubItems[5].Text + ",";
            string str6 = (listView1.Items[0].SubItems[6].Text == "") ? "-,-," : "0," + listView1.Items[0].SubItems[6].Text + ",";
            string str7 = (listView1.Items[0].SubItems[7].Text == "") ? "0" : listView1.Items[0].SubItems[7].Text;
            serialPort1.WriteLine(str1+str2+str3+str4+str5+str6+str7);

        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.AddRange(SerialPort.GetPortNames());

            String src = Application.StartupPath + "\\UnityWeb\\CSharpTest.unity3d";
            panel1.Controls.Add(u3d);
            //進度條位置
            u3d._progressBarLoad.Top = panel1.Height - 20;
            //加載Unity3d
            u3d.InitUnity(src,panel1);
            // u3d._progressBarLoad.Visible = true;
            //委派事件
            u3d.UnityCall += new U3D.ExternalCallHandler(u3d_UnityCall);
        
        }
        private void u3d_UnityCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
            // MessageBox.Show( "收到Unity的消息:" + e.value);
        }
        bool SetupSP()
        {
            try
            {

                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.PortName = toolStripComboBox1.Text;
                serialPort1.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("連接埠設置失敗!");
                return false;
            }
        }

        private void btn_Com_connect_Click(object sender, EventArgs e)
        {
            if(SetupSP())
            {
                frm.label1.Text = "手臂連接狀態 :　成功！";
                btn_Com_connect.Enabled = false;
                btn_Com_stop.Enabled = true;
            }else
            {
                frm.label1.Text = "手臂連接狀態 :　失敗！";
            }

        }

        private void btn_Com_stop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btn_Com_stop.Enabled = false;
            btn_Com_connect.Enabled = true;
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            
            frm.mainfrm = this;
            frm.Show();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadLine();
            
            if(str == "end\r")
            {
                Script_Count++;
                if (Script_Count > listView1.Items.Count - 1)
                    return;
                this.Invoke(new Action(() => {
                string str1 = (listView1.Items[Script_Count].SubItems[1].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[1].Text+"," + listView1.Items[Script_Count].SubItems[1].Text + ",";
                string str2 = (listView1.Items[Script_Count].SubItems[2].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[2].Text+"," + listView1.Items[Script_Count].SubItems[2].Text + ",";
                string str3 = (listView1.Items[Script_Count].SubItems[3].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[3].Text+"," + listView1.Items[Script_Count].SubItems[3].Text + ",";
                string str4 = (listView1.Items[Script_Count].SubItems[4].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[4].Text+"," + listView1.Items[Script_Count].SubItems[4].Text + ",";
                string str5 = (listView1.Items[Script_Count].SubItems[5].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[5].Text+"," + listView1.Items[Script_Count].SubItems[5].Text + ",";
                string str6 = (listView1.Items[Script_Count].SubItems[6].Text == "") ? "-,-," : listView1.Items[Script_Count-1].SubItems[6].Text+"," + listView1.Items[Script_Count].SubItems[6].Text + ",";
                string str7 = (listView1.Items[Script_Count].SubItems[7].Text == "") ? "0" : listView1.Items[Script_Count].SubItems[7].Text;
                serialPort1.WriteLine(str1 + str2 + str3 + str4 + str5 + str6 + str7);
                }));
            }
            this.Invoke(new Action(() => {
                listBox1.Items.Add(str);
            }));
        }

        private void btn_SaveScript_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("沒有函數表");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.tankong|*.tankong";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                
                string str = string.Empty;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    str += listView1.Items[i].SubItems[1].Text + "+";
                    str += listView1.Items[i].SubItems[2].Text + "+";
                    str += listView1.Items[i].SubItems[3].Text + "+";
                    str += listView1.Items[i].SubItems[4].Text + "+";
                    str += listView1.Items[i].SubItems[5].Text + "+";
                    str += listView1.Items[i].SubItems[6].Text + "+";
                    str += listView1.Items[i].SubItems[7].Text + "|";
                }
                str = str.Substring(0, str.Length - 1);
                str = encrypt(str);
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(str);
                }
            }
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == 13)
                {
                    if (this.txtInput != null)
                    {
                        ListViewItem.ListViewSubItem lvst = (ListViewItem.ListViewSubItem)this.txtInput.Tag;

                        lvst.Text = this.txtInput.Text;

                        this.txtInput.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        [DllImport("user32.dll")]
        public static extern int GetScrollPos(int hwnd, int nBar);

        private TextBox txtInput;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtInput != null)
                txtInput.Dispose();
            try
            {
                ListViewItem item = this.listView1.GetItemAt(e.X, e.Y);

                //找到文本框
                Rectangle rect = item.GetBounds(ItemBoundsPortion.Entire);
                int StartX = rect.Left; //獲取文本框位置的X座標
                int ColumnIndex = 0;    //文本框的索引

                //獲取列索引
                //得到滑塊位置
                int pos = GetScrollPos(this.listView1.Handle.ToInt32(), 0);
                foreach (ColumnHeader Column in listView1.Columns)
                {
                    if (e.X + pos >= StartX + Column.Width)
                    {
                        StartX += Column.Width;
                        ColumnIndex += 1;
                    }
                }

                //if (ColumnIndex < this.listView1.Columns.Count - 1)
                // {
                //     return;
                // }

                this.txtInput = new TextBox();

                // txtInput為TextBox
                this.txtInput.Parent = this.listView1;

                //編輯
                if (item != null)
                {
                    rect.X = StartX;
                    rect.Width = this.listView1.Columns[ColumnIndex].Width; //修改寬度與修改的列相同             
                    this.txtInput.Bounds = rect;              //文本框顯示位置
                    this.txtInput.Multiline = true;
                    //顯示文本框
                    this.txtInput.Text = item.SubItems[ColumnIndex].Text;
                    this.txtInput.Tag = item.SubItems[ColumnIndex];
                    this.txtInput.KeyPress += new KeyPressEventHandler(txtInput_KeyPress);
                    this.txtInput.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
