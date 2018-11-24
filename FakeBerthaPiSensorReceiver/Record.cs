using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBerthaPiSensorReceiver
{
    public class Record
    {  

        public double Long { get; set; }

        public double Lat { get; set; }

        public double? BPSystolic { get; set; }

        public double? BPDiastolic { get; set; }

        public double? BodyTemperature { get; set; }

        public int? HeartBeatPerSecond { get; set; }

        public double? Dust { get; set; }

        public double? Sulphur { get; set; }

        public double? Nitrogen { get; set; }

        public double? Fluor { get; set; }

        public double? CarbonMonoxide { get; set; }

        public double? Ozone { get; set; }

        public int UserID { get; set; }

        public Record(double _long, double _lat, double _bpsystolic, double _bpdiastolic, double _bodytemperature, int _heartbeatpersecond, double _dust, double _sulphur, double _nitrogen, double _fluor, double _carbonmonoxide, double _ozone, int _userId)
        {
            Long = _long;
            Lat = _lat;
            BPSystolic = _bpsystolic;
            BPDiastolic = _bpdiastolic;
            BodyTemperature = _bodytemperature;
            HeartBeatPerSecond = _heartbeatpersecond;
            Dust = _dust;
            Sulphur = _sulphur;
            Nitrogen = _nitrogen;
            Fluor = _fluor;
            CarbonMonoxide = _carbonmonoxide;
            Ozone = _ozone;
            UserID = _userId;
        }
 
    }
}
