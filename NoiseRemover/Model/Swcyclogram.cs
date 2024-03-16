using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Swcyclogram
    {
        public bool IsRunning { get; set; }
        public string Elapsed { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public int ElapsedTicks { get; set; }
    }
}
