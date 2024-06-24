using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace customMessage
{
    public enum FYMessageType
    {
        Success,
        Warn,
        Error
    }
    public partial class FYMessage : Form
    {


        #region 无边框窗体背景阴影
        // 导入dwmapi.dll中的函数
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset); // 声明DwmExtendFrameIntoClientArea函数

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize); // 声明DwmSetWindowAttribute函数

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled); // 声明DwmIsCompositionEnabled函数

        private bool m_aeroEnabled; // 用于跟踪Aero效果是否已启用的标志
        private const int CS_DROPSHADOW = 0x00020000; // 启用窗口下方投影效果的常量
        private const int WM_NCPAINT = 0x0085; // 非客户区绘制的窗口消息
        private const int WM_ACTIVATEAPP = 0x001C; // 应用程序激活的窗口消息

        // 定义用于窗口阴影边框的边距的结构体
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams // 重写CreateParams属性
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled(); // 检查Aero效果是否已启用
                CreateParams cp = base.CreateParams; // 获取基本的CreateParams
                if (!m_aeroEnabled) // 如果Aero效果未启用
                    cp.ClassStyle |= CS_DROPSHADOW; // 启用投影效果

                return cp;
            }
        }

        public int WM_ACTIVATE { get; private set; }
        public int WA_INACTIVE { get; private set; }

        // 检查Aero效果是否已启用的方法
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6) // 如果操作系统版本为Windows Vista或更高版本
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled); // 检查桌面窗口管理器组合是否已启用
                return (enabled == 1) ? true : false; // 如果组合已启用，则返回true，否则返回false
            }
            return false; // 如果操作系统版本低于Windows Vista，则返回false
        }

        // 重写WndProc方法
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg) // 根据消息类型进行选择
            {

                case WM_NCPAINT: //133 如果消息为WM_NCPAINT（用于绘制非客户区）

                    if (m_aeroEnabled) // 如果Aero效果已启用
                    {

                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4); // 设置DWM的窗口属性以扩展框架
                        MARGINS margins = new MARGINS() // 定义框影的边距
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins); // 扩展框架到客户区域
                    }

                    break;

                default:
                    break;
            }

            base.WndProc(ref m); // 调用基本的WndProc方法

        }

        #endregion

        /// <summary>
        /// 选择的状态  fasle关闭  true继续
        /// </summary>
        private static bool state = false;

        //窗口类型
        public enum enmType
        {
            Success,
            Error,
            Warn,
            Info
        }
        //动作
        public enum enmAction
        {
            Start,
            Close
        }

        public FYMessage()
        {
            m_aeroEnabled = false;
            InitializeComponent();
            labText.Select();
        }


        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //给窗体添加MouseDown事件
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & this.WindowState == FormWindowState.Normal)
            {
                //移动窗体
                this.Capture = false;
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //记录当前动作
        private FYMessage.enmAction action;
        /// <summary>
        /// 配合定时器实现一个动画效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.Start:
                    timer1.Interval = 1;
                    if (this.Opacity < 1.0)
                    {
                        this.Opacity += 0.1;
                    }
                    break;
                case enmAction.Close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        /// <summary>
        /// 内容 弹框类型 标题
        /// </summary>
        /// <param name="Content">提示文字</param>
        /// <param name="type">弹框类型</param>
        /// <param name="Title">弹框标题</param>
        public void Alert(string Content, enmType type, string Title)
        {
            this.Opacity = 0.0;
            switch (type)
            {
                //根据类型设置弹框的颜色和图标
                case enmType.Success:
                    this.BackColor = Color.FromArgb(92, 184, 92);
                    this.btnConfirm.BackColor = Color.FromArgb(92, 184, 92);
                    this.pbxIcon.Image = imgList.Images[2];
                    this.labTitle.ForeColor = Color.White;
                    this.btnConfirm.ForeColor = Color.White;
                    break;
                case enmType.Error:
                    this.BackColor = Color.FromArgb(217, 83, 79);
                    this.btnConfirm.BackColor = Color.FromArgb(217, 83, 79);
                    this.pbxIcon.Image = imgList.Images[0];
                    this.labTitle.ForeColor = Color.White;
                    this.btnConfirm.ForeColor = Color.White;
                    break;
                case enmType.Warn:
                    this.BackColor = Color.FromArgb(248, 188, 6);
                    this.btnConfirm.BackColor = Color.FromArgb(248, 188, 6);
                    this.pbxIcon.Image = imgList.Images[1];
                    this.btnQuXiao.Show();
                    this.btnConfirm.Location = new System.Drawing.Point(68, 11);
                    this.btnQuXiao.Location = new System.Drawing.Point(169, 11);
                    this.labTitle.ForeColor = Color.White;
                    this.btnConfirm.ForeColor = Color.White;
                    break;
                case enmType.Info:
                    this.BackColor = Color.FromArgb(240, 240, 240);
                    this.pbxIcon.Visible = false;
                    this.labText.Location = new System.Drawing.Point(0, 15);
                    this.labText.Size = new System.Drawing.Size(296, 65);
                    this.labText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.labTitle.ForeColor = System.Drawing.Color.Black;
                    this.btnConfirm.BackColor = Color.White;
                    this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
                    this.btnConfirm.FlatAppearance.BorderSize = 1;
                    this.btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                    break;
            }
            this.labText.Text = Content;
            this.action = enmAction.Start;
            this.timer1.Interval = 1;
            this.timer1.Start();
            this.ShowDialog();//显示
        }
        /// <summary>
        /// 弹框提示
        /// </summary>
        /// <param name="Content">弹框提示文字</param>
        /// <param name="Title">弹框标题</param>
        /// <param name="Type">弹框类型</param>
        public static bool Show(string Content, string Title, FYMessageType Type)
        {
            FYMessage Moudel = new FYMessage();
            switch (Type)
            {
                case FYMessageType.Success:
                    Moudel.Alert(Content, enmType.Success, Title);
                    break;
                case FYMessageType.Warn:
                    Moudel.Alert(Content, enmType.Warn, Title);
                    break;
                case FYMessageType.Error:
                    Moudel.Alert(Content, enmType.Error, Title);
                    break;
            }
            return state;
        }
        public static bool Show(string Content, FYMessageType Type)
        {
            string Title = "系统提示";
            FYMessage Moudel = new FYMessage();
            switch (Type)
            {
                case FYMessageType.Success:
                    Moudel.Alert(Content, enmType.Success, Title);
                    break;
                case FYMessageType.Warn:
                    Moudel.Alert(Content, enmType.Warn, Title);
                    break;
                case FYMessageType.Error:
                    Moudel.Alert(Content, enmType.Error, Title);
                    break;
            }
            return state;
        }
        public static bool Show(string Content)
        {
            FYMessage Moudel = new FYMessage();
            Moudel.Alert(Content, enmType.Info, "系统提示");
            return state;
        }
        /// <summary>
        /// 确定并关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //设置枚举类型为关闭状态
            state = true;
            this.action = enmAction.Close;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
        /// <summary>
        /// 取消并关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            //设置枚举类型为关闭状态
            state = false;
            this.action = enmAction.Close;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
