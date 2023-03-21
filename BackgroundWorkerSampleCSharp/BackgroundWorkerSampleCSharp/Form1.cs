using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace BackgroundWorkerSampleCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Start BackgroundWorker
            backgroundWorker1.RunWorkerAsync(2000);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Cancel BackgroundWorker
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker helperBW = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = BackgroundProcessLogicMethod(helperBW, arg);
            if (helperBW.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // Put all of background logic that is taking too much time
        private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
        {
            int result = 0;
            Thread.Sleep(5000);
            //MessageBox.Show("I was doing some work in the background.");
            Console.WriteLine("I was doing some work in the background.");
            return result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled) MessageBox.Show("Operation was canceled");
            if (e.Cancelled) Console.WriteLine("Operation was canceled");
            else if (e.Error != null)
            {
                Console.WriteLine("error : " + e.Error.Message);
            }
            //MessageBox.Show(e.Error.Message);
            else
            {
                Console.WriteLine("result : " + e.Result.ToString());
                //MessageBox.Show(e.Result.ToString());
            }
        }
    }
}
