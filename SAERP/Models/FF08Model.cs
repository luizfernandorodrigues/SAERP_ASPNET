using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAERP.Models
{
    public class FF08Model : AbstractModel
    {
        private string a03_ukey;
        private string a03_ukey1;
        private string ff08_001_c;
        private double ff08_002_b;
        private int ff08_003_n;
        private string ff08_004_m;
        private string ff08_005_c;
        private string ff08_006_c;
        private string ff08_007_c;
        private string ff08_008_c;
        private string ff08_009_c;
        private int ff08_010_n;
        private string ff08_011_c;
        private string ff08_012_c;
        private string ff08_013_c;
        private string ff08_014_c;
        private string ff08_015_c;
        private string ff08_016_c;
        private string ff08_017_c;
        private string ff08_018_c;
        private string ff08_019_c;
        private string ff08_020_c;
        private string ff08_021_c;
        private string ff08_022_c;
        private string ff08_023_c;
        private string ff08_024_c;
        private string ff08_025_c;
        private string ff08_026_c;
        private string ff08_027_c;
        private string ff08_028_c;
        private string ff08_029_c;
        private string ff08_030_c;
        private string ff08_031_c;
        private int ff08_032_n;
        private double ff08_033_n;
        private double ff08_034_n;
        private double ff08_035_n;
        private double ff08_036_n;
        private double ff08_037_n;
        private double ff08_038_n;
        private double ff08_039_n;
        private double ff08_040_n;
        private int ff08_041_n;
        private int ff08_042_n;
        private int ff08_043_n;
        private int ff08_044_n;

        public string A03_ukey { get => a03_ukey; set => a03_ukey = value; }
        public string A03_ukey1 { get => a03_ukey1; set => a03_ukey1 = value; }
        public string Ff08_001_c { get => ff08_001_c; set => ff08_001_c = value; }
        public double Ff08_002_b { get => ff08_002_b; set => ff08_002_b = value; }
        public int Ff08_003_n { get => ff08_003_n; set => ff08_003_n = value; }
        public string Ff08_004_m { get => ff08_004_m; set => ff08_004_m = value; }
        public string Ff08_005_c { get => ff08_005_c; set => ff08_005_c = value; }
        public string Ff08_006_c { get => ff08_006_c; set => ff08_006_c = value; }
        public string Ff08_007_c { get => ff08_007_c; set => ff08_007_c = value; }
        public string Ff08_008_c { get => ff08_008_c; set => ff08_008_c = value; }
        public string Ff08_009_c { get => ff08_009_c; set => ff08_009_c = value; }
        public int Ff08_010_n { get => ff08_010_n; set => ff08_010_n = value; }
        public string Ff08_011_c { get => ff08_011_c; set => ff08_011_c = value; }
        public string Ff08_012_c { get => ff08_012_c; set => ff08_012_c = value; }
        public string Ff08_013_c { get => ff08_013_c; set => ff08_013_c = value; }
        public string Ff08_014_c { get => ff08_014_c; set => ff08_014_c = value; }
        public string Ff08_015_c { get => ff08_015_c; set => ff08_015_c = value; }
        public string Ff08_016_c { get => ff08_016_c; set => ff08_016_c = value; }
        public string Ff08_017_c { get => ff08_017_c; set => ff08_017_c = value; }
        public string Ff08_018_c { get => ff08_018_c; set => ff08_018_c = value; }
        public string Ff08_019_c { get => ff08_019_c; set => ff08_019_c = value; }
        public string Ff08_020_c { get => ff08_020_c; set => ff08_020_c = value; }
        public string Ff08_021_c { get => ff08_021_c; set => ff08_021_c = value; }
        public string Ff08_022_c { get => ff08_022_c; set => ff08_022_c = value; }
        public string Ff08_023_c { get => ff08_023_c; set => ff08_023_c = value; }
        public string Ff08_024_c { get => ff08_024_c; set => ff08_024_c = value; }
        public string Ff08_025_c { get => ff08_025_c; set => ff08_025_c = value; }
        public string Ff08_026_c { get => ff08_026_c; set => ff08_026_c = value; }
        public string Ff08_027_c { get => ff08_027_c; set => ff08_027_c = value; }
        public string Ff08_028_c { get => ff08_028_c; set => ff08_028_c = value; }
        public string Ff08_029_c { get => ff08_029_c; set => ff08_029_c = value; }
        public string Ff08_030_c { get => ff08_030_c; set => ff08_030_c = value; }
        public string Ff08_031_c { get => ff08_031_c; set => ff08_031_c = value; }
        public int Ff08_032_n { get => ff08_032_n; set => ff08_032_n = value; }
        public double Ff08_033_n { get => ff08_033_n; set => ff08_033_n = value; }
        public double Ff08_034_n { get => ff08_034_n; set => ff08_034_n = value; }
        public double Ff08_035_n { get => ff08_035_n; set => ff08_035_n = value; }
        public double Ff08_036_n { get => ff08_036_n; set => ff08_036_n = value; }
        public double Ff08_037_n { get => ff08_037_n; set => ff08_037_n = value; }
        public double Ff08_038_n { get => ff08_038_n; set => ff08_038_n = value; }
        public double Ff08_039_n { get => ff08_039_n; set => ff08_039_n = value; }
        public double Ff08_040_n { get => ff08_040_n; set => ff08_040_n = value; }
        public int Ff08_041_n { get => ff08_041_n; set => ff08_041_n = value; }
        public int Ff08_042_n { get => ff08_042_n; set => ff08_042_n = value; }
        public int Ff08_043_n { get => ff08_043_n; set => ff08_043_n = value; }
        public int Ff08_044_n { get => ff08_044_n; set => ff08_044_n = value; }
    }
}