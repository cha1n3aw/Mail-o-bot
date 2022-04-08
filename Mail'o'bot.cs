using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_o_bot
{
    public partial class MailBot : Form
    {
        private bool Run = false;
        private Thread thread;
        private DateTime ScheduledTime;
        RegistryKey AutostartOnBoot = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public string GenerateText(string _patterns)
        {
            Random rnd = new();
            if (Appeal.SelectedIndex == 0) while (_patterns.Contains("DstName")) _patterns = _patterns.Replace("DstName", DstName.Text);
            else if (Appeal.SelectedIndex == 1) while (_patterns.Contains("DstName")) _patterns = _patterns.Replace("DstName", "");
            else if (Introduce.SelectedIndex == 2)
            {
                int r = rnd.Next(0, 2);
                if (r == 0) while (_patterns.Contains("DstName")) _patterns = _patterns.Replace("DstName", "");
                else while (_patterns.Contains("DstName")) _patterns = _patterns.Replace("DstName", DstName.Text);
            }
            if (Introduce.SelectedIndex == 0) while (_patterns.Contains("SrcName")) _patterns = _patterns.Replace("SrcName", SrcName.Text);
            else if (Introduce.SelectedIndex == 1) while (_patterns.Contains("SrcName")) _patterns = _patterns.Replace("SrcName", "");
            else if (Introduce.SelectedIndex == 2)
            {
                int r = rnd.Next(0, 2);
                if (r == 0) while (_patterns.Contains("SrcName")) _patterns = _patterns.Replace("SrcName", "");
                else while (_patterns.Contains("SrcName")) _patterns = _patterns.Replace("SrcName", SrcName.Text);
            }
            List<List<List<string>>> patterns = new();
            List<string> templist1 = _patterns.Split('`', StringSplitOptions.RemoveEmptyEntries).ToList();
            int i;
            for (i = 0; i < templist1.Count; i++)
            {
                string[] temp2 = templist1[i].Split('*', StringSplitOptions.RemoveEmptyEntries);
                List<List<string>> templist2 = new();
                for (int j = 0; j < temp2.Length; j++)
                {
                    List<string> templist3 = temp2[j].Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
                    templist2.Add(templist3);
                }
                patterns.Add(templist2);
            }
            string message = string.Empty;
            i = rnd.Next(0, patterns.Count);
            for (int j = 0; j < patterns[i].Count; j++)
            {
                int k = rnd.Next(0, patterns[i][j].Count);
                if (patterns[i][j][k] != "-") message += patterns[i][j][k];
            }
            if (message.Length > 20)
            {
                while (message[0] == ' ' || message[0] == ',' || message.Contains("  ") || message.Contains(" ,") || message.Contains(",,") || message.Contains(" :") || message.Contains("\r\n,") || message.Contains("\r\n "))
                {
                    while (message.Contains("  ")) message = message.Replace("  ", " ");
                    while (message.Contains(" ,")) message = message.Replace(" ,", ",");
                    while (message.Contains(",,")) message = message.Replace(",,", ",");
                    while (message.Contains(" :")) message = message.Replace(" :", ":");
                    while (message.Contains("\r\n,")) message = message.Replace("\r\n,", "\r\n");
                    while (message.Contains("\r\n ")) message = message.Replace("\r\n ", "\r\n");
                    message = message.TrimStart('\r');
                    message = message.TrimStart('\n');
                    message = message.TrimStart(' ');
                    message = message.TrimStart(',');
                    message = message.TrimEnd('\n');
                    message = message.TrimEnd('\r');
                    message = message.TrimEnd(' ');
                    message = message.TrimEnd(',');
                }
                string tmp = string.Empty;
                foreach (string str in message.Split('\n', StringSplitOptions.RemoveEmptyEntries)) tmp += $"{string.Concat(str[0].ToString().ToUpper(), str.AsSpan(1))}\n";
                message = tmp;
            }
            return message;
        }

        private async Task SendMessage(string srcaddress, string pswd, string dstaddress, string subject, string body)
        {
            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(srcaddress, pswd)
            };
            MailMessage mailmessage = new(srcaddress, dstaddress)
            {
                Subject = subject,
                Body = body
            };
            await smtp.SendMailAsync(mailmessage);
        }

        private void GenerateAllFields()
        {
            if (IsHandleCreated) BeginInvoke(new MethodInvoker(delegate
            {
                Subject.Text = GenerateText(SubjectPatterns.Text);
                Body.Text = GenerateText(BodyPatterns.Text);
                while (Body.Text.Contains("ChangeLogs")) Body.Text = Body.Text.Replace("ChangeLogs", $"\r\n{ ChangeLogs.Text }");
            }));
        }

        public MailBot()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GenerateAllFields();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMessage(SrcAddress.Text, SrcPswd.Text, DstAddress.Text, Subject.Text, Body.Text).GetAwaiter();
        }

        private void AllowEditPatterns_CheckStateChanged(object sender, EventArgs e)
        {
            BodyPatterns.Enabled = AllowEditBodyPatterns.Checked;
        }

        private void AllowEditChangelogs_CheckStateChanged(object sender, EventArgs e)
        {
            ChangeLogs.Enabled = AllowEditChangelogs.Checked;
        }

        private void AllowEditResult_CheckStateChanged(object sender, EventArgs e)
        {
            Body.Enabled = AllowEditResult.Checked;
        }

        private void AllowEditSubject_CheckStateChanged(object sender, EventArgs e)
        {
            Subject.Enabled = AllowEditSubject.Checked;
        }

        private void ScheduleSending()
        {
            while (Run)
            {
                BeginInvoke(new MethodInvoker(delegate { NextEmailTime.Text = $"Next E-mail at {ScheduledTime:dd MMMM, HH:mm:ss}"; }));
                TimeSpan timeToWait = ScheduledTime - DateTime.Now;
                Stopwatch stopwatch = new();
                stopwatch.Start();
                while (stopwatch.ElapsedMilliseconds < timeToWait.TotalMilliseconds)
                    if (!Run) return;
                    else Thread.Sleep(10);
                stopwatch.Stop();
                if (!Run) return;
                Task task = Task.Run(async () => await SendMessage(SrcAddress.Text, SrcPswd.Text, DstAddress.Text, Subject.Text, Body.Text));
                GenerateAllFields();
                Random rnd = new();
                ScheduledTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 21, 00, 00) - new TimeSpan(0, rnd.Next(30, 90), rnd.Next(0, 59));
            }
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (!Run)
            {
                Run = true;
                StartStop.Text = "Stop service";
                Random rnd = new();
                ScheduledTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 10, 00) - new TimeSpan(0, rnd.Next(0, 30), rnd.Next(0, 59));
                if (ScheduledTime < DateTime.Now) ScheduledTime += new TimeSpan(24, 0, 0);
                thread = new Thread(ScheduleSending);
                thread.Start();
            }
            else
            {
                Run = false;
                StartStop.Text = "Start service";
                NextEmailTime.Text = "Next E-mail at ...";
            }
        }

        private Thread SettingsThread(List<KeyValuePair<string, string>> settingslist)
        {
            Thread settingsthread = new(() => SetSetting(settingslist)) { IsBackground = false };
            settingsthread.Start();
            return settingsthread;
        }
        private void SetSetting(List<KeyValuePair<string, string>> settingslist)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            foreach (KeyValuePair<string, string> pair in settingslist)
                if (settings[pair.Key] == null) settings.Add(pair.Key, pair.Value);
                else settings[pair.Key].Value = pair.Value;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        private List<KeyValuePair<string, string>> SettingsList()
        {
            var settingslist = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("BodyPatterns", BodyPatterns.Text),
                new KeyValuePair<string, string>("SubjectPatterns", SubjectPatterns.Text),
                new KeyValuePair<string, string>("ChangeLogs", ChangeLogs.Text),
                new KeyValuePair<string, string>("DstName", DstName.Text),
                new KeyValuePair<string, string>("SrcName", SrcName.Text),
                new KeyValuePair<string, string>("SrcAddress", SrcAddress.Text),
                new KeyValuePair<string, string>("DstAddress", DstAddress.Text),
                new KeyValuePair<string, string>("SrcPassword", SrcPswd.Text),
                new KeyValuePair<string, string>("Appeal", Appeal.SelectedIndex.ToString()),
                new KeyValuePair<string, string>("Introduce", Introduce.SelectedIndex.ToString()),
                new KeyValuePair<string, string>("StartOnBoot", StartOnBoot.Checked.ToString())
            };
            return settingslist;
        }

        private void MailBot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Run = false;
            SettingsThread(SettingsList());
            if (thread != null) while (thread.IsAlive) ;
        }

        private void MailBot_Shown(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            BodyPatterns.Text = appSettings["BodyPatterns"].Replace("\\r\\n", Environment.NewLine);
            SubjectPatterns.Text = appSettings["SubjectPatterns"].Replace("\\r\\n", Environment.NewLine);
            ChangeLogs.Text = appSettings["ChangeLogs"].Replace("\\r\\n", Environment.NewLine);
            DstName.Text = appSettings["DstName"].Replace("\\r\\n", Environment.NewLine);
            SrcName.Text = appSettings["SrcName"].Replace("\\r\\n", Environment.NewLine);
            SrcAddress.Text = appSettings["SrcAddress"].Replace("\\r\\n", Environment.NewLine);
            DstAddress.Text = appSettings["DstAddress"].Replace("\\r\\n", Environment.NewLine);
            SrcPswd.UseSystemPasswordChar = true;
            SrcPswd.Text = appSettings["SrcPassword"];
            StartOnBoot.Checked = Convert.ToBoolean(appSettings["StartOnBoot"]);
            if (StartOnBoot.Checked) AutostartOnBoot.SetValue("Mail'o'bot", Application.ExecutablePath);
            else AutostartOnBoot.DeleteValue("Mail'o'bot", false);
            NextEmailTime.Text = "Next E-mail at ...";
            Appeal.Items.AddRange(new object[] { "Yes", "No", "Randomize" });
            Appeal.SelectedIndex = Convert.ToInt32(appSettings["Appeal"]);
            Introduce.Items.AddRange(new object[] { "Yes", "No", "Randomize" });
            Introduce.SelectedIndex = Convert.ToInt32(appSettings["Introduce"]);
            SubjectPatterns.Enabled = BodyPatterns.Enabled = ChangeLogs.Enabled = Subject.Enabled = Body.Enabled = false;
            GenerateAllFields();
        }
    }
}

