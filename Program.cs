using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //bool createdNew;

            //using (Mutex mutex = new Mutex(true, Application.ProductName, out createdNew))
            //{
            //    if (createdNew)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new Form1());
            //    }
            //    else
            //    {
            //        MessageBox.Show("该程序正在运行中...");

            //        // 终止此进程并为基础操作系统提供指定的退出代码。
            //        Environment.Exit(1);
            //    }
            //}

            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 1)
            {
                MessageBox.Show("该程序正在运行中...");

                //// 终止此进程并为基础操作系统提供指定的退出代码。
                Environment.Exit(1);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
