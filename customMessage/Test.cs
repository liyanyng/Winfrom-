using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customMessage
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FYMessage.Show("这是一个普通提示");
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            FYMessage.Show("这是一个成功提示",FYMessageType.Success);
        }

        private void btnWarn_Click(object sender, EventArgs e)
        {
            FYMessage.Show("这是一个警告提示", FYMessageType.Warn);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            FYMessage.Show("这是一个错误提示", FYMessageType.Error);
        }
    }
}
