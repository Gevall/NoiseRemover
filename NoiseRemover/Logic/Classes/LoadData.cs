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
        public static Data data;

        /// <summary>
        /// Диалог на открытие файла
        /// </summary>
        /// <returns>Путь к файлу</returns>
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
            if (String.IsNullOrEmpty(path))
            {
                //MessageBox.Show("Ошибка", "Не выбран файл!", MessageBoxButton.OK);
            }
            else
            {
                string json = File.ReadAllText(path);
                data = JsonConvert.DeserializeObject<Data>(json);
                //MessageBox.Show("Успех", "Файл успешно открыт!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return data;
        }
    }
}
