using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axUnityWebPlayer1.src = @"D:\我的文档\U3D\Project\demo13d\11101\1111\1\1 - 副本.RAR";
            timer1.Start();
            //服务器更新了一个文件2016年7月8日14:56:11
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            axUnityWebPlayer1.SendMessage("Sphere", "Down", null);
        }

        private void axUnityWebPlayer1_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
         Text =   e.value.ToString();
        }
    }
}
