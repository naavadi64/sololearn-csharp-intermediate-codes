using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }
    
    //implement IColor & IEquipment interfaces
    public class Car: IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }
        
        //reimplement this method
        public void GetColor()
        {
            Console.WriteLine($"Color: {color}");
        }
        //reimplement this method
        public void GetEquipment()
        {
            Console.WriteLine($"Equipment: {equipment}");
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        public interface IShape {
            void Draw();
            void Finish(){
                Console.WriteLine("Done!");
            }
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
            c.Finish();
        }
    }
}
*/