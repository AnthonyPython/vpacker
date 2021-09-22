using Microsoft.Win32;
using System;
using System.Collections;
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

        // What folders to look for, and pack into the pak01 vpk set.
        public string[] target_folders = { "cfg", "classes", "materials", "models", "resource", "media", "particles", "scripts", "maps", "expressions", "scenes", "shaders", "sound" };
        // What files to look for, in the aforementioned folders.
        public List<string> file_types = new List<string> { "vcs", "mp3", "wav", "rc", "scr", "vmt", "vtf", "mdl", "phy", "vtx", "vvd", "ani", "pcf", "vcd", "txt", "res", "vfont", "cur", "dat", "bik", "mov", "bsp", "nav", "lst", "lmp", "vfe", "ttf" };
        // which vpk.exe to use.
        public string vpk_path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Source SDK Base 2013 Multiplayer";

        public int m_iCSize = 200;

        public int m_iCnbytebounds = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public static Steam steam = new Steam();

        public static string version = "0.1";

        public string cwd = Directory.GetCurrentDirectory().ToString();


        private void button1_Click(object sender, EventArgs e)
        {
            string tempvpk_path = vpk_path; //textBoxGameDirectory.Text;

            bool bMultiC = checkBoxMultichunk.Checked;
            int tempCsize = m_iCSize;
            int tempCnBound = m_iCnbytebounds;
            if (File.Exists(tempvpk_path + "\\bin\\vpk.exe"))
            {
                /*Process vpak = new Process();
                vpak.StartInfo.FileName = "CMD.exe";
                vpak.StartInfo.Arguments = "/c cd /d " + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\bin && start \"\" hlmv.exe -game \"" + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\" + "tf" + "\"";
                vpak.Start();*/


                if (bMultiC)
                {
                    createfile();
                    //vpk_path
                    string fileName = cwd + "\\test.txt";
                    Process vpak = new Process();

                    //"/c cd /d " + "D:\\SteamLibrary\\steamapps\\common\\Source SDK Base 2013 Multiplayer" + "\\bin && start \"\" vpk.exe \"" +"vpk "+  cwd + "-M " + "a " + "pak01 " + "@" + fileName + "\""
                    vpak.StartInfo.FileName = tempvpk_path + "\\bin\\vpk.exe";
                    //vpak.StartInfo.Arguments = "/c cd /d " + vpk_path + "\\bin && start \"\" vpk.exe \"" +"vpk "+  cwd + "-M " + "a " + "pak01 " + "@" + fileName + "\"";

                    vpak.StartInfo.Arguments = "-v " + textBoxExtraParams.Text /*+ "-c " + tempCsize.ToString() + "-a " + tempCnBound.ToString() */+ "-M " + "a " + "pak01 " + "@" + fileName + "\"";
                    vpak.Start();
                    if (File.Exists(fileName) && vpak.HasExited)
                    {
                        File.Delete(fileName);
                    }
                }
                else 
                {
                    Process vpak = new Process();

                   
                    vpak.StartInfo.FileName = "CMD.exe";

                    string quote = "\"";
                    vpak.StartInfo.Arguments = @"/c "+ "cd /d " +  quote + tempvpk_path + quote + "\\bin && start " + "vpk.exe " + quote + cwd + quote  + textBoxExtraParams.Text;
                    vpak.Start();

                    
                }
               

            }
        }
        private void FindAddDirectories()
        {
            if (File.Exists(steam.MainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                string[] lines = File.ReadAllLines(steam.MainSteamDir + "/steamapps/libraryfolders.vdf");
                if (lines.Count() != 5)
                {
                    //This means we have multiple directories
                    steam.AdditionalSteamDirectories.Clear();
                    int numberOfDirectories = lines.Count() - 5;
                    for (int i = 4; i < lines.Count() - 1; i++)    //start at line 5 and go to closing bracket
                    {
                        string temp = lines[i];
                        int finalPosition = temp.LastIndexOf("\"");

                        if (finalPosition != -1)
                        {
                            int startPosition = temp.LastIndexOf("\"", finalPosition - 1) + 1;    //Dont grab the same position or starting quote
                            temp = temp.Substring(startPosition, (finalPosition - startPosition)).Replace("\\\\", "\\");
                            if(Directory.Exists(temp))
                                steam.AdditionalSteamDirectories.Add(temp);
                        }
                       
                    }
                    //richTextBoxAdditionalSteamDirectory.Lines = steam.AdditionalSteamDirectories.ToArray();
                }
            }
            checkGamesInstalled();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            steam.AdditionalSteamDirectories = new List<string>();
            textBoxGameDirectory.Text = vpk_path;

            textBoxCNBounds.Text = m_iCnbytebounds.ToString();
            textBoxCSize.Text = m_iCSize.ToString();

            versionlabel.Text = "Version: " + version;

            textBoxCNBounds.ReadOnly = true;
            textBoxCSize.ReadOnly = true;
            //checkBoxMultichunk.Enabled = false;
            FindSteam();
            FindSteamDirectories();
            
        }

        private void FindSteam()
        {
            steam.MainSteamDir = (Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam\\") ?? Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam\\"))?.GetValue("InstallPath").ToString();

        }



        

        private void FindSteamDirectories()
        {


            if (File.Exists(steam.MainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                steam.AdditionalSteamDirectories.Clear();
                FindAddDirectories();
                //steam.AdditionalSteamDirectories = getLibraryFolders();


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

            string cwd = Directory.GetCurrentDirectory();
            
            sb.Append("Working Directory: ");
            sb.AppendLine(cwd);
            richTextBox1.Text = sb.ToString();
        }

        private void createfile()
        {
            
            string fileName = cwd + "\\test.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    StringBuilder sb = new StringBuilder();
                    // Add some text to file
                    foreach (var user_folder in target_folders)
                    {
                        foreach (string f in Directory.GetFiles(user_folder, "*.*", SearchOption.AllDirectories))
                        {
                            string extension = Path.GetExtension(f);

                            var temp = extension.Split('.');
                            
#if true
                            if (extension != null && file_types.Contains(temp[1].ToString()))
                            {
                                sb.Append("Found: ");
                                sb.AppendLine(f);

                                sb.AppendLine("\n");
                                //Byte[] title = new UTF8Encoding(true).GetBytes(cwd + "\\" + f + "\n");
                                Byte[] title = new UTF8Encoding(true).GetBytes( f + "\n");
                                //Byte[] title = new UTF8Encoding(true).GetBytes(extension + "\n");
                                fs.Write(title, 0, title.Length);
                                sb.Append("Writing to file.");
                                //sb.AppendLine(f);

                                sb.AppendLine("\n");
                            } 
#endif
                        }

                    }

                   

                   
                    richTextBoxLog.Text = sb.ToString();


                }
                richTextBoxLog.Clear();
                StringBuilder sb2 = new StringBuilder();
                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        sb2.Append(s + '\n');
                    }

                    richTextBoxLog.Text = sb2.ToString();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void BrowseGameDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogGame.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxGameDirectory.Text = folderBrowserDialogGame.SelectedPath;
                vpk_path = folderBrowserDialogGame.SelectedPath;
            }
        }

        private void textBoxGameDirectory_TextChanged(object sender, EventArgs e)
        {
            vpk_path = textBoxGameDirectory.Text;
        }

        private void textBoxCSize_TextChanged(object sender, EventArgs e)
        {
            m_iCSize = Int16.Parse(textBoxCSize.Text);
        }

        private void textBoxCNBounds_TextChanged(object sender, EventArgs e)
        {
            m_iCnbytebounds= Int16.Parse(textBoxCNBounds.Text);
        }
    }
}
