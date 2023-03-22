using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BackgroundWorkerSampleCSharp.lib1;


namespace BackgroundWorkerSampleCSharp
{
    public partial class Form1 : Form
    {
        #region field

        private Test t;

        #endregion

        public Form1()
        {
            InitializeComponent();

            t = new Test();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            Console.WriteLine("=============>>> StartButton btn is clicked ");

            Test__();


            // Start BackgroundWorker
            //backgroundWorker1.RunWorkerAsync(2000);


        }

        private async void Test__()
        {
            Task<int> calTask = t.Calculator();
            int rs = await calTask;

            Console.WriteLine("================>> RESULT : " + rs);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Cancel BackgroundWorker
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.CancelAsync();
            //}

            Console.WriteLine("=============>>> stop is clicked ");

        }





    }
}
