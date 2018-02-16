using Imtiaz;
using SharpRaven;
using SharpRaven.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        /// <summary>
        /// Closes the application to stop server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            var ravenClient = new RavenClient("https://ef857dd8c6844201918c6b8753aa9f32@sentry.io/287903");
            try
            {
                int i2 = 0;
                int i = 10 / i2;
            }
            catch (Exception exception)
            {
                ravenClient.Capture(new SentryEvent(exception));
            }
        }
    }
}
