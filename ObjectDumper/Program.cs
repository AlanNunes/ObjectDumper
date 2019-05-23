using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            BodyType bodyType = new BodyType()
            {
                Name = "Body Builder"
            };
            Person bambam = new Person()
            {
                Name = "Bambam",
                Age = 37,
                BodyType = bodyType
            };
            string result = "";
            ObjectDumper.Dump(bambam, ref result, 3);
            Console.Write(result);
            Console.Read();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public BodyType BodyType { get; set; }
        public void NoWaterWithMuscles()
        {
            Console.WriteLine("It's no water with muscles!!!");
        }
    }
    class BodyType
    {
        public string Name { get; set; }
    }
}
