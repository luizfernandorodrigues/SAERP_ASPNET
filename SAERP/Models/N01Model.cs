using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAERP.Models
{
    public class N01Model
    {
        private string a03_ukey;

        private string a03_ukey1;
        private string ff08_ukey;
        private string j38_ukey;
        [Required(ErrorMessage = "Numero é Obrigatório!")]
        private string n01_001_c;
        private int n01_002_n;
        private string n01_003_c;
        private int n01_004_n;
        private string n01_005_c;
        private string n01_006_c;
        private decimal n01_007_n;
        private decimal n01_008_n;
        private DateTime n01_009_d;
        private DateTime n01_010_d;
        private string n01_011_c;
        private int n01_012_n;
        private int n01_013_n;
        private DateTime n01_014_d;
        private DateTime n01_015_d;
        private string n01_016_c;
        private string n01_017_c;
        private decimal n01_018_n;
        private string n01_019_c;
        private int n01_020_n;
        private int n01_021_n;
        private string n01_022_c;
        private int n01_023_n;
        private int n01_024_n;
        private int n01_025_n;
        private DateTime n01_026_d;
        private int n01_027_n;
        private string n02_ukey;
        private string n06_ukey;
        private string usr_ukey;
        public string A03_ukey { get => a03_ukey; set => a03_ukey = value; }
        public string A03_ukey1 { get => a03_ukey1; set => a03_ukey1 = value; }
        public string Ff08_ukey { get => ff08_ukey; set => ff08_ukey = value; }
        public string J38_ukey { get => j38_ukey; set => j38_ukey = value; }
        public string N01_001_c { get => n01_001_c; set => n01_001_c = value; }
        public int N01_002_n { get => n01_002_n; set => n01_002_n = value; }
        public string N01_003_c { get => n01_003_c; set => n01_003_c = value; }
        public int N01_004_n { get => n01_004_n; set => n01_004_n = value; }
        public string N01_005_c { get => n01_005_c; set => n01_005_c = value; }
        public string N01_006_c { get => n01_006_c; set => n01_006_c = value; }
        public decimal N01_007_n { get => n01_007_n; set => n01_007_n = value; }
        public decimal N01_008_n { get => n01_008_n; set => n01_008_n = value; }
        public DateTime N01_009_d { get => n01_009_d; set => n01_009_d = value; }
        public DateTime N01_010_d { get => n01_010_d; set => n01_010_d = value; }
        public string N01_011_c { get => n01_011_c; set => n01_011_c = value; }
        public int N01_012_n { get => n01_012_n; set => n01_012_n = value; }
        public int N01_013_n { get => n01_013_n; set => n01_013_n = value; }
        public DateTime N01_014_d { get => n01_014_d; set => n01_014_d = value; }
        public DateTime N01_015_d { get => n01_015_d; set => n01_015_d = value; }
        public string N01_016_c { get => n01_016_c; set => n01_016_c = value; }
        public string N01_017_c { get => n01_017_c; set => n01_017_c = value; }
        public decimal N01_018_n { get => n01_018_n; set => n01_018_n = value; }
        public string N01_019_c { get => n01_019_c; set => n01_019_c = value; }
        public int N01_020_n { get => n01_020_n; set => n01_020_n = value; }
        public int N01_021_n { get => n01_021_n; set => n01_021_n = value; }
        public string N01_022_c { get => n01_022_c; set => n01_022_c = value; }
        public int N01_023_n { get => n01_023_n; set => n01_023_n = value; }
        public int N01_024_n { get => n01_024_n; set => n01_024_n = value; }
        public int N01_025_n { get => n01_025_n; set => n01_025_n = value; }
        public DateTime N01_026_d { get => n01_026_d; set => n01_026_d = value; }
        public int N01_027_n { get => n01_027_n; set => n01_027_n = value; }
        public string N02_ukey { get => n02_ukey; set => n02_ukey = value; }
        public string N06_ukey { get => n06_ukey; set => n06_ukey = value; }
        public string Usr_ukey { get => usr_ukey; set => usr_ukey = value; }
    }
}