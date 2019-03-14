using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace TiltApp
{
    public class TiltAppViewModel
    {
        public String XYZ { get; set; }

        public TiltAppViewModel()
        {
            StopCommand = new Command(Stop);
            StartCommand = new Command(Start);
        }

        public Command StartCommand { get; }
        public Command StopCommand { get; }

        void Stop()
        {
            OrientationSensor.Stop();
            OrientationSensor.ReadingChanged -= Orientation_ReadingChanged;
        }

        void Start()
        {
            OrientationSensor.ReadingChanged += Orientation_ReadingChanged;
            OrientationSensor.Start(SensorSpeed.UI);
        }

        void Orientation_ReadingChanged(Object sender, OrientationSensorChangedEventArgs e)
        {
            XYZ = e.Reading + "";
        }


    }
}
