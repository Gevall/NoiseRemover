using Microsoft.Win32;
using Newtonsoft.Json;
using NoiseRemover.Logic.Interfaces;
using NoiseRemover.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NoiseRemover.Logic
{
    internal class LoadData : ILoadData
    {

        public string OpenFile()
        {
            var path = string.Empty;
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.InitialDirectory = "C:\\";
            dlg.DefaultExt= ".json";
            dlg.Filter = "json file (.json)|*.json";
            dlg.RestoreDirectory= true;
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                return dlg.FileName;
            }
            return path;
        }

        public Data LoadDataFromFile(string path)
        {
            Data data = new();
            if (!String.IsNullOrEmpty(path))
            {
                try 
                { 
                    string json = File.ReadAllText(path);
                    data = JsonConvert.DeserializeObject<Data>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!", ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return data;
        }
    }
}
