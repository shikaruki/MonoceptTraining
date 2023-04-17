using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMultiThreadingFormApp
{
    internal class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            this.Text = "Ravi's Form";
            this.Width = 500;
            this.Height = 500;

            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += ((sender, EventArgs) =>
            {
                MessageBox.Show("Hello there");
            });
            
            Button btnPrint = new Button();
            btnPrint.Text = "Print Infinite";
            btnPrint.Location = new System.Drawing.Point(250,0);
            btnPrint.Click += ((sender, EventArgs) =>
            {
                PrintInfinity();
            });

            Button btnPrintWithThread = new Button();
            btnPrintWithThread.Text = "Non Blocking/Async";
            btnPrintWithThread.Location = new Point(350, 0);
            btnPrintWithThread.Click += ((sender, EventArgs) =>
            {
                Thread t = new Thread(PrintInfinity);
                t.Start();
            });

            this.Controls.Add(btnPrintWithThread);
            this.Controls.Add(btnHello);
            this.Controls.Add(btnPrint); ;

        }

        void PrintInfinity()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan futureTime = TimeSpan.FromMinutes(.15);
            while (true)
            //while(DateTime.Now - startTime < futureTime)
            {
                Console.WriteLine(DateTime.Now.ToString("T"));
            }
        }
    }
}
