using NoiseRemover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Logic.Interfaces
{
    internal interface ILoadData
    {
        public string OpenFile();
        public Data LoadDataFromFile(string path);
    }
}
