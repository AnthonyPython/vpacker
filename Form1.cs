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
        // which vpk.exe to use. do not use \!
        public string vpk_path = "D:/SteamLibrary/steamapps/common/Source SDK Base 2013 Multiplayer/bin/vpk.exe";

        public Form1()
        {
            InitializeComponent();
        }

        public static Steam steam = new Steam();

        public static string version = "1.0.0";

        public string cwd = Directory.GetCurrentDirectory().ToString();


        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\SteamLibrary\\steamapps\\common\\Team Fortress 2" + "\\bin\\hlmv.exe"))
            {
                /*Process vpak = new Process();
                vpak.StartInfo.FileName = "CMD.exe";
                vpak.StartInfo.Arguments = "/c cd /d " + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\bin && start \"\" hlmv.exe -game \"" + "D:\\SteamLibrary\\" + "\\steamapps\\common\\" + "Team Fortress 2" + "\\" + "tf" + "\"";
                vpak.Start();*/
                createfile();
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
                    // Add some text to file
                    // 
                   // var extensions = new List<string> { ".txt", ".xml" };
                    foreach (var user_folder in target_folders)
                    {
                        foreach (string f in Directory.GetFiles(user_folder, "*.*", SearchOption.AllDirectories))
                        {
                            string extension = Path.GetExtension(f);

                            var temp = extension.Split('.');
                            /*StringBuilder sb = new StringBuilder();
                            sb.Append("index 1: ");
                            sb.AppendLine(temp[1].ToString());

                            sb.AppendLine("\n");

                           
                            richTextBox1.Text = sb.ToString();*/

                            //var tempLen = temp.Length;
                            //extension = temp[0];
#if true
                            if (extension != null && file_types.Contains(temp[1].ToString()))
                            {

                                //Byte[] title = new UTF8Encoding(true).GetBytes(cwd + "\\" + f + "\n");
                                Byte[] title = new UTF8Encoding(true).GetBytes( f + "\n");
                                //Byte[] title = new UTF8Encoding(true).GetBytes(extension + "\n");
                                fs.Write(title, 0, title.Length);
                            } 
#endif
                        }

                    }
                    
                   
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }


        /*public  ArrayList DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    if (d == target_folders.Where(f => extensions.IndexOf(Path.GetExtension(d)) >= 0).ToArray())
                    { 
                    }
                    foreach (string f in Directory.GetFiles(d, "*.xml", SearchOption.AllDirectories))
                    {
                        string extension = Path.GetExtension(f);
                        if (extension != null && (extension.Equals(".xml")))
                        {
                            fileList.Add(f);
                        }
                    }
                    DirSearch(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fileList;
        }*/
    

        //Python code for reference only
#if false
response_path = join(os.getcwd(),"vpk_list.txt")

out = open(response_path,'w')
len_cd = len(os.getcwd()) + 1

for user_folder in target_folders:
	for root, dirs, files in os.walk(join(os.getcwd(),user_folder)):
		for file in files:
			if len(file_types) and file.rsplit(".")[-1] in file_types:
				out.write(os.path.join(root[len_cd:].replace("/","\\"),file) + "\n")

out.close()
#endif

    }
}
