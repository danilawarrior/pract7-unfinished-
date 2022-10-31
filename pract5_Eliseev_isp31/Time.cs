using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7_Eliseev_isp31
{
    class Time : Triad
    {
        int _hour;
        int _minute;
        int _second;

        public Time(int first, int second, int third) : base(first, second, third)
        {
            Hour = first;
            Minute = second;
            Second = third;
        }


        public int Hour { get => _hour; set => _hour = value; }
        public int Minute
        {
            get => _minute; set
            {
                if (value > 59)
                {
                    var time = ConvertTo(value);
                    Hour += time.time1;
                    _minute = time.time2;
                    return;
                }
                _minute = value;
            }
        }
        public int Second
        {
            get => _second; set
            {

                if (value > 59)
                {
                    var time = ConvertTo(value);
                    Minute += time.time1;
                    _second = time.time2;
                    return;
                }
                _second = value;
            }
        }

        private (int time1, int time2) ConvertTo(int value)
        {
            int minute = value / 60;
            int second = value % 60;
            return (minute, second);
        }


        public bool Comparsion(Time value)
        {
            return Hour == value.Hour && Minute == value.Minute && Second == value.Second;
        }

        public bool ComparisonOfThree(Time t1, Time t2)
        {
            return Equality(t1) && Hour == t2.Hour && Minute == t2.Minute && Second == t1.Second;
        }


    }
}
