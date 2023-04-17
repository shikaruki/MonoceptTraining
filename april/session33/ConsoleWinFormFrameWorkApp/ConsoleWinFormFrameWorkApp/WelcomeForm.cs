using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWinFormFrameWorkApp
{
    internal class WelcomeForm : Form
    {
        
        public WelcomeForm()
        {
            this.Text = "Ravi's Form";
            this.Width= 500;
            this.Height= 500;

            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += GodListner;
            btnHello.Click += DevilListner;
            
            this.Controls.Add(btnHello);
            
        }
        public void GodListner(object sender,EventArgs eventArgs)
        {
            Console.WriteLine("God is listening");
        }
        public void DevilListner(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Devil is listening");
        }
    }
}
