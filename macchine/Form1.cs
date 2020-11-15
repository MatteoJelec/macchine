using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macchine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ok = false;

        Random rnd = new Random();

        private void bgwBlackCar_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker bgw = sender as BackgroundWorker;
            PictureBox pctb = (PictureBox)e.Argument;


            int n;

            while (pctb.Location.X<pictureBox1.Width && ok != true)
            {
                
               n = rnd.Next(0, 30);

                bgw.ReportProgress(n, pctb);
                Thread.Sleep(100);
            }
            ok = true;
              e.Result = pctb;


        }

        private void bgwBlackCar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
         
            PictureBox pctb = (PictureBox)e.UserState;


            pctb.Location = new Point (pctb.Location.X + e.ProgressPercentage, pctb.Location.Y);

        }

        private void bgwBlackCar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            PictureBox pctb = (PictureBox)e.Result;

      
            if (pctb == pctbBlackCar && pctb.Location.X >= pictureBox1.Width)
            {
                MessageBox.Show("LA MACCHINA NERA HA VINTO");
            }

            if (pctb == pctbRedCar && pctb.Location.X >= pictureBox1.Width)
            {
                MessageBox.Show("LA MACCHINA ROSSA HA VINTO");
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {

            bgwBlackCar.RunWorkerAsync(pctbBlackCar); 
            bgwRedCar.RunWorkerAsync(pctbRedCar);
        }

        private void Btn_Rivincita_Click(object sender, EventArgs e)
        {

            pctbBlackCar.Location = new Point(pictureBox1.Location.X, pctbBlackCar.Location.Y);


            pctbRedCar.Location = new Point(pictureBox1.Location.X, pctbRedCar.Location.Y);

            
            ok = false;

            Btn_Start_Click(sender, e);
        }
    }
}
