using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UptimeCheckerController;

namespace UptimeChecker
{
    public partial class MainForm : Form
    {
        private UptimeController uptimeController = new UptimeController();

        public MainForm()
        {
            InitializeComponent();
        }

        private void backgroundWorkerUptime_DoWork(object sender, DoWorkEventArgs e)
        {
            uptimeController.CheckUptime(MyCallback);
        }

        private void backgroundWorkerUptime_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        delegate void InfoMessageDel(String info);

        public void InfoMessage(String info)
        {
            if (txtboxConsole.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                txtboxConsole.Invoke(method, new object[] { info });
                return;
            }

            // Display the progress on form.
            txtboxConsole.Text = info;

            //_progressLog.Add(DateTime.Now.ToLongTimeString() + " : " + info);
        }

        public void MyCallback(string status)
        {
            // Update UI
            InfoMessage(status);
        }
    }
}
