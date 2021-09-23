﻿using Microsoft.Win32;
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
        static List<DirectoryInfo> SourceModfolders = new List<DirectoryInfo>(); // List that hold direcotries that cannot be accessed
        // What files to look for, in the aforementioned folders.
        public List<string> file_types = new List<string> { "vcs", "mp3", "wav", "rc", "scr", "vmt", "vtf", "mdl", "phy", "vtx", "vvd", "ani", "pcf", "vcd", "txt", "res", "vfont", "cur", "dat", "bik", "mov", "bsp", "nav", "lst", "lmp", "vfe", "ttf" };
        // which vpk.exe to use.
        public string vpk_path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Source SDK Base 2013 Multiplayer";


        public static List<SourceGame> listOfSourceGames = new List<SourceGame>();
        public static List<SourceMod> listOfSourceMods = new List<SourceMod>();

        public int m_iCSize = 200;

        public int m_iCnbytebounds = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public static Steam steam = new Steam();

        public static string version = "0.1";

        public string cwd = Directory.GetCurrentDirectory().ToString();


        public void BatchPackFolders()
        {
            string folderpaths = richTextBox_Folders.Text;
            List<string> foldersArray = folderpaths.Split('\n').ToList<string>();

            foldersArray.RemoveAll(x => string.IsNullOrEmpty(x));
            



            string gameName = comboBox_VpkGame.GetItemText(comboBox_VpkGame.SelectedItem);
            string directory = listOfSourceGames.First(item => item.ProperName == gameName).Directory;

            string tempvpk_path = (checkBox_manualvpkpath.Checked ? vpk_path : directory);

            
            if (File.Exists(tempvpk_path + "\\bin\\vpk.exe"))
            {
                foreach (var F in foldersArray)
                {
                    var bMultiC = checkBoxMultichunk.Checked;
                    if (bMultiC)
                    {
                        createBatchvpkfile(F);

                        var lastslash = F.LastIndexOf("\\");
                        var vpkname = F.Substring(lastslash +1);
                        Process vpak3 = new Process();


                        vpak3.StartInfo.FileName = "CMD.exe";

                        string quote = "\"";
                        string temp = "Start " + "/wait " + quote + quote + " " + quote + tempvpk_path + "\\bin\\vpk.exe" + quote + " -v -M a " + vpkname  /*"pak01"*/ + " @" + quote + F + "\\vpk_list.txt" + quote + "\n" + "exit";

                        vpak3.StartInfo.Arguments = @"/c " + " cd /d " + F + " && " + temp;
                        //vpak3.StartInfo.Arguments = @"/c " + "cd /d " + quote + tempvpk_path + quote + "\\bin && start " + "vpk.exe " + textBoxExtraParams.Text + quote + F + quote ;
                        var vpkstarted = vpak3.Start();

                        waitforprocess(vpak3, F + "\\vpk_list.txt");

                        if (vpkstarted)
                            MessageBox.Show(vpak3.Id.ToString());
                    }
                    else 
                    {
                        Process vpak3 = new Process();


                        vpak3.StartInfo.FileName = "CMD.exe";

                        string quote = "\"";
                        vpak3.StartInfo.Arguments = @"/c " + "cd /d " + quote + tempvpk_path + quote + "\\bin && start " + "/wait " + "vpk.exe " + textBoxExtraParams.Text + quote + F + quote ;
                        vpak3.Start();

                        waitforprocess(vpak3, "");
                    }
                        
                }
            }
            else
            {
                MessageBox.Show(String.Format("No VPK.exe could be found at {0}\\bin\\vpk.exe", tempvpk_path), "ERROR 001", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        static async Task waitforprocess(Process p, string file)
        {
            while (!p.HasExited)
            {
                
            }

            try
            {
                // Check if file exists with its full path    
                if (File.Exists(file))
                {
                    // If file found, delete it    
                    File.Delete(file);
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

            bool bMultiC = checkBoxMultichunk.Checked;
            int tempCsize = m_iCSize;
            int tempCnBound = m_iCnbytebounds;
            string gameName = comboBox_VpkGame.GetItemText(comboBox_VpkGame.SelectedItem);
            string directory = listOfSourceGames.First(item => item.ProperName == gameName).Directory;


            string ModName = comboBox_Mods.GetItemText(comboBox_Mods.SelectedItem);
            string Moddirectory = listOfSourceMods.First(item => item.ProperName == ModName).Directory;

            string tempvpk_path = (checkBox_manualvpkpath.Checked ? vpk_path : directory);
            if (File.Exists(tempvpk_path + "\\bin\\vpk.exe"))
            {
                /*Process vpak = new Process();
                vpak.StartInfo.FileName = "CMD.exe";
                vpak.StartInfo.Arguments = "/c cd /d " + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\bin && start \"\" hlmv.exe -game \"" + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\" + "tf" + "\"";
                vpak.Start();*/


                createfile();
               // createbatfile();
                //vpk_path
                string fileName = Moddirectory + "\\vpk_list.txt";

                string batfileName = Moddirectory + "\\vpklaunch.bat";
                Process vpak = new Process();
                
                vpak.StartInfo.FileName = "CMD.exe";
                
                string quote = "\"";

                
                string temp = "Start " + "/wait " + quote + quote + " " + quote + tempvpk_path + "\\bin\\vpk.exe" + quote + " -v -M a pak01 @" + quote + Moddirectory + "\\vpk_list.txt" + quote + "\n" + "exit";

                vpak.StartInfo.Arguments = @"/c " +" cd /d " + Moddirectory + " && " + temp;
                
               
                vpak.Start();
                waitforprocess(vpak, Moddirectory + "\\vpk_list.txt");


            }
            else 
            {
                MessageBox.Show(String.Format("No VPK.exe could be found at {0}\\bin\\vpk.exe", tempvpk_path), "ERROR 001", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }
            }
            CheckGamesInstalled();
        }

        private void FindSourceModDirectories()
        {
            if (Directory.Exists(steam.MainSteamDir + "/steamapps/sourcemods"))
            {
                DirectoryInfo dir = new DirectoryInfo(steam.MainSteamDir + "/steamapps/sourcemods");
                SourceModfolders.Clear();


                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    if (File.Exists(d.FullName + "/gameinfo.txt"))
                        SourceModfolders.Add(d);
                    

                }
                
            }

            
        }

        private void updateVPKGameDropDown()
        {
            // Clear the combobox and disable buttons
            comboBox_VpkGame.Items.Clear();
            //hammer_btn.Enabled = false;
            //modelViewer_btn.Enabled = false;
            //button_gmodConfig.Enabled = false;
            foreach (SourceGame game in listOfSourceGames)
            {
                if (game.Installed)
                {
                    comboBox_VpkGame.Items.Add(game.ProperName);
                }
            }
            if (comboBox_VpkGame.Items.Count > 0)
            {
                comboBox_VpkGame.SelectedIndex = 0;
                // Reenable
                //hammer_btn.Enabled = true;
                //modelViewer_btn.Enabled = true;
            }
            /*if (comboBoxGames.Items.Contains("Garry's Mod"))
            {
                button_gmodConfig.Enabled = true;
            }*/
        }
        private void updateGameDropDown()
        {
            // Clear the combobox and disable buttons
            comboBox_Mods.Items.Clear();
            //hammer_btn.Enabled = false;
            //modelViewer_btn.Enabled = false;
            //button_gmodConfig.Enabled = false;
            foreach (var game in listOfSourceMods)
            {

                comboBox_Mods.Items.Add(game.ProperName);
                
            }
            if (comboBox_Mods.Items.Count > 0)
            {
                comboBox_Mods.SelectedIndex = 0;
                // Reenable
                //hammer_btn.Enabled = true;
                //modelViewer_btn.Enabled = true;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            steam.AdditionalSteamDirectories = new List<string>();

            textBoxGameDirectory.Text = vpk_path;

            textBoxCNBounds.Text = m_iCnbytebounds.ToString();
            textBoxCSize.Text = m_iCSize.ToString();

            if (checkBox_manualvpkpath.Checked)
            {
                textBoxGameDirectory.Enabled = true;
                BrowseGameDirectory.Enabled = true;
                comboBox_VpkGame.Enabled = false;
            }
            else
            {
                textBoxGameDirectory.Enabled = false;
                BrowseGameDirectory.Enabled = false;
                comboBox_VpkGame.Enabled = true;
            }

            versionlabel.Text = "Version: " + version;

            // Add Source Games
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Alien Swarm",
                ProperName = "Alien Swarm",
                SourceName = "swarm",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Contagion",
                ProperName = "Contagion",
                SourceName = "contagion",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Counter-Strike Global Offensive",
                ProperName = "Counter-Strike Global Offensive",
                SourceName = "csgo",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Counter-Strike Source",
                ProperName = "Counter-Strike Source",
                SourceName = "cstrike",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Day of Defeat Source",
                ProperName = "Day of Defeat Source",
                SourceName = "dod",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "dayofinfamy",
                ProperName = "Day of Infamy",
                SourceName = "doi",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Dino D-Day",
                ProperName = "Dino D-Day",
                SourceName = "dinodday",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Double Action",
                ProperName = "Double Action",
                SourceName = "dab",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Empires",
                ProperName = "Empires",
                SourceName = "empires",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "GarrysMod",
                ProperName = "Garry's Mod",
                SourceName = "garrysmod",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 1 Source Deathmatch",
                ProperName = "Half-Life Source Deathmatch",
                SourceName = "hl1mp",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 2",
                ProperName = "Half-Life 2",
                SourceName = "hl2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 2 Deathmatch",
                ProperName = "Half-Life 2 Deathmatch",
                SourceName = "hl2mp",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "insurgency2",
                ProperName = "Insurgency",
                SourceName = "insurgency",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Left 4 Dead 2",
                ProperName = "Left 4 Dead 2",
                SourceName = "left4dead2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "nmrih",
                ProperName = "No More Room In Hell",
                SourceName = "nmrih",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Nuclear Dawn",
                ProperName = "Nuclear Dawn",
                SourceName = "nucleardawn",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "pirates, vikings and knights ii",
                ProperName = "Pirates, Vikings, and Knights II",
                SourceName = "pvkii",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal",
                ProperName = "Portal",
                SourceName = "portal",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal 2",
                ProperName = "Portal 2",
                SourceName = "portal2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Team Fortress 2",
                ProperName = "Team Fortress 2",
                SourceName = "tf",
                Installed = false,
                Directory = ""
            });

            textBoxCNBounds.ReadOnly = true;
            textBoxCSize.ReadOnly = true;
            //checkBoxMultichunk.Enabled = false;
            FindSteam();
            FindSteamDirectories();
            FindSourceModDirectories();
            CheckSourceModsInstalled();
            //updateGameDropDown();


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
                

            }

            CheckGamesInstalled();
        }

        private void CheckSourceModsInstalled()
        {
            foreach (var item in SourceModfolders)
            {
                listOfSourceMods.Add(new SourceMod
                {
                    SteamName = item.Name,
                    ProperName = item.Name,
                    SourceName = item.Name,
                    Installed = false,
                    Directory = item.FullName
                });
            }
            foreach (SourceMod game in listOfSourceMods)
            {
                if (Directory.Exists(steam.MainSteamDir + "\\steamapps\\sourcemods\\" + game.SteamName))
                {

                    // Open the stream and read it back.    
                   /* using (StreamReader sr = File.OpenText(steam.MainSteamDir + "\\steamapps\\sourcemods\\" + game.SteamName))
                    {
                        


                    }*/

                    string[] lines = File.ReadAllLines(steam.MainSteamDir + "\\steamapps\\sourcemods\\" + game.SteamName + "\\gameinfo.txt");
                    if (lines.Count() != 1)
                    {
                        
                        for (int i = 1; i < lines.Count() - 1; i++)    //start at line 2 and go to closing bracket
                        {
                            string temp = lines[i];

                            if (temp.Contains("game") && !temp.Contains("//"))
                            {
                               var temp2 = temp.Replace("\"","");
                                temp2 = temp2.Replace("game", "");
                                temp2 = temp2.Replace("\t", "");
                                temp2.Trim();
                                game.ProperName = temp2;
                                break;
                            }
                                    

                        }
                    }
                    //game.Directory = steam.MainSteamDir + "\\steamapps\\sourcemods\\" + game.SteamName;
                    game.Installed = true;
                }
            }
            
            updateGameDropDown();
            UpdateDebugInfo();
        }

        private void CheckGamesInstalled()
        {
            foreach (SourceGame game in listOfSourceGames)
            {
                if (Directory.Exists(steam.MainSteamDir + "\\steamapps\\common\\" + game.SteamName))
                {
                    game.Directory = steam.MainSteamDir + "\\steamapps\\common\\" + game.SteamName;
                    game.Installed = true;
                }
            }
            // Cycle through all additional directories
            foreach (string dir in steam.AdditionalSteamDirectories)
            {
                foreach (SourceGame game in listOfSourceGames)
                {
                    if (Directory.Exists(dir + "\\steamapps\\common\\" + game.SteamName))
                    {
                        game.Directory = dir + "\\steamapps\\common\\" + game.SteamName;
                        game.Installed = true;
                    }
                }
            }
            updateVPKGameDropDown();
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
        private void createBatchvpkfile(string path)
        {
            
            string fileName = path + "\\vpk_list.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                if (Directory.Exists(path))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(fileName))
                    {
                        StringBuilder sb = new StringBuilder();

                        DirectoryInfo dir = new DirectoryInfo(path);

                        // Add some text to file
                        foreach (var user_folder in dir.GetDirectories())
                        {
                            string tempdir = path + "\\";
                            foreach (string f in Directory.GetFiles(tempdir, "*.*", SearchOption.AllDirectories))
                            {
                                string extension = Path.GetExtension(f);

                                var temp = extension.Split('.');

#if true
                                if (extension != null && !temp[1].ToString().Contains("cache") && !f.Contains("vpk_list"))
                                {
                                    var tempf = f.Replace(path + "\\", "");
                                    sb.Append("Found: ");
                                    sb.AppendLine(tempf);

                                    sb.AppendLine("\n");
                                    //Byte[] title = new UTF8Encoding(true).GetBytes(cwd + "\\" + f + "\n");
                                    Byte[] title = new UTF8Encoding(true).GetBytes(tempf + "\n");
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
        private void createfile()
        {
            string gameName = comboBox_Mods.GetItemText(comboBox_Mods.SelectedItem);
            string directory = listOfSourceMods.First(item => item.ProperName == gameName).Directory;
            string fileName = directory + "\\vpk_list.txt";

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
                        string tempdir = directory +"\\" + user_folder;
                        foreach (string f in Directory.GetFiles(tempdir, "*.*", SearchOption.AllDirectories))
                        {
                            string extension = Path.GetExtension(f);

                            var temp = extension.Split('.');
                            
#if true
                            if (extension != null && !temp[1].ToString().Contains("cache") && !f.Contains("vpk_list") && file_types.Contains(temp[1].ToString()))
                            {
                                var tempf = f.Replace(directory + "\\","");
                                sb.Append("Found: ");
                                sb.AppendLine(tempf);

                                sb.AppendLine("\n");
                                //Byte[] title = new UTF8Encoding(true).GetBytes(cwd + "\\" + f + "\n");
                                Byte[] title = new UTF8Encoding(true).GetBytes(tempf + "\n");
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

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            FindSteamDirectories();
            FindSourceModDirectories();
            updateGameDropDown();
        }

        private void tabPage3_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }

            e.Effect = effects;

        }

        private void tabPage3_DragDrop(object sender, DragEventArgs e)
        {

            for (int i = 0; i < ((string[])e.Data.GetData(DataFormats.FileDrop)).Length; i++)
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[i];
                if (Directory.Exists(path))
                    richTextBox_Folders.Text += path + "\n";
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BatchPackFolders();
        }

        private void button_ClearBatchFolders_Click(object sender, EventArgs e)
        {
            richTextBox_Folders.Clear();
        }

        private void checkBox_manualvpkpath_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_manualvpkpath.Checked)
            {
                textBoxGameDirectory.Enabled = true;
                BrowseGameDirectory.Enabled = true;
                comboBox_VpkGame.Enabled = false;
            }
            else
            {
                textBoxGameDirectory.Enabled = false;
                BrowseGameDirectory.Enabled = false;
                comboBox_VpkGame.Enabled = true;
            }
        }
    }
}
