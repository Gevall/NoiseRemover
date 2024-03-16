using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Distance
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int ElapsedTime { get; set; }
        public float Speed { get; set; }
        public float SNR1 { get; set; }
        public float distance { get; set; }
    }
}
