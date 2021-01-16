using System;
using System.Reflection;
using System.Windows.Forms;

namespace VNCVSProjectWizard
{
    public partial class Form1 : Form
    {
        private static string customAPPLICATION;
        private static string customNAMESPACE;

        private static string customEVENT;
        private static string customTYPE;
        private static string customITEM;

        private static string customACTION;

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

        public static string CustomNAMESPACE
        {
            get
            {
                return customNAMESPACE;
            }
            set
            {
                customNAMESPACE = value;
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

        public static string CustomITEM
        {
            get
            {
                return customITEM;
            }
            set
            {
                customITEM = value;
            }
        }

        public static string CustomACTION
        {
            get
            {
                return customACTION;
            }
            set
            {
                customACTION = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customAPPLICATION = txtAPPLICATION.Text;
            customNAMESPACE = txtNAMESPACE.Text;
            customEVENT = txtEVENT.Text;
            customTYPE = txtTYPE.Text;
            customITEM = txtITEM.Text;

            customACTION = txtACTION.Text;

            this.Close();
        }

    }
}
