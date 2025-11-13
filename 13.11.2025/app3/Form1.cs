using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obiekt obiekt = new Obiekt();
            obiekt.sendCurrentCounterValue += Obiekt_sendCurrentCounterValue;
        }
           
        private void Obiekt_sendCurrentCounterValue(object sender, int? e)
        {
            //to jest za pomoca tak zwanej lambdy
            label1.BeginInvoke(new Action(() => { label1.Text = e.ToString(); }));

            //pierwszy sposob
            //MethodInvoker methodInvokerDelegate = delegate ()
            //{
            //    this.label1.Text = e.ToString();
            //};

            //if (this.InvokeRequired)
            //    this.Invoke(methodInvokerDelegate);
            //else
            //    methodInvokerDelegate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Obiekt
    {
        private System.Timers.Timer timer;
        private int counter = 0;

        public event EventHandler<int?> sendCurrentCounterValue;

        public Obiekt()
        {
            timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        } 

        //powinien byc object? ale zła wersje mam
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            counter++;
            SendCurrentCounterValue(counter);
        }

        private void SendCurrentCounterValue(int counter)
        {
            if (sendCurrentCounterValue != null)
            {
                sendCurrentCounterValue?.Invoke(this, counter);
            }
        }
    }
}
