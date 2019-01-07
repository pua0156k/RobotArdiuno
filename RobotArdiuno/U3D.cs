using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RobotArdiuno
{
    public partial class U3D : UserControl,IMessageFilter
    {
        public U3D()
        {
            InitializeComponent();
            InitProgressBar();
        }

        private void U3D_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            if (DisableMouseRight)
            {
                Application.AddMessageFilter(this);
                this.Disposed += U3DPlayer_Disposed;
            }
        }
        #region 属性
        private String _src;
        /// <summary>
        /// Unity3D文件的路径
        /// </summary>
        public String Src
        {
            get { return _src; }
            private set { _src = value; }
        }

        private bool _disableMouseRight = true;
        /// <summary>
        /// 禁用鼠标右键
        /// </summary>
        public bool DisableMouseRight
        {
            get { return _disableMouseRight; }
            set { _disableMouseRight = value; }
        }

        #endregion

        #region 自定义事件
        //委托
        public delegate void ExternalCallHandler(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e);
        /// <summary>
        /// 接收Unity调用宿主函数的消息
        /// </summary>
        [Browsable(true), Description("接收Unity调用宿主(如WinForm)函数的消息")]
        public event ExternalCallHandler UnityCall;
        //方法
        public void OnUnityCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
            if (UnityCall != null)
            {
                UnityCall(sender, e);
            }
        }
        #endregion

        #region 内部变量
        private AxUnityWebPlayerAXLib.AxUnityWebPlayer _axUnityWebPlayer = null;
        public ProgressBar _progressBarLoad = null;
        #endregion

  
        private void InitProgressBar()
        {
            if (_progressBarLoad == null)
            {
                _progressBarLoad = new ProgressBar();
                _progressBarLoad.Height = 20;

                _progressBarLoad.Style = ProgressBarStyle.Marquee;
                _progressBarLoad.Top = (this.Height - _progressBarLoad.Height) / 2;
                _progressBarLoad.Visible = true;
                this.Controls.Add(_progressBarLoad);
            }
        }

        #region InitUnity
        /// <summary>
        /// 初始化UnityWebPlayer
        /// </summary>
        /// <param name="src">Unity3D文件的路径</param>
        public void InitUnity(String src,Control panel)
        {
            this.Width = panel.Width;
            this.Height = panel.Height;
            Src = src;
            if (!File.Exists(Src))
            {
                return;
            }
            var unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            Controls.Add(unity);
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            unity.src = Src;//Application.StartupPath + "\\u.unity3d";  //改成自己想要的路径
            AxHost.State state = unity.OcxState;
            Controls.Remove(unity);
            unity.Dispose();
            unity = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            ((System.ComponentModel.ISupportInitialize)(unity)).BeginInit();
            this.SuspendLayout();
            unity.Dock = DockStyle.Fill;
            //unity.Name = "Unity";
            unity.OcxState = state;
            unity.TabIndex = 0;
            
            //panel.Controls.Add(unity);
            this.Controls.Add(unity); //panel1是我用的一个容器，改成this.Controls也可以
            ((System.ComponentModel.ISupportInitialize)(unity)).EndInit();
            this.ResumeLayout(false);
            _axUnityWebPlayer = unity;
            if (_axUnityWebPlayer == null)
            {
                throw new Exception("_axUnityWebPlayer init fail");
            }
            else
            {
                _axUnityWebPlayer.OnExternalCall += _axUnityWebPlayer_OnExternalCall;
                _axUnityWebPlayer.Hide();
                ShowProgressBar();
            }
        }
        #endregion

        #region 进度条
        private void ShowProgressBar()
        {
            _progressBarLoad.Visible = true;
            _progressBarLoad.Left = 0;
            _progressBarLoad.Width = this.Width;
        }

        private void HideProgressBar()
        {
            if (_progressBarLoad != null)
            {
                _progressBarLoad.Visible = false;
            }
        }
        #endregion

        void _axUnityWebPlayer_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
            if (e.value.StartsWith("LOAD_COMPLETE"))
            {
                if (!_axUnityWebPlayer.Visible)
                {
                    //_progressBarLoad.Value = 
                    _axUnityWebPlayer.Width = this.Width;
                    _axUnityWebPlayer.Height = this.Height;
                    _axUnityWebPlayer.Show();
                    HideProgressBar();
                }
            }
            OnUnityCall(sender, e);
        }




        void U3DPlayer_Disposed(object sender, EventArgs e)
        {
            if (DisableMouseRight)
            {
                Application.RemoveMessageFilter(this);
            }
        }

        #region SendMessage
        /// <summary>
        /// 发送消息给Unity
        /// </summary>
        /// <param name="unityObjName">Unity中的对象名称</param>
        /// <param name="unityScriptyMethod">Unity脚本中的方法</param>
        /// <param name="val">传送的值.仅限于int、float、string</param>
        public void SendMessage(string unityObjName, string unityScriptyMethod, object val)
        {
            if (_axUnityWebPlayer == null)
            {
                return;
            }
            _axUnityWebPlayer.SendMessage(unityObjName, unityScriptyMethod, val);
        }
        #endregion

        private void U3DPlayer_MouseDown(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// 过滤鼠标右键
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        {
            if (_axUnityWebPlayer == null)
            {
                return false;
            }
            const int WM_RBUTTONDOWN = 0x204;
            const int WM_RBUTTONUP = 0x205;
            const int WM_RBUTTONDBLCLK = 0x206;
            // 屏蔽右键消息区域。
            System.Drawing.Rectangle my_Area = new System.Drawing.Rectangle(_axUnityWebPlayer.Location, _axUnityWebPlayer.Size);

            if (my_Area.Contains(this.PointToClient(Control.MousePosition)))
            {
                switch (m.Msg)
                {
                    case WM_RBUTTONDOWN:
                        return true;
                    case WM_RBUTTONUP:
                        return true;
                    case WM_RBUTTONDBLCLK:
                        return true;
                    default:
                        return false;
                }
            }

            return false;

        }
    
    }
}
