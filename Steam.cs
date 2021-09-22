﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpacker
{

    public class SourceGame
    {
        public string SteamName { get; set; }
        public string ProperName { get; set; }
        public string SourceName { get; set; }
        public bool Installed { get; set; }
        public string Directory { get; set; }
    }

    public class SourceMod
    {
        public string SteamName { get; set; }
        public string ProperName { get; set; }
        public string SourceName { get; set; }
        public bool Installed { get; set; }
        public string Directory { get; set; }
    }
    public class Steam
    {
        public string MainSteamDir { get; set; }
        public List<string> AdditionalSteamDirectories { get; set; }

        
    }
}
