using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vpacker
{
    public partial class Form1 : Form
    {
        public string vpk_dir = "";
        public Form1()
        {
            InitializeComponent();
        }

        public static Steam steam = new Steam();

        public static string version = "1.0.0";


        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\SteamLibrary\\steamapps\\common\\Team Fortress 2" + "\\bin\\hlmv.exe"))
            {
                Process vpak = new Process();
                vpak.StartInfo.FileName = "CMD.exe";
                vpak.StartInfo.Arguments = "/c cd /d " + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\bin && start \"\" hlmv.exe -game \"" + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\" + "tf" + "\"";
                vpak.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            steam.AdditionalSteamDirectories = new List<string>();
            FindSteam();
            FindSteamDirectories();
        }

        private void FindSteam()
        {
            steam.MainSteamDir = (Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam\\") ?? Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam\\"))?.GetValue("InstallPath").ToString();

        }



        public List<string> getLibraryFolders()
        {
            List<string> stringList = new List<string>();


            using (StreamReader streamReader = new StreamReader(steam.MainSteamDir + "\\SteamApps\\libraryfolders.vdf"))
            {
                string input;
                while ((input = streamReader.ReadLine().Trim()) != "}")
                {
                    if (new Regex("^\"[0-9]*\"( *\t*)*\".*\"$").IsMatch(input))
                    {
                        string path = Regex.Replace(input, "^\"[0-9]*\"( *\t*)*", "").Replace("\"", "").Replace("\\\\", "\\");
                        if (Directory.Exists(path))
                            stringList.Add(path);
                    }
                }
            }
            return stringList;
        }

        private void FindSteamDirectories()
        {


            if (File.Exists(steam.MainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                steam.AdditionalSteamDirectories.Clear();
                steam.AdditionalSteamDirectories = getLibraryFolders();


            }

            checkGamesInstalled();
        }

        private void checkGamesInstalled()
        {

            if (Directory.Exists(steam.MainSteamDir + "\\steamapps\\common\\" + "Team Fortress 2"))
            {
                vpk_dir = steam.MainSteamDir + "\\steamapps\\common\\" + "Team Fortress 2";

            }


            foreach (string dir in steam.AdditionalSteamDirectories)
            {
                if (Directory.Exists(dir + "\\steamapps\\common\\" + "Team Fortress 2"))
                {

                    vpk_dir = dir + "\\steamapps\\common\\" + "Team Fortress 2";

                }
            }


            UpdateDebugInfo();
        }

        private void UpdateDebugInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Steam Dirctory: ");
            sb.AppendLine(steam.MainSteamDir);
            sb.AppendLine("\n");

            sb.Append("Library: ");
            if (File.Exists(steam.MainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                sb.AppendLine(steam.AdditionalSteamDirectories.Count.ToString());
            }
            else
            {
                sb.AppendLine("None Found");
            }

            foreach (string dir in steam.AdditionalSteamDirectories)
            {
                sb.Append("Library: ");
                sb.AppendLine(dir);

                sb.AppendLine("\n");
            }


            richTextBox1.Text = sb.ToString();
        }

    }
}
