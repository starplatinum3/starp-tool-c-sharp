using starpTool.top.starp.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
//中间使用

namespace starpTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //https://blog.csdn.net/hbqhdlc/article/details/6843650

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //https://zhidao.baidu.com/question/208874056.html
            string filePath = SearchTermTextBox.Text;
            //Console.WriteLine("filePath");
            //Console.WriteLine(filePath);
            //filePath.Split("\\\\")
            filePath= filePath.Replace("\\\\", "\\");
            filePath = filePath.Replace("/", "\\");
            Trace.WriteLine("filePath");
        //https://blog.csdn.net/nini3816/article/details/89487964
            Trace.WriteLine(filePath);
            //https://blog.csdn.net/fjh1997/article/details/107010095
            //char# 
            //c# 判断路径文件存在
            //string path = Application.StartupPath + "\\新建文件夹";
            if (!System.IO.Directory.Exists(filePath))
            {
                //左斜杠不能跳转吗。。
                tbResult.Text = "不存在路径: " + filePath;
                Trace.WriteLine("不存在路径: "+filePath);
                //System.IO.Directory.CreateDirectory(path);//不存在就创建目录
            }
            //FileExplorerUtil.ExplorerFile("D:\\public");
            FileExplorerUtil.ExplorerFile(filePath);
            //sender.
            //ExplorerFile()

        }
    }
}
