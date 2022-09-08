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
        //tlauncherVariable
        string TlauncherGame = @"Data\Tlauncher\Tlauncher.exe";
        string TlauncherLink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FTLauncher.exe?alt=media&token=988d6eba-b592-4e2e-a061-4b5d4eccc497";
        string TlauncherName = "Tlauncher.exe";
        string TlauncherFolder = @"Data\Tlauncher";
        //PalaVariable
        string PalaGame = @"Data\Pala\paladium-group.exe";
        string PalaFolder = @"Data\Pala";
        string PalaLink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2Fpaladium-group.zip?alt=media&token=8919faf8-9fb9-49fc-b9ba-3bc8f4d27d32";
        String PalaZip = "pala.zip";
        //AzVariable
        string AzGame = @"Data\AZ\AZ-Launcher.exe";
        string AzLink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FAZ-Launcher.zip?alt=media&token=bdc1acd8-5f7a-4db2-9ebb-7d48bf3ca0e4";
        string AzZip = "Az.zip";
        string AzFolder = @"Data\AZ";
        //MicraftVariable
        string MincraftGame = @"Data\Minecraft\MinecraftLauncher.exe";
        string MicraftFolder = @"Data\Minecraft";
        String MicraftZip = "Micraft.zip";
        string MincraftLink = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FMinecraft%20Launcher.zip?alt=media&token=cf8b0639-5222-48d0-913e-113c641e090b";
        //Other
        string ErrorReinstall = "Cannot reinstall because is not installed ! Please install the client and reinstall it if there are a problem with the launcher";
        string ReinstallSucces = "This has been uninstall. Redownload on progress...";
        string rootfolder = @"Data";
        string AlreadyExist = "Hey ! You have already the Launcher installed. Opening the launcher !";
        string DownloadFinishZipMSG = "The download has benn terminated. Unzipping the file...";
        string DeleteZipMSG = "Deleting the zip file...";
        string allthingFinish = "The file has been deleted. Opening the launcher";
        string DeleteGood = "All Client has been unistalled. You can reinstall all :)";
        string DeleteNotGood = "Why did you press this button if the folder doesn't exists. You stupid";
        string na = "na";
        string infoD = "https://firebasestorage.googleapis.com/v0/b/piochyserv.appspot.com/o/AllMinecraftLauncher%2FAbout%20the%20creator.exe?alt=media&token=b375dd50-e8d5-4133-93a7-095869b17db6";
        string FileMoveDone = "The file has been move. Openning the launcher";
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

            if (Directory.Exists(SalwyrrFolder))
            {
                DownloadBNT.Text = "Open Salwyrr";
            }

            if (Directory.Exists(lunarfolder))
            {
                LunarBTN.Text = "Open Lunar";
            }

            if (Directory.Exists(badlionfolder))
            {
                BadlionBTN.Text = "Open BadLion";
            }

            if (Directory.Exists(TlauncherFolder))
            {
                TlauncherBTN.Text = "Open Tlauncher";
            }

            if (Directory.Exists(PalaFolder))
            {
                PalaBTN.Text = "Open Paladium(FR)";
            }
            
            if (Directory.Exists(AzFolder))
            {
                AzBTN.Text = "Open AzLauncher";
            }

            if (Directory.Exists(MicraftFolder))
            {
                MicraftBTN.Text = "Open MinecraftLauncher";
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
            LunarBTN.Text = "Open Lunar";
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
            BadlionBTN.Text ="Open Badlion";
        }

        private void TlauncherBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (File.Exists(@"Data\Tlauncher\Tlauncher.exe"))
            {
                MessageBox.Show(AlreadyExist);
                Process.Start(@"Data\Tlauncher\Tlauncher.exe");
            }
            else
            {
                client.DownloadFileAsync(new Uri(TlauncherLink), TlauncherName);
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted3;
            }

        }

        private void Client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            Directory.CreateDirectory(TlauncherFolder);
            File.Move("Tlauncher.exe", @"Data\Tlauncher\Tlauncher.exe");
            MessageBox.Show(FileMoveDone);
            Process.Start(TlauncherGame);
            TlauncherBTN.Text ="Open Tlauncher";
        }

        private void PalaBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (File.Exists(PalaGame))
            {
                client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(PalaGame);
            }
            else
            {
                client.DownloadFileAsync(new Uri(PalaLink), PalaZip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted4;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }

        }

        private void Client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show(DownloadFinishZipMSG);
            ZipFile.ExtractToDirectory(PalaZip, PalaFolder);
            MessageBox.Show(DeleteZipMSG);
            File.Delete(PalaZip);
            panel1.Visible = true;
            MessageBox.Show(allthingFinish);
            Process.Start(PalaGame);
            PalaBTN.Text = "Open Paladium(FR)";
        }

        private void AzBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (File.Exists(AzGame))
            {
                client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(AzGame);
            }
            else
            {
                client.DownloadFileAsync(new Uri(AzLink), AzZip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted5;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
            
        }

        private void Client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            Directory.CreateDirectory(AzFolder);
            MessageBox.Show(DownloadFinishZipMSG);
            ZipFile.ExtractToDirectory(AzZip, AzFolder);
            MessageBox.Show(DeleteZipMSG);
            File.Delete(AzZip);
            panel1.Visible = true;
            MessageBox.Show(allthingFinish);
            Process.Start(AzGame);
            AzBTN.Text ="Open AzLauncher";
        }

        private void MicraftBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (File.Exists(MincraftGame))
            {
                client.CancelAsync();
                MessageBox.Show(AlreadyExist);
                Process.Start(MincraftGame);
            }
            else
            {
                client.DownloadFileAsync(new Uri(MincraftLink), MicraftZip);
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted6;
            }
           
        }

        private void Client_DownloadFileCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            Directory.CreateDirectory(MicraftFolder);
            MessageBox.Show(DownloadFinishZipMSG);
            ZipFile.ExtractToDirectory(MicraftZip, MicraftFolder);
            MessageBox.Show(DeleteZipMSG);
            File.Delete(MicraftZip);
            panel1.Visible = true;
            MessageBox.Show(allthingFinish);
            Process.Start(MincraftGame);
            MicraftBTN.Text = "Open MinecraftLauncher";
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

        private void ReinstallTlauncherBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (Directory.Exists(TlauncherFolder))
            {
                Directory.Delete(ReinstallSucces, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(TlauncherLink), "Tlauncher.exe");
                client.DownloadFileCompleted += Client_DownloadFileCompleted3;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
            else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }
    
        private void ReinstallPalaBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (Directory.Exists(badlionfolder))
            {
                Directory.Delete(ReinstallSucces, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(PalaLink), PalaZip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted4;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
            else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }

        private void ReinstallBTNAz_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (Directory.Exists(AzFolder))
            {
                Directory.Delete(ReinstallSucces, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(AzLink), AzZip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted5;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
            else
            {
                MessageBox.Show(ErrorReinstall);
            }
        }
        private void ReinstallMicraftBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            if (Directory.Exists(MicraftZip))
            {
                Directory.Delete(ReinstallSucces, true);
                MessageBox.Show(ReinstallSucces);
                client.DownloadFileAsync(new Uri(MincraftLink), MicraftZip);
                client.DownloadFileCompleted += Client_DownloadFileCompleted6;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
            }
            else
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
        private void OwnerBTN_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            if (File.Exists("About.exe"))
            {
                Process.Start("about.exe");
            }else
            {
                client.DownloadFile(infoD, "about.exe");
                Process.Start("about.exe");
            }
           
        }
    }
}
