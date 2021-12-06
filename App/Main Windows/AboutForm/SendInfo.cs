using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Main_Windows.AboutForm
{
    class SendInfo
    {
        [SecurityCritical]
        [DllImport("ntdll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int RtlGetVersion(ref OSVERSIONINFOEX versionInfo);
        [StructLayout(LayoutKind.Sequential)]
        internal struct OSVERSIONINFOEX
        {
            internal int OSVersionInfoSize;
            internal int MajorVersion;
            internal int MinorVersion;
            internal int BuildNumber;
            internal int PlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            internal string CSDVersion;
            internal ushort ServicePackMajor;
            internal ushort ServicePackMinor;
            internal short SuiteMask;
            internal byte ProductType;
            internal byte Reserved;
        }

        public static (bool, string) SendFeedback(string feedback)
        {
            GetVersionOS();
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                string userName = GenerateSHA256(Environment.UserName);
                message.From = new MailAddress("DariusVirus1122@gmail.com");
                message.To.Add(new MailAddress("DariusVirus1122@gmail.com"));
                message.Subject = String.Format("{0} {1}", "Feedback user:", userName.Substring(0, 8));
                message.Body = String.Format(
                    "Machine name: {0}\n" +
                    "User name: {1}\n" +
                    "OSVersion: {2}\n" +
                    "Version Software: {3}\n" +
                    "Feedback: <{4}\n" +
                    "Time Send: {5}",
                    Environment.MachineName,
                    userName,
                    GetVersionOS(),
                    "1.0.0",
                    feedback,
                    DateTime.UtcNow.ToString("HH:mm:ss dd/MM/yyyy UTC")
                    );

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //Cái này mã hóa trong json chắc được. Đang test thôi
                smtp.Credentials = new NetworkCredential("DariusVirus1122@gmail.com", "*************");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
            return (true, null);
        }

        public static string GenerateSHA256(string rawData)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string GetVersionOS()
        {
            var osVersionInfo = new OSVERSIONINFOEX { OSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX)) };
            RtlGetVersion(ref osVersionInfo);
            return String.Format("Windows {0}.{1} Build {2}", osVersionInfo.MajorVersion, osVersionInfo.MinorVersion, osVersionInfo.BuildNumber);
        }
    }
}
