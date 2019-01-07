namespace RobotArdiuno
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Com_connect = new System.Windows.Forms.ToolStripButton();
            this.btn_Com_stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Test = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Delay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Axis_5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Axis_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Axis_3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Axis_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Axis_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Run_Script = new System.Windows.Forms.Button();
            this.btn_SaveScript = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Read_Script = new System.Windows.Forms.Button();
            this.lb_script_filename = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Axis_6 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.btn_Com_connect,
            this.btn_Com_stop,
            this.toolStripSeparator2,
            this.btn_Test});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "COM：";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Com_connect
            // 
            this.btn_Com_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_Com_connect.Image")));
            this.btn_Com_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Com_connect.Name = "btn_Com_connect";
            this.btn_Com_connect.Size = new System.Drawing.Size(51, 22);
            this.btn_Com_connect.Text = "連線";
            this.btn_Com_connect.Click += new System.EventHandler(this.btn_Com_connect_Click);
            // 
            // btn_Com_stop
            // 
            this.btn_Com_stop.Enabled = false;
            this.btn_Com_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Com_stop.Image")));
            this.btn_Com_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Com_stop.Name = "btn_Com_stop";
            this.btn_Com_stop.Size = new System.Drawing.Size(51, 22);
            this.btn_Com_stop.Text = "停止";
            this.btn_Com_stop.Click += new System.EventHandler(this.btn_Com_stop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Test
            // 
            this.btn_Test.Image = ((System.Drawing.Image)(resources.GetObject("btn_Test.Image")));
            this.btn_Test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(123, 22);
            this.btn_Test.Text = "機械手臂各軸測試";
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txt_Delay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Axis_5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Axis_4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Axis_3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Axis_2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Axis_1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能區";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(168, 102);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(30, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "->";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Delay
            // 
            this.txt_Delay.Location = new System.Drawing.Point(62, 192);
            this.txt_Delay.Name = "txt_Delay";
            this.txt_Delay.Size = new System.Drawing.Size(100, 22);
            this.txt_Delay.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "延時";
            // 
            // txt_Axis_5
            // 
            this.txt_Axis_5.Location = new System.Drawing.Point(62, 136);
            this.txt_Axis_5.Name = "txt_Axis_5";
            this.txt_Axis_5.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "第5軸";
            // 
            // txt_Axis_4
            // 
            this.txt_Axis_4.Location = new System.Drawing.Point(62, 108);
            this.txt_Axis_4.Name = "txt_Axis_4";
            this.txt_Axis_4.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "第4軸";
            // 
            // txt_Axis_3
            // 
            this.txt_Axis_3.Location = new System.Drawing.Point(62, 80);
            this.txt_Axis_3.Name = "txt_Axis_3";
            this.txt_Axis_3.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "第3軸";
            // 
            // txt_Axis_2
            // 
            this.txt_Axis_2.Location = new System.Drawing.Point(62, 52);
            this.txt_Axis_2.Name = "txt_Axis_2";
            this.txt_Axis_2.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "第2軸";
            // 
            // txt_Axis_1
            // 
            this.txt_Axis_1.Location = new System.Drawing.Point(62, 24);
            this.txt_Axis_1.Name = "txt_Axis_1";
            this.txt_Axis_1.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "第1軸";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(222, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "3D視圖";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "腳本";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Run_Script
            // 
            this.btn_Run_Script.ForeColor = System.Drawing.Color.Blue;
            this.btn_Run_Script.Location = new System.Drawing.Point(953, 50);
            this.btn_Run_Script.Name = "btn_Run_Script";
            this.btn_Run_Script.Size = new System.Drawing.Size(75, 23);
            this.btn_Run_Script.TabIndex = 1;
            this.btn_Run_Script.Text = "執行腳本";
            this.btn_Run_Script.UseVisualStyleBackColor = true;
            this.btn_Run_Script.Click += new System.EventHandler(this.btn_Run_Script_Click);
            // 
            // btn_SaveScript
            // 
            this.btn_SaveScript.Location = new System.Drawing.Point(953, 21);
            this.btn_SaveScript.Name = "btn_SaveScript";
            this.btn_SaveScript.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveScript.TabIndex = 1;
            this.btn_SaveScript.Text = "儲存腳本";
            this.btn_SaveScript.UseVisualStyleBackColor = true;
            this.btn_SaveScript.Click += new System.EventHandler(this.btn_SaveScript_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(941, 143);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "行";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1軸";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "2軸";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "3軸";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "4軸";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "5軸";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "6軸";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "延時(ms)";
            // 
            // btn_Read_Script
            // 
            this.btn_Read_Script.Location = new System.Drawing.Point(12, 280);
            this.btn_Read_Script.Name = "btn_Read_Script";
            this.btn_Read_Script.Size = new System.Drawing.Size(75, 23);
            this.btn_Read_Script.TabIndex = 3;
            this.btn_Read_Script.Text = "讀取腳本";
            this.btn_Read_Script.UseVisualStyleBackColor = true;
            this.btn_Read_Script.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_script_filename
            // 
            this.lb_script_filename.AutoSize = true;
            this.lb_script_filename.Location = new System.Drawing.Point(117, 285);
            this.lb_script_filename.Name = "lb_script_filename";
            this.lb_script_filename.Size = new System.Drawing.Size(20, 12);
            this.lb_script_filename.TabIndex = 4;
            this.lb_script_filename.Text = "Dir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "第6軸";
            // 
            // txt_Axis_6
            // 
            this.txt_Axis_6.Location = new System.Drawing.Point(74, 204);
            this.txt_Axis_6.Name = "txt_Axis_6";
            this.txt_Axis_6.Size = new System.Drawing.Size(100, 22);
            this.txt_Axis_6.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 423);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(857, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 448);
            this.listBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Run_Script);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btn_SaveScript);
            this.groupBox2.Location = new System.Drawing.Point(8, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "腳本";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 665);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_Axis_6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_script_filename);
            this.Controls.Add(this.btn_Read_Script);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Mainfrm";
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Delay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Axis_5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Axis_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Axis_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Axis_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Axis_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_SaveScript;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_Read_Script;
        private System.Windows.Forms.Label lb_script_filename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Axis_6;
        private System.Windows.Forms.Button btn_Run_Script;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Com_connect;
        private System.Windows.Forms.ToolStripButton btn_Com_stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Test;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}