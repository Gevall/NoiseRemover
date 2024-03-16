using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Lastmetering
    {
        public DateTime DateTime { get; set; }
        public int ElapsedTime { get; set; }
        public float Speed { get; set; }
        public float Distance { get; set; }
        public float DistanceBegin { get; set; }
        public Meteringprofile[] MeteringProfiles { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float HeightLeft { get; set; }
        public float HeightRight { get; set; }
        public int Tag1 { get; set; }
        public int Tag2 { get; set; }
        public bool IsExclude { get; set; }
    }
}
