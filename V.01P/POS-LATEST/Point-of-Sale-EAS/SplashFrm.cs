using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Threading;
namespace Calcium_RMS
{

    public partial class SplashFrm : Form
    {
        public SplashFrm()
        {
            InitializeComponent();
            ExtraFormSettings();
            // If we use solution2 we need to comment the following line.
            SetAndStartTimer();
        }
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        bool fadeIn = true;
        bool fadeOut = false;
        bool FinishedActivation = false;

        private void SetAndStartTimer()
        {            
            //t.Interval = 10;
            //t.Tick += new EventHandler(t_Tick);
           // t.Start();
           Thread aThread = new Thread(ActivationChecking);
            aThread.Start();
        }

        private void ExtraFormSettings()
        {
            this.FormBorderStyle = FormBorderStyle.None;
          //  this.Opacity = 0.5;
            // this.BackgroundImage = CSWinFormSplashScreen.Properties.Resources.SplashImage;
        }
        #region OLD_CODE
        void t_Tick(object sender, EventArgs e)
        {
            // Fade in by increasing the opacity of the splash to 1.0
            if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.02;
                }
                // After fadeIn complete, begin fadeOut
                else
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else if (fadeOut && FinishedActivation) // Fade out by increasing the opacity of the splash to 1.0
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.02;
                }
                else
                {
                    fadeOut = false;
                }
            }
            else // After fadeIn and fadeOut complete, stop the timer and close this splash.               
            {
               // if (progressBar1.Value<100)
                {
                    progressBar1.Value = (progressBar1.Value + 1) % 101;
                }
            }

             if (!(fadeIn || fadeOut))
                {
                    t.Stop();
                    this.Close();
                }
            
        }
        //void FadeOut(object sender, EventArgs e)
        //{
        //    if (fadeOut) // Fade out by increasing the opacity of the splash to 1.0
        //    {
        //        if (this.Opacity > 0)
        //        {
        //            this.Opacity -= 0.02;
        //        }
        //        else
        //        {
        //            fadeOut = false;
        //        }
        //    }

        //    // After fadeIn and fadeOut complete, stop the timer and close this splash.
        //    if (!(fadeIn || fadeOut))
        //    {
        //        t.Stop();
        //        this.Close();
        //    }
        //}
        #endregion OLD_CODE
        delegate void SetMessageCallback(object ActivationChecking);
        private void ActivationChecking(object Data)
        {
            Security.V1.ActivationCheck.TrialCheck();/*Hackers Trick*/
            Application.DoEvents();
            this.FinishedActivation = true;
            if (InvokeRequired)
            {
                
                SetMessageCallback d = new SetMessageCallback(ActivationChecking);
                this.BeginInvoke(d,new object[] { Data });
            }
            else
            {
                Thread.Sleep(1000);
                this.Close();
            }
        }
    }
}
