using SharpRaven;
using SharpRaven.Data;
using System;
using System.Diagnostics;
using System.IO;
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
            if (bool.Parse(File.ReadAllText(@"C:\pollaxdata\server\pref\report_error.dat")))
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

        private void tabPage2_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(
                fileName: "notepad.exe", 
                arguments: @"C:\pollaxdata\server\pref\webserver_dir.dat"
                );

            //alert the user of the gravity of the situation
            MessageBox.Show(
                owner: this,
                text: "You will have to manually edit vdirs.dat and make the necessary changes in File Explorer before Pollax will work again.",
                caption: "Warning"
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = File.ReadAllText(@"C:\pollaxdata\server\pref\port.dat");

            //start loggin tab
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                File.WriteAllText
                (
                    path: @"C:\pollaxdata\server\pref\report_error.dat",
                    contents: "true"
                );
            }

            else if (!checkBox1.Checked)
            {
                File.WriteAllText
                (
                    path: @"C:\pollaxdata\server\pref\report_error.dat",
                    contents: "false"
                );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int newport = int.Parse(maskedTextBox1.Text);
            File.WriteAllText(@"C:\pollaxdata\server\pref\port.dat", newport.ToString());
        }
>>>>>>> 5bcc10ab5c2c1d08a02885d3a6cf4eecbe5bcb66
    }
}
