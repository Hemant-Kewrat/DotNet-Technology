using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab4.Time;

namespace lab4
{
    internal class Time
    {
        
        
        int hour, min, sec;
            public Time() 
            { 

            }
            public Time(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }
            public Time addTime(Time t)
            {
                Time temp = new Time();
                temp.hour = hour + t.hour;
                temp.min = min + t.min;
                temp.sec = sec + t.sec;
                if(temp.sec >= 60)
                {
                    temp.sec = temp.sec-60;
                    temp.min= temp.min+1;
                }
                if(temp.min>=60)
                {
                    temp.min = temp.min-60;
                    temp.hour= temp.hour+1;
                }
                return temp;
            }
            
            public Time subTime(Time t)
            {
                Time temp1 = new Time();
                if (hour > t.hour)
                {
                    temp1.hour = hour - t.hour;
                    temp1.min = min - t.min;
                    temp1.sec = sec - t.sec;
                }
                else
                {
                    temp1.hour = t.hour - hour;
                    temp1.min = t.min - min;
                    temp1.sec = t.sec - sec;
                }
                if (temp1.sec < 0)
                {
                    temp1.sec = temp1.sec + 60;
                    temp1.min = temp1.min - 1;
                }
                if (temp1.min < 0)
                {
                    temp1.min = temp1.min + 60;
                    temp1.hour = temp1.hour - 1;
                }
                return temp1;
            }
        public void display()
        {
            Console.WriteLine(hour + ":" + min + ":" + sec);
        }

    }
    }
    

