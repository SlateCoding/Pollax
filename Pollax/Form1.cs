using SharpRaven;
using SharpRaven.Data;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Pollax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        internal static void ThreadException(object sender, ThreadExceptionEventArgs args)
        {

            if (Properties.Settings.Default.report_error == true)
            {
                Exception error = args.Exception;
                string dsn = Pollax.Server.Data.GetSensitiveData.GetDSN();
                var ravenClient = new RavenClient(dsn);

                ravenClient.Capture(new SentryEvent(error));
                MessageBox.Show("There was an error, and Pollax was forced to restart.");

                //restart the application
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }

            else
            {
                //alert the user that an eror occurred and restart the process.
                MessageBox.Show("There was an error, but Pollax was unable to file a bug report. To change this, go to settings. \r\nError details:" + args.Exception.Message);
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        internal static void Exception(object sender, UnhandledExceptionEventArgs args)
        {
            if (Properties.Settings.Default.report_error == true)
            {
                Exception error = (Exception)args.ExceptionObject;
                string dsn = Pollax.Server.Data.GetSensitiveData.GetDSN();
                var ravenClient = new RavenClient(dsn);

                ravenClient.Capture(new SentryEvent(error));
                MessageBox.Show("There was an error, and Pollax was forced to restart.");

                //restart the application
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }

            else
            {
                Exception baderror = (Exception)args.ExceptionObject;
                string details = baderror.Message;
                //alert the user that an eror occurred and restart the process.
                MessageBox.Show("There was an error, but Pollax was unable to file a bug report. To change this, go to settings. \r\nError details:" + details);
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        /// <summary>
        /// Closes the application to stop server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
        }

        /// <summary>
        /// Start Server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MyWebServer mws = new MyWebServer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            string root_dir = Properties.Settings.Default.webserver_dir;

            textBox1.Text = root_dir; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.webserver_dir = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
