using Kyozy.MiniblinkNet;
using System.Windows;

namespace DMSkin.Miniblink
{
    public partial class MainWindow : Window
    {
        private WebView m_wke;
        public MainWindow()
        {
            InitializeComponent();

            m_wke = new WebView(); //构造函数可以是无参，但是后面必须调用 Bind 方法
            m_wke.Bind(pictureBox);//随便绑定一个控件或窗口
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            m_wke.LoadURL("http://www.baidu.com");
        }
    }
}
