using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_app
{
    public class Boiler
    {
        public string Brand { get; set; }
        private byte voltage;
        public byte Voltage
        {
            get { return voltage; }
            set
            {
                // 110v과 220v만 저장할 수 있도록 처리
                if (value == 110 || value == 220)
                {
                    voltage = value;
                }
                else
                {
                    Console.WriteLine("110v 또는 220v만 가능합니다.");
                }
            }    
        }

        private int temperature;
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                // 물온도는 5도 이하면 5도로, 70도 이상이면 70도로 제한
                if (value <= 5 )
                {
                    this.temperature = 5;
                }
                else if (value >= 70)
                {
                    this.temperature = 70;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }
        public void PrintAll()
            {
                Console.WriteLine($"Brand: {Brand} Voltage: {Voltage} Temperature: {Temperature}");
            }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
            Boiler kitturami0 = new Boiler { Brand = "귀뚜라미0", Voltage = 20, Temperature = 3 };
            kitturami.PrintAll();
        }
    }
}
