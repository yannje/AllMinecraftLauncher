namespace Idk
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DownloadBNT = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.pourcentageLabel = new System.Windows.Forms.Label();
            this.LunarBTN = new System.Windows.Forms.Button();
            this.TlauncherBTN = new System.Windows.Forms.Button();
            this.BadlionBTN = new System.Windows.Forms.Button();
            this.PalaBTN = new System.Windows.Forms.Button();
            this.SettingsBTN = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.GroupBox();
            this.button_3 = new System.Windows.Forms.Button();
            this.LanguageChanger = new System.Windows.Forms.ComboBox();
            this.UICheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoBTN = new System.Windows.Forms.Button();
            this.ExitSettings = new System.Windows.Forms.Button();
            this.ProgressBArShowBTN = new System.Windows.Forms.CheckBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.ExitInfoBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LauncherSoon4 = new System.Windows.Forms.Button();
            this.LauncherSoon3 = new System.Windows.Forms.Button();
            this.LauncherSoon2 = new System.Windows.Forms.Button();
            this.LauncherSoon1 = new System.Windows.Forms.Button();
            this.LauncherSoon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReinstallPanel = new System.Windows.Forms.GroupBox();
            this.DeleteAllBTN = new System.Windows.Forms.Button();
            this.ReinstallPalaBTN = new System.Windows.Forms.Button();
            this.ReinstallTlauncherBTN = new System.Windows.Forms.Button();
            this.ReinstallBadlionBTN = new System.Windows.Forms.Button();
            this.ReinstallLunarBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ReinstallSalwyrrBTN = new System.Windows.Forms.Button();
            this.UIbox = new System.Windows.Forms.GroupBox();
            this.TotalDecompressProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExtractLabel = new System.Windows.Forms.Label();
            this.OwnerBTN = new System.Windows.Forms.Button();
            this.SettingsPanel.SuspendLayout();
            this.InfoBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReinstallPanel.SuspendLayout();
            this.UIbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadBNT
            // 
            this.DownloadBNT.BackColor = System.Drawing.SystemColors.Control;
            this.DownloadBNT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DownloadBNT.FlatAppearance.BorderSize = 30;
            this.DownloadBNT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownloadBNT.Location = new System.Drawing.Point(47, 15);
            this.DownloadBNT.Name = "DownloadBNT";
            this.DownloadBNT.Size = new System.Drawing.Size(135, 23);
            this.DownloadBNT.TabIndex = 0;
            this.DownloadBNT.Text = "Installer Salwyrr";
            this.DownloadBNT.UseVisualStyleBackColor = false;
            this.DownloadBNT.Click += new System.EventHandler(this.DownloadBNT_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(134, 18);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(487, 23);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Téléchargé :";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(4, 37);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(76, 13);
            this.Speed.TabIndex = 3;
            this.Speed.Text = "A télécharger :";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(86, 37);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(32, 13);
            this.SpeedLabel.TabIndex = 4;
            this.SpeedLabel.Text = "0 MB";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(86, 16);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(32, 13);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "0 MB";
            // 
            // pourcentageLabel
            // 
            this.pourcentageLabel.AutoSize = true;
            this.pourcentageLabel.Location = new System.Drawing.Point(638, 28);
            this.pourcentageLabel.Name = "pourcentageLabel";
            this.pourcentageLabel.Size = new System.Drawing.Size(21, 13);
            this.pourcentageLabel.TabIndex = 6;
            this.pourcentageLabel.Text = "0%";
            // 
            // LunarBTN
            // 
            this.LunarBTN.BackColor = System.Drawing.SystemColors.Control;
            this.LunarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LunarBTN.Location = new System.Drawing.Point(188, 15);
            this.LunarBTN.Name = "LunarBTN";
            this.LunarBTN.Size = new System.Drawing.Size(134, 23);
            this.LunarBTN.TabIndex = 7;
            this.LunarBTN.Text = "Installer Lunar";
            this.LunarBTN.UseVisualStyleBackColor = false;
            this.LunarBTN.Click += new System.EventHandler(this.LunarBTN_Click);
            // 
            // TlauncherBTN
            // 
            this.TlauncherBTN.BackColor = System.Drawing.SystemColors.Control;
            this.TlauncherBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TlauncherBTN.Location = new System.Drawing.Point(466, 15);
            this.TlauncherBTN.Name = "TlauncherBTN";
            this.TlauncherBTN.Size = new System.Drawing.Size(134, 23);
            this.TlauncherBTN.TabIndex = 8;
            this.TlauncherBTN.Text = "Installer Tlauncher";
            this.TlauncherBTN.UseVisualStyleBackColor = false;
            // 
            // BadlionBTN
            // 
            this.BadlionBTN.BackColor = System.Drawing.SystemColors.Control;
            this.BadlionBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BadlionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BadlionBTN.Location = new System.Drawing.Point(606, 15);
            this.BadlionBTN.Name = "BadlionBTN";
            this.BadlionBTN.Size = new System.Drawing.Size(134, 23);
            this.BadlionBTN.TabIndex = 9;
            this.BadlionBTN.Text = "Installer Badlion";
            this.BadlionBTN.UseVisualStyleBackColor = false;
            this.BadlionBTN.Click += new System.EventHandler(this.BadlionBTN_Click);
            // 
            // PalaBTN
            // 
            this.PalaBTN.BackColor = System.Drawing.SystemColors.Control;
            this.PalaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PalaBTN.Location = new System.Drawing.Point(328, 15);
            this.PalaBTN.Name = "PalaBTN";
            this.PalaBTN.Size = new System.Drawing.Size(134, 23);
            this.PalaBTN.TabIndex = 10;
            this.PalaBTN.Text = "Installer Paladuim(FR)";
            this.PalaBTN.UseVisualStyleBackColor = false;
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBTN.Location = new System.Drawing.Point(682, 23);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(94, 23);
            this.SettingsBTN.TabIndex = 11;
            this.SettingsBTN.Text = "Paramètres";
            this.SettingsBTN.UseVisualStyleBackColor = false;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.OwnerBTN);
            this.SettingsPanel.Controls.Add(this.button_3);
            this.SettingsPanel.Controls.Add(this.LanguageChanger);
            this.SettingsPanel.Controls.Add(this.UICheckBox);
            this.SettingsPanel.Controls.Add(this.button1);
            this.SettingsPanel.Controls.Add(this.InfoBTN);
            this.SettingsPanel.Controls.Add(this.ExitSettings);
            this.SettingsPanel.Controls.Add(this.ProgressBArShowBTN);
            this.SettingsPanel.Location = new System.Drawing.Point(220, 69);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(276, 100);
            this.SettingsPanel.TabIndex = 12;
            this.SettingsPanel.TabStop = false;
            this.SettingsPanel.Text = "Paramètre";
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.Control;
            this.button_3.Location = new System.Drawing.Point(122, 72);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(75, 23);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "Secret";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LanguageChanger
            // 
            this.LanguageChanger.FormattingEnabled = true;
            this.LanguageChanger.Items.AddRange(new object[] {
            "French",
            "English"});
            this.LanguageChanger.Location = new System.Drawing.Point(191, 44);
            this.LanguageChanger.Name = "LanguageChanger";
            this.LanguageChanger.Size = new System.Drawing.Size(71, 21);
            this.LanguageChanger.TabIndex = 5;
            this.LanguageChanger.SelectedIndexChanged += new System.EventHandler(this.LanguageChanger_SelectedIndexChanged);
            // 
            // UICheckBox
            // 
            this.UICheckBox.AutoSize = true;
            this.UICheckBox.Checked = true;
            this.UICheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UICheckBox.Location = new System.Drawing.Point(-1, 44);
            this.UICheckBox.Name = "UICheckBox";
            this.UICheckBox.Size = new System.Drawing.Size(74, 17);
            this.UICheckBox.TabIndex = 4;
            this.UICheckBox.Text = "Voir les UI";
            this.UICheckBox.UseVisualStyleBackColor = true;
            this.UICheckBox.CheckedChanged += new System.EventHandler(this.UICheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(198, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Réinstaller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoBTN
            // 
            this.InfoBTN.BackColor = System.Drawing.SystemColors.Control;
            this.InfoBTN.Location = new System.Drawing.Point(2, 72);
            this.InfoBTN.Name = "InfoBTN";
            this.InfoBTN.Size = new System.Drawing.Size(118, 23);
            this.InfoBTN.TabIndex = 2;
            this.InfoBTN.Text = "Info appli";
            this.InfoBTN.UseVisualStyleBackColor = false;
            this.InfoBTN.Click += new System.EventHandler(this.InfoBTN_Click);
            // 
            // ExitSettings
            // 
            this.ExitSettings.BackColor = System.Drawing.SystemColors.Control;
            this.ExitSettings.Location = new System.Drawing.Point(230, 11);
            this.ExitSettings.Name = "ExitSettings";
            this.ExitSettings.Size = new System.Drawing.Size(32, 23);
            this.ExitSettings.TabIndex = 1;
            this.ExitSettings.Text = "X";
            this.ExitSettings.UseVisualStyleBackColor = false;
            this.ExitSettings.Click += new System.EventHandler(this.ExitSettings_Click);
            // 
            // ProgressBArShowBTN
            // 
            this.ProgressBArShowBTN.AutoSize = true;
            this.ProgressBArShowBTN.Checked = true;
            this.ProgressBArShowBTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProgressBArShowBTN.Location = new System.Drawing.Point(-1, 20);
            this.ProgressBArShowBTN.Name = "ProgressBArShowBTN";
            this.ProgressBArShowBTN.Size = new System.Drawing.Size(160, 17);
            this.ProgressBArShowBTN.TabIndex = 0;
            this.ProgressBArShowBTN.Text = "Afficher les bars de Progress";
            this.ProgressBArShowBTN.UseVisualStyleBackColor = true;
            this.ProgressBArShowBTN.CheckedChanged += new System.EventHandler(this.ProgressBArShowBTN_CheckedChanged);
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.ExitInfoBTN);
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label3);
            this.InfoBox.Controls.Add(this.label2);
            this.InfoBox.Location = new System.Drawing.Point(14, 70);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(200, 100);
            this.InfoBox.TabIndex = 13;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Info de l\'app";
            // 
            // ExitInfoBTN
            // 
            this.ExitInfoBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitInfoBTN.Location = new System.Drawing.Point(160, 10);
            this.ExitInfoBTN.Name = "ExitInfoBTN";
            this.ExitInfoBTN.Size = new System.Drawing.Size(32, 23);
            this.ExitInfoBTN.TabIndex = 3;
            this.ExitInfoBTN.Text = "X";
            this.ExitInfoBTN.UseVisualStyleBackColor = false;
            this.ExitInfoBTN.Click += new System.EventHandler(this.ExitInfoBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Version : 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author : da yannje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "App : AllMinecraftLauncher";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.LauncherSoon4);
            this.panel1.Controls.Add(this.LauncherSoon3);
            this.panel1.Controls.Add(this.LauncherSoon2);
            this.panel1.Controls.Add(this.LauncherSoon1);
            this.panel1.Controls.Add(this.LauncherSoon);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DownloadBNT);
            this.panel1.Controls.Add(this.LunarBTN);
            this.panel1.Controls.Add(this.PalaBTN);
            this.panel1.Controls.Add(this.TlauncherBTN);
            this.panel1.Controls.Add(this.BadlionBTN);
            this.panel1.Location = new System.Drawing.Point(4, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 129);
            this.panel1.TabIndex = 14;
            // 
            // LauncherSoon4
            // 
            this.LauncherSoon4.BackColor = System.Drawing.SystemColors.Control;
            this.LauncherSoon4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LauncherSoon4.FlatAppearance.BorderSize = 30;
            this.LauncherSoon4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LauncherSoon4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherSoon4.Location = new System.Drawing.Point(606, 57);
            this.LauncherSoon4.Name = "LauncherSoon4";
            this.LauncherSoon4.Size = new System.Drawing.Size(134, 23);
            this.LauncherSoon4.TabIndex = 20;
            this.LauncherSoon4.Text = "Launcher Prochainement";
            this.LauncherSoon4.UseVisualStyleBackColor = false;
            this.LauncherSoon4.Click += new System.EventHandler(this.LauncherSoon4_Click);
            // 
            // LauncherSoon3
            // 
            this.LauncherSoon3.BackColor = System.Drawing.SystemColors.Control;
            this.LauncherSoon3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LauncherSoon3.FlatAppearance.BorderSize = 30;
            this.LauncherSoon3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LauncherSoon3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherSoon3.Location = new System.Drawing.Point(466, 57);
            this.LauncherSoon3.Name = "LauncherSoon3";
            this.LauncherSoon3.Size = new System.Drawing.Size(134, 23);
            this.LauncherSoon3.TabIndex = 19;
            this.LauncherSoon3.Text = "Launcher Prochainement";
            this.LauncherSoon3.UseVisualStyleBackColor = false;
            this.LauncherSoon3.Click += new System.EventHandler(this.LauncherSoon3_Click);
            // 
            // LauncherSoon2
            // 
            this.LauncherSoon2.BackColor = System.Drawing.SystemColors.Control;
            this.LauncherSoon2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LauncherSoon2.FlatAppearance.BorderSize = 30;
            this.LauncherSoon2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LauncherSoon2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherSoon2.Location = new System.Drawing.Point(328, 57);
            this.LauncherSoon2.Name = "LauncherSoon2";
            this.LauncherSoon2.Size = new System.Drawing.Size(134, 23);
            this.LauncherSoon2.TabIndex = 18;
            this.LauncherSoon2.Text = "Launcher Prochainement";
            this.LauncherSoon2.UseVisualStyleBackColor = false;
            this.LauncherSoon2.Click += new System.EventHandler(this.LauncherSoon2_Click);
            // 
            // LauncherSoon1
            // 
            this.LauncherSoon1.BackColor = System.Drawing.SystemColors.Control;
            this.LauncherSoon1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LauncherSoon1.FlatAppearance.BorderSize = 30;
            this.LauncherSoon1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LauncherSoon1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherSoon1.Location = new System.Drawing.Point(188, 57);
            this.LauncherSoon1.Name = "LauncherSoon1";
            this.LauncherSoon1.Size = new System.Drawing.Size(134, 23);
            this.LauncherSoon1.TabIndex = 17;
            this.LauncherSoon1.Text = "Launcher Prochainement";
            this.LauncherSoon1.UseVisualStyleBackColor = false;
            this.LauncherSoon1.Click += new System.EventHandler(this.LauncherSoon1_Click);
            // 
            // LauncherSoon
            // 
            this.LauncherSoon.BackColor = System.Drawing.SystemColors.Control;
            this.LauncherSoon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LauncherSoon.FlatAppearance.BorderSize = 30;
            this.LauncherSoon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LauncherSoon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherSoon.Location = new System.Drawing.Point(47, 57);
            this.LauncherSoon.Name = "LauncherSoon";
            this.LauncherSoon.Size = new System.Drawing.Size(135, 23);
            this.LauncherSoon.TabIndex = 16;
            this.LauncherSoon.Text = "Launcher Prochainement";
            this.LauncherSoon.UseVisualStyleBackColor = false;
            this.LauncherSoon.Click += new System.EventHandler(this.LauncherSoon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "X64/X86";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "X64/X86";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X64/X86";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X64";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X64";
            // 
            // ReinstallPanel
            // 
            this.ReinstallPanel.Controls.Add(this.DeleteAllBTN);
            this.ReinstallPanel.Controls.Add(this.ReinstallPalaBTN);
            this.ReinstallPanel.Controls.Add(this.ReinstallTlauncherBTN);
            this.ReinstallPanel.Controls.Add(this.ReinstallBadlionBTN);
            this.ReinstallPanel.Controls.Add(this.ReinstallLunarBTN);
            this.ReinstallPanel.Controls.Add(this.button2);
            this.ReinstallPanel.Controls.Add(this.ReinstallSalwyrrBTN);
            this.ReinstallPanel.Location = new System.Drawing.Point(502, 70);
            this.ReinstallPanel.Name = "ReinstallPanel";
            this.ReinstallPanel.Size = new System.Drawing.Size(274, 100);
            this.ReinstallPanel.TabIndex = 15;
            this.ReinstallPanel.TabStop = false;
            this.ReinstallPanel.Text = "Réinstaller";
            // 
            // DeleteAllBTN
            // 
            this.DeleteAllBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteAllBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAllBTN.Location = new System.Drawing.Point(139, 71);
            this.DeleteAllBTN.Name = "DeleteAllBTN";
            this.DeleteAllBTN.Size = new System.Drawing.Size(122, 23);
            this.DeleteAllBTN.TabIndex = 14;
            this.DeleteAllBTN.Text = "Tout Désintaller";
            this.DeleteAllBTN.UseVisualStyleBackColor = false;
            this.DeleteAllBTN.Click += new System.EventHandler(this.DeleteAllBTN_Click);
            // 
            // ReinstallPalaBTN
            // 
            this.ReinstallPalaBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ReinstallPalaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReinstallPalaBTN.Location = new System.Drawing.Point(3, 71);
            this.ReinstallPalaBTN.Name = "ReinstallPalaBTN";
            this.ReinstallPalaBTN.Size = new System.Drawing.Size(131, 23);
            this.ReinstallPalaBTN.TabIndex = 11;
            this.ReinstallPalaBTN.Text = "Réinstaller Paladuim(FR)";
            this.ReinstallPalaBTN.UseVisualStyleBackColor = false;
            // 
            // ReinstallTlauncherBTN
            // 
            this.ReinstallTlauncherBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ReinstallTlauncherBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReinstallTlauncherBTN.Location = new System.Drawing.Point(116, 46);
            this.ReinstallTlauncherBTN.Name = "ReinstallTlauncherBTN";
            this.ReinstallTlauncherBTN.Size = new System.Drawing.Size(114, 23);
            this.ReinstallTlauncherBTN.TabIndex = 11;
            this.ReinstallTlauncherBTN.Text = "RéinstallerTlauncher";
            this.ReinstallTlauncherBTN.UseVisualStyleBackColor = false;
            // 
            // ReinstallBadlionBTN
            // 
            this.ReinstallBadlionBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ReinstallBadlionBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReinstallBadlionBTN.FlatAppearance.BorderSize = 30;
            this.ReinstallBadlionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReinstallBadlionBTN.Location = new System.Drawing.Point(3, 46);
            this.ReinstallBadlionBTN.Name = "ReinstallBadlionBTN";
            this.ReinstallBadlionBTN.Size = new System.Drawing.Size(107, 23);
            this.ReinstallBadlionBTN.TabIndex = 13;
            this.ReinstallBadlionBTN.Text = "Réinstaller Badlion";
            this.ReinstallBadlionBTN.UseVisualStyleBackColor = false;
            this.ReinstallBadlionBTN.Click += new System.EventHandler(this.ReinstallBadlionBTN_Click);
            // 
            // ReinstallLunarBTN
            // 
            this.ReinstallLunarBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ReinstallLunarBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReinstallLunarBTN.FlatAppearance.BorderSize = 30;
            this.ReinstallLunarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReinstallLunarBTN.Location = new System.Drawing.Point(116, 20);
            this.ReinstallLunarBTN.Name = "ReinstallLunarBTN";
            this.ReinstallLunarBTN.Size = new System.Drawing.Size(113, 23);
            this.ReinstallLunarBTN.TabIndex = 12;
            this.ReinstallLunarBTN.Text = "Réinstaller Lunar";
            this.ReinstallLunarBTN.UseVisualStyleBackColor = false;
            this.ReinstallLunarBTN.Click += new System.EventHandler(this.ReinstallLunarBTN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(236, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReinstallSalwyrrBTN
            // 
            this.ReinstallSalwyrrBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ReinstallSalwyrrBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReinstallSalwyrrBTN.FlatAppearance.BorderSize = 30;
            this.ReinstallSalwyrrBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReinstallSalwyrrBTN.Location = new System.Drawing.Point(3, 20);
            this.ReinstallSalwyrrBTN.Name = "ReinstallSalwyrrBTN";
            this.ReinstallSalwyrrBTN.Size = new System.Drawing.Size(109, 23);
            this.ReinstallSalwyrrBTN.TabIndex = 11;
            this.ReinstallSalwyrrBTN.Text = "Réinstaller Salwyrr";
            this.ReinstallSalwyrrBTN.UseVisualStyleBackColor = false;
            this.ReinstallSalwyrrBTN.Click += new System.EventHandler(this.ReinstallSalwyrrBTN_Click);
            // 
            // UIbox
            // 
            this.UIbox.Controls.Add(this.label1);
            this.UIbox.Controls.Add(this.Speed);
            this.UIbox.Controls.Add(this.SpeedLabel);
            this.UIbox.Controls.Add(this.TotalLabel);
            this.UIbox.Location = new System.Drawing.Point(4, 12);
            this.UIbox.Name = "UIbox";
            this.UIbox.Size = new System.Drawing.Size(124, 59);
            this.UIbox.TabIndex = 16;
            this.UIbox.TabStop = false;
            // 
            // TotalDecompressProgressBar
            // 
            this.TotalDecompressProgressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalDecompressProgressBar.Location = new System.Drawing.Point(134, 47);
            this.TotalDecompressProgressBar.Name = "TotalDecompressProgressBar";
            this.TotalDecompressProgressBar.Size = new System.Drawing.Size(487, 23);
            this.TotalDecompressProgressBar.TabIndex = 17;
            // 
            // ExtractLabel
            // 
            this.ExtractLabel.AutoSize = true;
            this.ExtractLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExtractLabel.Location = new System.Drawing.Point(311, 52);
            this.ExtractLabel.Name = "ExtractLabel";
            this.ExtractLabel.Size = new System.Drawing.Size(54, 13);
            this.ExtractLabel.TabIndex = 18;
            this.ExtractLabel.Text = "Extraction";
            // 
            // OwnerBTN
            // 
            this.OwnerBTN.BackColor = System.Drawing.SystemColors.Control;
            this.OwnerBTN.Location = new System.Drawing.Point(94, 42);
            this.OwnerBTN.Name = "OwnerBTN";
            this.OwnerBTN.Size = new System.Drawing.Size(91, 23);
            this.OwnerBTN.TabIndex = 7;
            this.OwnerBTN.Text = "Les Createur";
            this.OwnerBTN.UseVisualStyleBackColor = false;
            this.OwnerBTN.Click += new System.EventHandler(this.OwnerBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(796, 317);
            this.Controls.Add(this.ExtractLabel);
            this.Controls.Add(this.TotalDecompressProgressBar);
            this.Controls.Add(this.UIbox);
            this.Controls.Add(this.ReinstallPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.SettingsBTN);
            this.Controls.Add(this.pourcentageLabel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Launcher";
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReinstallPanel.ResumeLayout(false);
            this.UIbox.ResumeLayout(false);
            this.UIbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadBNT;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label pourcentageLabel;
        private System.Windows.Forms.Button LunarBTN;
        private System.Windows.Forms.Button TlauncherBTN;
        private System.Windows.Forms.Button BadlionBTN;
        private System.Windows.Forms.Button PalaBTN;
        private System.Windows.Forms.Button SettingsBTN;
        private System.Windows.Forms.GroupBox SettingsPanel;
        private System.Windows.Forms.Button ExitSettings;
        private System.Windows.Forms.CheckBox ProgressBArShowBTN;
        private System.Windows.Forms.Button InfoBTN;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitInfoBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ReinstallPanel;
        private System.Windows.Forms.Button ReinstallSalwyrrBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox UICheckBox;
        private System.Windows.Forms.GroupBox UIbox;
        private System.Windows.Forms.Button ReinstallLunarBTN;
        private System.Windows.Forms.Button ReinstallPalaBTN;
        private System.Windows.Forms.Button ReinstallTlauncherBTN;
        private System.Windows.Forms.Button ReinstallBadlionBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar TotalDecompressProgressBar;
        private System.Windows.Forms.Label ExtractLabel;
        private System.Windows.Forms.Button DeleteAllBTN;
        private System.Windows.Forms.ComboBox LanguageChanger;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button LauncherSoon4;
        private System.Windows.Forms.Button LauncherSoon3;
        private System.Windows.Forms.Button LauncherSoon2;
        private System.Windows.Forms.Button LauncherSoon1;
        private System.Windows.Forms.Button LauncherSoon;
        private System.Windows.Forms.Button OwnerBTN;
    }
}

