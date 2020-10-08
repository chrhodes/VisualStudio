using System;
using System.Reflection;
using System.Windows.Forms;

namespace VNCVSProjectWizard
{
    public partial class Form1 : Form
    {
        private static string customAPPLICATION;
        private static string customEVENT;
        private static string customTYPE;

        public Form1()
        {
            InitializeComponent();
            lblAppVersion.Text = Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute)).ToString();
        }

        public static string CustomAPPLICATION
        {
            get
            {
                return customAPPLICATION;
            }
            set
            {
                customAPPLICATION = value;
            }
        }

        public static string CustomEVENT
        {
            get
            {
                return customEVENT;
            }
            set
            {
                customEVENT = value;
            }
        }

        public static string CustomTYPE
        {
            get
            {
                return customTYPE;
            }
            set
            {
                customTYPE = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customAPPLICATION = txtAPPLICATION.Text;
            customEVENT = txtEVENT.Text;
            customTYPE = txtTYPE.Text;

            this.Close();
        }
    }
}
