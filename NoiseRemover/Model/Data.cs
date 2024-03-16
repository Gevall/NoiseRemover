using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseRemover.Model
{
    internal class Data
    {
        public string Id { get; set; }
        public string IdTrace { get; set; }
        public bool IsFeed { get; set; }
        public int SlabType { get; set; }
        public DateTime DateReceipt { get; set; }
        public DateTime DateTrace { get; set; }
        public DateTime DateMeasuring { get; set; }
        public object ImageTagRef { get; set; }
        public bool IsRecord { get; set; }
        public Metering[] Meterings { get; set; }
        public State[] States { get; set; }
        public Distance[] Distances { get; set; }
        public int TraceXMin { get; set; }
        public int TraceXMax { get; set; }
        public float DistanceFactor { get; set; }
        public float OpticLengthFactor { get; set; }
        public float DeltaSpeed { get; set; }
        public float SpeedThreshold { get; set; }
        public float SNRThreshold { get; set; }
        public Lastmetering LastMetering { get; set; }
        public int ExpositionAdapting { get; set; }
        public Swcyclogram swCyclogram { get; set; }
        public float TempVelocimeter { get; set; }
        public bool IsByPass { get; set; }
        public bool IsComplete { get; set; }
        public bool IsRollback { get; set; }
        public string CompleteDesc { get; set; }
        public int TempSlab { get; set; }
        public int VideoWriterId { get; set; }
        public int ProfileCount { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float WidthLeft { get; set; }
        public float WidthRight { get; set; }
        public float Height { get; set; }
        public float HeightLeft { get; set; }
        public float HeightRight { get; set; }
        public float HeightCalculate { get; set; }
        public float WidthPlan { get; set; }
        public float WidthCalculate { get; set; }
        public float LengthPlan { get; set; }
        public float LengthSeries { get; set; }
        public float LengthCalculate { get; set; }
        public float Volume { get; set; }
        public float Weight { get; set; }
        public int MinCountProfilePoints { get; set; }
        public int MaxCountProfilePoints { get; set; }
        public int AvgCountProfilePoints { get; set; }
        public Profilometerstatistic[] ProfilometerStatistics { get; set; }
        public bool isPlanFind { get; set; }
        public bool isSeriesSlabsFind { get; set; }
        public float SNR { get; set; }
    }
}
