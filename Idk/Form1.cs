using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Runtime.InteropServices;

namespace Idk
{
    public partial class Form1 : Form
    {   //SalwyrrVariable
        string SalwyrrFile = "Salwyrr.jar";
        string SalwyrrFolder = @"Data\Salwyrr";
        string SalwyrrGamePath = @"Data\Salwyrr\Salwyrr.jar";
        string SalwyrrLink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FSalwyrr%20Minecraft%20Launcher%204.jar?alt=media&token=0926749a-48b5-4f06-b612-ee00af8a743d";
        //LunarVariable
        string lunarzip = @"lunar.zip";
        string lunarfolder = @"Data\lunar";
        string lunargame = @"Data\lunar\Lunar Client.exe";
        string lunarlink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2Flunar.zip?alt=media&token=58c6f2e4-9854-4497-91e6-f83ce682fd19";
        //BadlionVariable
        string badlionzip = @"badlion.zip";
        string badlionfolder = @"Data\Badlion";
        string badliongame = @"Data\Badlion\Badlion Client.exe";
        string badlionlink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FBadlion%20Client.zip?alt=media&token=0f0717e9-8057-40ec-b9d2-bfb90922f249";
        //Other
        string ErrorReinstall = "Cannot reinstall because is noytinstalled ! Please install the client and reinstall it if there are a problem with the launcher";
        string ReinstallSucces = "This has been uninstall. Redownload on progress...";
        string rootfolder = @"Data";
        string AlreadyExist = "Hey ! You have already the Launcher installed. Opening the launcher !";
        string DownloadFinishZipMSG = "The download has benn terminated. Unzipping the file...";
        string DeleteZipMSG = "Deleting the zip file...";
        string allthingFinish = "The file has been deleted. Opening the launcher";
        string DeleteGood = "All Client has been unistalled. You can reinstall all :)";
        string DeleteNotGood = "Why did you press this button if the folder doesn't exists. You can stupid";
        string na = "na";
        string infoD = "https://github.com/yannje/AllMinecraftLauncher/releases/download/About/About.the.creator.exe";
        //DDL(idk)

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public Form1()
        {
            InitializeComponent();
            SettingsPanel.Visible = false;
            InfoBox.Visible = false;
            ReinstallPanel.Visible = false;


            if (!Directory.Exists(rootfolder))
            {
                Directory.CreateDirectory(rootfolder);
            }

        }

        //Download Client Part
        private void DownloadBNT_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();

            if (File.Exists(SalwyrrGamePath))
            {
                Client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(SalwyrrGamePath);
                DownloadBNT.Text = "Open Salwyrr";
            }
            else
            {
                Client.DownloadFileAsync(new Uri(SalwyrrLink), SalwyrrFile);
                Client.DownloadFileCompleted += Client_DownloadFileCompleted;
                Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            TotalLabel.Text = string.Format("{0}",(e.BytesReceived / 1024d / 1024d).ToString("0.00"));
            SpeedLabel.Text = string.Format("{0}",(e.TotalBytesToReceive/ 1024d / 1024d).ToString("0.00"));
            pourcentageLabel.Text = string.Format("{0}%",(e.ProgressPercentage / 1024d/ 1024).ToString("0.00"));

            panel1.Visible = false;
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Directory.CreateDirectory(SalwyrrFolder);
            File.Move("Salwyrr.jar", @"Data\Salwyrr\SalWyrr.jar");
            MessageBox.Show("Download Completed ! Launching the game");
            panel1.Visible = true;
            Process.Start(SalwyrrGamePath);
            DownloadBNT.Text = "Open Salwyrr";
        }

