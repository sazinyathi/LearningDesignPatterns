using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Abstration
{
    /// <AbstractionDefination>
    /// it used to limit complexity think remote control for video machine
    /// We should show only 
    /// </AbstractionDefination>
    public class VideoMachine
    {
        private int _volume = 0;
        public List<int> Volume { get; set; } = new List<int>();
        public int VolumeMaxOrMin
        {
            get { return this._volume; }

            set
            {
                this._volume = value;
            }
        }
        public VideoMachine(int volume)
        {
            this._volume = volume;
        }
        public void DecreaseVolume()
        {
            Push(_volume);
        }
        public void IncreaseVolume()
        {
            var i = Pop(_volume);
            this.VolumeMaxOrMin = i;
        }
        // Implementation Details
        private int Pop(int n)
        {
          return  Volume.Count - n;
        }

        // Implementation Details
        private void Push(int number)
        {
            Volume.Add(number);
        }
    }
}
