using NoiseRemover.Logic.Interfaces;
using NoiseRemover.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Logic.Classes
{
    internal class PrintGraph : IPrintGraph
    {
        /// <summary>
        /// Метод отображение данных из файла json
        /// </summary>
        /// <param name="window"></param>
        public void PrintedGraph(MainWindow window)
        {
            ILoadData data = new LoadData();
            string path = data.OpenFile(); 
            if (!String.IsNullOrEmpty(path)) 
            {
                var jsonData = data.LoadDataFromFile(path); 

                float[] axisX, axisY; // Данные для осей графика

                axisY = GetSpeedDataFromJson(jsonData.Meterings); // Получние данных о скорости обьекта из файла json
                axisX = GetDistanceDataFromJson(jsonData.Meterings); // Получние данных о пройденном расстоянии из файла json

                window.WpfGraph.Reset();
                window.WpfGraph.Plot.Add.Scatter(axisX, axisY);
                window.WpfGraph.Refresh();                
            }
        }

        /// <summary>
        /// Получение данных по скорости объекта из json
        /// </summary>
        /// <param name="meterings"></param>
        /// <returns></returns>
        private float[] GetSpeedDataFromJson(Metering[] meterings)
        {
            float[] data;
            List<float> tmpData= new List<float>();
            foreach (var tmp in meterings)
            {
                tmpData.Add(tmp.Speed);
            }
            data = tmpData.ToArray();
            return data;
        }

        /// <summary>
        /// Получение данных по дистанции объекта из json
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        private float[] GetDistanceDataFromJson(Metering[] meterings)
        {
            float[] data;
            List<float> tmpData = new List<float>();
            foreach (var tmp in meterings)
            {
                tmpData.Add(tmp.Distance);
            }
            data = tmpData.ToArray();
            return data;
        }

        #region 
        //private float[] StretchDistanceData(Metering[] meterings)
        //{
        //    float[] data;
        //    List<float> tmp = new List<float>();
        //    float curDistance = 0;
        //    int count = 0;
        //    foreach (var e in meterings)
        //    {
        //        if (count != 0)
        //        {
        //            var difDistance = e.Distance - curDistance;
        //            var difDisnceStep = difDistance / 5;
        //            for (int i = 0; i < 5; i++)
        //            {
        //                tmp.Add(curDistance);
        //                curDistance += difDisnceStep;
        //            }
        //        }

        //        curDistance = e.Distance;
        //        tmp.Add(e.Distance);
        //        count++;
        //    }
        //    data = tmp.ToArray();
        //    return data;
        //}

        //private float[] StretchSpeedData(Metering[] meterings)
        //{
        //    float[] data;
        //    List<float> tmp = new List<float>();
        //    float curSpeed = 0;
        //    int count = 0;
        //    foreach (var e in meterings)
        //    {
        //        if (count != 0)
        //        {
        //            var difSpeed = e.Speed - curSpeed;
        //            var difSpeedStep = difSpeed / 5;
        //            for (int i = 0; i < 5; i++)
        //            {
        //                tmp.Add(curSpeed);
        //                curSpeed += difSpeedStep;
        //            }
        //        }

        //        curSpeed = e.Speed;
        //        tmp.Add(e.Speed);
        //        count++;
        //    }

        //    data = tmp.ToArray();
        //    return data;
        //}
        #endregion
    }
}
