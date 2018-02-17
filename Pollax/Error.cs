using SharpRaven;
using SharpRaven.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Pollax
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        static internal ThreadExceptionEventArgs args;
        static internal UnhandledExceptionEventArgs exception;
        static internal object sender;

        private void Error_Load(object sender, EventArgs e)
        {
            //lllalalallalatra;alalalalalalal
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sentry.io/share/issue/7fa2894ace91473b90ec7a786fbb2bff/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dsn = "https://ef857dd8c6844201918c6b8753aa9f32@sentry.io/287903";
            var ravenClient = new RavenClient(@"https://ef857dd8c6844201918c6b8753aa9f32@sentry.io/287903");

            Exception exception = getException();


            ravenClient.Capture(new SentryEvent(exception));

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
        }

        internal static void Initialize(object isender, ThreadExceptionEventArgs argss)
        {
            Error err = new Error();
            err.Show();
            argss = args;
            isender = sender;
        }

        internal static void Initialize(object isender, UnhandledExceptionEventArgs argss)
        {
            Error err = new Error();
            err.Show();
            argss = exception;
            isender = sender;
        }

        internal static System.Exception getException()
        {
            if (exception != null)
            {
                return args.Exception;
            }
            else
            {
                object err = exception.ExceptionObject;
                return (Exception)exception.ExceptionObject;
            }
        }
    }
}
