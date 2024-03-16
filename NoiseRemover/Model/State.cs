using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class State
    {
        public int ElapsedTime { get; set; }
        public string Series { get; set; }
        public int Sample { get; set; }
        public int Tag { get; set; }
        public int Value { get; set; }
    }
}