        private void LunarBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (File.Exists(lunargame))
            {
                client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(lunargame);
                
            }else
            {
                client.DownloadFileAsync(new Uri(lunarlink),lunarzip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted1;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
        }


        private void Client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        { 
            Directory.CreateDirectory(lunarfolder);
            MessageBox.Show(DownloadFinishZipMSG);
            ZipFile.ExtractToDirectory(lunarzip, lunarfolder);
            MessageBox.Show(DeleteZipMSG);
            File.Delete(lunarzip);
            MessageBox.Show(allthingFinish);
            panel1.Visible = true;
            Process.Start(lunargame);
        }

        private void BadlionBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (File.Exists(badliongame))
            {
                client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(badliongame);
            }
            else
            {
                client.DownloadFileAsync(new Uri(badlionlink), badlionzip);
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted2;
            }
        }

        private void Client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show(DownloadFinishZipMSG);
            ZipFile.ExtractToDirectory(badlionzip, badlionfolder);
            MessageBox.Show(DeleteZipMSG);
            File.Delete(badlionzip);
            panel1.Visible = true;
            MessageBox.Show(allthingFinish);
            Process.Start(badliongame);
        }

        // Reinstall Part
        private void ReinstallSalwyrrBTN_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();

            if (File.Exists(Path.Combine(SalwyrrFolder, SalwyrrFile)))
            {
                File.Delete(Path.Combine(SalwyrrFolder, SalwyrrFile));
                MessageBox.Show(ReinstallSucces);

                Client.DownloadFileCompleted += Client_DownloadFileCompleted;
                Client.DownloadProgressChanged += Client_DownloadProgressChanged;
                Client.DownloadFileAsync(new Uri(SalwyrrLink), SalwyrrFile);
            }else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }

        private void ReinstallLunarBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (Directory.Exists(lunarfolder))
            {
                Directory.Delete(lunarfolder, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(lunarlink), lunarzip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted1;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;

            }
            else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }

        private void ReinstallBadlionBTN_Click(object sender, EventArgs e)
        { WebClient client = new WebClient();

            if(Directory.Exists(badlionfolder))
            {
                Directory.Delete(ReinstallSucces, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(badlionlink), badlionzip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted2;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            } else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }

        // Settings

        private void button1_Click(object sender, EventArgs e)
        {
            ReinstallPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReinstallPanel.Visible = false;
        }

        private void UICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DoCheckedUI();
        }

        private void DoCheckedUI()
        {
            UIbox.Visible = UICheckBox.Checked;
            pourcentageLabel.Visible = UICheckBox.Checked;
        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
        }

        private void ExitSettings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }

        private void ProgressBArShowBTN_CheckedChanged(object sender, EventArgs e)
        {
            DoChecked();

        }

        private void DoChecked()
        {
            progressBar.Visible = ProgressBArShowBTN.Checked;
            TotalDecompressProgressBar.Visible = ProgressBArShowBTN.Checked;
            ExtractLabel.Visible = ProgressBArShowBTN.Checked;
        }

        private void InfoBTN_Click(object sender, EventArgs e)
        {
            InfoBox.Visible = true;
        }

        private void ExitInfoBTN_Click(object sender, EventArgs e)
        {
            InfoBox.Visible = false;
        }

        private void DeleteAllBTN_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(rootfolder))
            {
                MessageBox.Show(DeleteNotGood);
            }else
            {
                Directory.Delete(rootfolder, true);
                MessageBox.Show(DeleteGood);
            }
        }
      

        private void LanguageChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LanguageChanger.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;

                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hmmmmm. Do you have internet ? I will verify this");
            int Desc;
            MessageBox.Show(InternetGetConnectedState(out Desc, 0).ToString());
        }
        // Launcher Soon Part
        private void LauncherSoon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(na);
        }

        private void LauncherSoon3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(na);
        }

        private void LauncherSoon2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(na);
        }

        private void LauncherSoon4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(na);
        }

        private void LauncherSoon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(na);
        }

        private void OwnerBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (File.Exists("About.exe"))
            {
                Process.Start("about.exe");
            }else
            {
                client.DownloadFileAsync(new Uri(infoD), "About.exe");
                Process.Start("about.exe");
            }
           
        }
    }
}
