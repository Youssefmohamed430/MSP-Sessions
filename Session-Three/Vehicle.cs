using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Three
{
    public class vehicle
    {
        public string Name { get; set; }
    }
    public interface IVehicle
    {
        void Move();
        void Print();
    }
    public interface IVehicleV2
    {
        void MoveV2();
    }
    public class Car : vehicle , IVehicle ,IVehicleV2 
    {
        public void Move()
        {
            Console.WriteLine("Car Move");
        }

        public void MoveV2()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Bus : vehicle,  IVehicle ,IVehicleV2
    {
        public static int Count;
        public void Move()
        {
            Console.WriteLine("Bus Move");
        }

        public void MoveV2()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
}
