using System;
using System.Management;
using System.Windows.Forms;

namespace OSVersionWMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public String Get_OS_Version()
        {

            String result = "Unable to Retrieve OS Version";
            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;
                //options.Username = "username";
                //options.Password = "password";
                //options.Authority = "NTLMDOMAIN:WORKGROUP";

                scope = new ManagementScope("\\\\" + "PCNAME" + "\\root\\cimv2", options);
                scope.Connect();

                //Query system for Operating System information
                ObjectQuery query = new ObjectQuery("SELECT Caption FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    result = m["Caption"].ToString();// + " " + m["BuildNumber"].ToString(); 
                }


            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            scope = null;

            return result;


        }




        private void btnGetOS_Click(object sender, EventArgs e)
        {
            txtOSVersion.Text = Get_OS_Version();
        }
    }
}

