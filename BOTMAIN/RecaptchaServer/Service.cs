using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BOTMAIN.RecaptchaServer
{
    public class Service
    {
        public static bool CreateCert(String dnsNames, out X509Certificate2 x509Certificate2)
        {
            try
            {
                x509Certificate2 = null;
                using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                    PowerShellInstance.AddScript(@"New-SelfSignedCertificate -DnsName " + dnsNames);
                    Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                    foreach (var item in PSOutput)
                    {
                        if (item != null)
                        {
                            x509Certificate2 = ((X509Certificate2)item.ImmediateBaseObject);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                x509Certificate2 = null;
                return false;
            }
        }
        public static bool AddCert(X509Certificate2 cert, StoreName st, StoreLocation sl)
        {
            bool bRet = false;
            try
            {
                X509Store store = new X509Store(st, sl);
                store.Open(OpenFlags.ReadWrite);
                store.Add(cert);
                store.Close();
            }
            catch
            {
            }
            return bRet;
        }
        public static bool RemoveCert(String subject)
        {
            try
            {
                X509Store personalStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                personalStore.Open(OpenFlags.ReadWrite | OpenFlags.IncludeArchived);
                X509Certificate2Collection personalCol = personalStore.Certificates.Find(X509FindType.FindByIssuerName, subject, false);
                foreach (var cert in personalCol)
                {
                    personalStore.Remove(cert);
                }
                personalStore.Close();

                X509Store trustedStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                trustedStore.Open(OpenFlags.ReadWrite | OpenFlags.IncludeArchived);
                X509Certificate2Collection trustedCol = trustedStore.Certificates.Find(X509FindType.FindByIssuerName, subject, false);
                foreach (var cert in trustedCol)
                {
                    trustedStore.Remove(cert);
                }
                trustedStore.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool RegisterUri(String IpAdrress, String Port, String thumbPrint, String appId)
        {
            try
            {
                string query = "http add sslcert ipport=" + IpAdrress + ":" + Port + " certhash=" + thumbPrint + " appid={" + appId + "}";
                ProcessStartInfo psi = new ProcessStartInfo("netsh", query);
                psi.Verb = "runas";
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.UseShellExecute = true;
                Process.Start(psi).WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DeRegisterUri(String IpAdrress, String Port)
        {
            try
            {
                string query = "http delete sslcert ipport=" + IpAdrress + ":" + Port;
                ProcessStartInfo psi = new ProcessStartInfo("netsh", query);
                psi.Verb = "runas";
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.UseShellExecute = true;
                Process.Start(psi).WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Dictionary<string, string> GetConfiguration()
        {
            var configLines = File.ReadAllLines("config.txt");
            Dictionary<string, string> res = new Dictionary<string, string>();

            foreach (var line in configLines)
            {
                var comps = line.Split(new[] { '>' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.Trim()).ToArray();
                if (!res.Keys.Contains(comps.ElementAt(0)))
                {
                    res.Add(comps.ElementAt(0), comps.ElementAt(1));
                }
            }
            return res;
        }
        public static bool AddDomainToHost()
        {
            try
            {
                Dictionary<string, string> _hostsConf = GetConfiguration();
                var hostsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
                var hostsConf = File.ReadAllText(hostsFilePath);
                StringBuilder builder = new StringBuilder(hostsConf.Substring(0, hostsConf.LastIndexOf('#')));
                builder.AppendLine("#");
                builder.AppendLine();
                builder.AppendLine();
                foreach (var host in _hostsConf.Keys)
                {
                    builder.AppendLine($"127.0.0.1 {host}");
                }
                File.WriteAllText(hostsFilePath, builder.ToString());
                return true;
            }
            catch (Exception ex)
            {
                MainFrm.shared.openMessageBox(ex.Message);
                return false;
            }
        }
        public static bool RemoveDomainToHost()
        {
            try
            {
                var hostsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
                var hostsConf = File.ReadAllText(hostsFilePath);
                StringBuilder builder = new StringBuilder(hostsConf.Substring(0, hostsConf.LastIndexOf('#')));
                builder.AppendLine("#");
                builder.AppendLine();
                File.WriteAllText(hostsFilePath, builder.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
