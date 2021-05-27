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

namespace WraithNath.ShutdownTimer
{
    public partial class frmShutdown : DarkUI.Forms.DarkForm
    {
        public frmShutdown()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                this.DisplayError(ex);
            }
        }

        private void DisplayError(Exception e)
        {
            using (DarkUI.Forms.DarkMessageBox messageBox = new DarkUI.Forms.DarkMessageBox(e.Message, "Error Encountered", DarkUI.Forms.DarkMessageBoxIcon.Error, DarkUI.Forms.DarkDialogButton.Ok))
                messageBox.ShowDialog();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                btnShutdown.Enabled = false;
                grpInterval.Enabled = false;

                TimeSpan ts = new TimeSpan((int)nudHours.Value, (int)nudMinutes.Value, (int)nudSeconds.Value);

                ThreadPool.QueueUserWorkItem(state =>
                {
                    TimeSpan time = (TimeSpan)state;
                    TimeSpan oneSecond = TimeSpan.FromSeconds(1);

                    while (time > TimeSpan.Zero)
                    {
                        Action action = () =>
                        {
                            lblTimer.Text = $"{time.TotalHours:00}:{time.Minutes:00}:{time.Seconds:00}";
                        };

                        if (lblTimer.InvokeRequired)
                            lblTimer.Invoke(action);
                        else
                            action.Invoke();

                        time = time - oneSecond;

                        Thread.Sleep(oneSecond);
                    }
                    ExitWindows.Shutdown();
                    Application.Exit();
                }, ts);
            }
            catch (Exception ex)
            {
                this.DisplayError(ex);
            }
        }
    }
}