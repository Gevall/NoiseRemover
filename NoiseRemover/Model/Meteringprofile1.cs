using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Meteringprofile1
    {
        public string ProfilometerId { get; set; }
        public int Id { get; set; }
        public Point1[] Points { get; set; }
        public Line2[] Lines { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int RangePointsCount { get; set; }
        public int TotalLengthVerticalLines { get; set; }
    }
}
