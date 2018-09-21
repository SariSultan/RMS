using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calcium_RMS
{
    public static class ControlHelper
    {
        #region Redraw Suspend/Resume
        [DllImport("user32.dll", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private const int WM_SETREDRAW = 0xB;

        public static void SuspendDrawing(this Control target)
        {
            SendMessage(target.Handle, WM_SETREDRAW, 0, 0);
        }

        public static void ResumeDrawing(this Control target) { ResumeDrawing(target, true); }
        public static void ResumeDrawing(this Control target, bool redraw)
        {
            try
            {
                SendMessage(target.Handle, WM_SETREDRAW, 1, 0);
                if (redraw)
                {
                    target.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ResumeDrawing Exception" + ex.ToString());
                throw;
            }
           
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MoveBorderless(this Control target, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(target.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


        
    }
  
}
