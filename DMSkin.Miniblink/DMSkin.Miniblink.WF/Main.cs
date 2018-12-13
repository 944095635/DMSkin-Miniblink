using Kyozy.MiniblinkNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSkin.Miniblink.WF
{
    public partial class Main : Form
    {
        private WebView m_wke;
        public Main()
        {
            InitializeComponent();

            m_wke = new WebView(); //构造函数可以是无参，但是后面必须调用 Bind 方法
            m_wke.Bind(this);//随便绑定一个控件或窗口
        }

        private void Main_Load(object sender, EventArgs e)
        {
            m_wke.LoadURL("http://www.baidu.com");
        }
    }
}
