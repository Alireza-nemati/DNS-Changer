using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace DNS_Changer
{
    public partial class Main : Form
    { 
        string ?WifiIP;
        string ?WifiDns;
        string ?WifiName;

        string ?PrimaryDNS;
        string ?SecondDNS;

        bool active = false;

        public Main()
        {
            InitializeComponent();
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            WifiInf(out WifiIP, out WifiDns, out WifiName);
            lbl_LocalIp.Text = WifiIP;
        }
        //Main_Load
        private static void WifiInf(out string ip, out string dns, out string nic)  // To get current wifi config
        {
            ip = "";
            dns = "";
            nic = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {

                    foreach (IPAddress dnsAdress in ni.GetIPProperties().DnsAddresses)
                    {
                        if (dnsAdress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            dns = dnsAdress.ToString();
                        }
                    }

                    foreach (UnicastIPAddressInformation ips in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ips.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !ips.Address.ToString().StartsWith("169")) //to exclude automatic ips
                        {
                            ip = ips.Address.ToString();
                            nic = ni.Name;
                        }
                    }
                }
            }

        }
        //WifiInf


        private void SetIP(string arg)
        {
            try
            {

                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas";
                psi.Arguments = arg;
                Process.Start(psi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        //SetIP

        void Connect()
        {
            
            string selected = combo_setServer.SelectedIndex.ToString();

            /*Shecan
            Radar(Game)
            Cloudflare
            Google*/

            switch (selected)
            {
                case "0":
                    PrimaryDNS = "178.22.122.100";
                    SecondDNS = "185.51.200.2";
                    break;
                case "1":
                    PrimaryDNS = "10.202.10.10";
                    SecondDNS = "10.202.10.11";
                    break;
                case "2":
                    PrimaryDNS = "1.1.1.1";
                    SecondDNS = "1.0.0.1";
                    break;
                case "3":
                    PrimaryDNS = "8.8.8.8";
                    SecondDNS = "8.8.4.4";
                    break;
                case "4":
                    PrimaryDNS = "10.202.10.202";
                    SecondDNS = "10.202.10.102";
                    break;
                case "5":
                    PrimaryDNS = "185.55.226.26";
                    SecondDNS = "185.55.225.25";
                    break;
            }
         
       

            SetIP("/c netsh interface ip set address " + WifiName + " & netsh interface ip set dns " + WifiName + " static " + PrimaryDNS + $" & netsh interface ip add dns {WifiName} {SecondDNS} index=2");

            lbl_status.Text = "Active";
            lbl_status.ForeColor = Color.Green;
            btnAction.Text = "Disconnected";
        }

        void disConnect()
        {
            SetIP("/c netsh interface ip set address " + WifiName + " dhcp & netsh interface ip set dns " + WifiName + " dhcp");
            lbl_status.Text = "InActive";
            lbl_status.ForeColor = Color.Red;
            btnAction.Text = "Connected";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (active)
            {
                disConnect();
                active = false;
                
            }
            else
            {
                Connect();
                active = true;
            }
        }
    }
}