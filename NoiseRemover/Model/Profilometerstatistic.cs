using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Profilometerstatistic
    {
        public string Ip { get; set; }
        public float PointsAverage { get; set; }
        public int Strength { get; set; }
        public int Exposition { get; set; }
        public int Gain { get; set; }
        public string AnalogGain { get; set; }
        public string IpShort { get; set; }
        public string IpSide { get; set; }
    }
}