/*
    //Credentials credentials = new();
    //BodyPatterns.Text = $"`*здравствуйте/добрый вечер/добрый день/-*, DstName, SrcName, *отправляю/прилагаю/предоставляю/показываю* *вам/-* *краткий/-* отчёт о *проделанной/выполненной/-* работе *за сегодня/за день/-**:/-*ChangeLogs`"
    //+ $"`DstName, *здравствуйте/добрый вечер/добрый день/-*, SrcName, *отправляю/прилагаю/предоставляю* *вам/-* *краткий/-* отчёт о *проделанной/выполненной/-* работе *за сегодня/за день/-**:/-*ChangeLogs`"
    //+ $"`DstName, *здравствуйте/добрый вечер/добрый день*\r\nSrcName, *предоставляю/показываю/прилагаю/отправляю* *вам/-* *список/перечень/сводку* *всех/-* *проделанных/выполненных/реализованных/-* *за сегодняшний день/сегодня/за день/-* *работ/изменений* в *серверной части программы/программе**:/-*ChangeLogs`";
    //SubjectPatterns.Text = $"`Отчёт о проделанной работе над серверным приложением MM`";
    //DstName.Text = "Никита Владимирович";
    //SrcName.Text = "я *студент/-* Игорь";

    //SrcAddress.Text = credentials.SrcAddress;
    //DstAddress.Text = credentials.SrcAddress;
    //SrcPswd.UseSystemPasswordChar = true;
    //SrcPswd.Text = credentials.Password;
*/