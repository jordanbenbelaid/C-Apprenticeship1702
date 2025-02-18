using System.Text;

namespace EnumDemo1702
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            

            Directions direction = Directions.NORTH;

            switch (direction)
            {
                case Directions.NORTH:
                    Console.WriteLine("You are travelling North");
                    break;
                case Directions.EAST:
                    Console.WriteLine("You are travelling East");
                    break;
                case Directions.SOUTH:
                    Console.WriteLine("You are travelling South");
                    break;
                case Directions.WEST:
                    Console.WriteLine("You are travelling West");
                    break;
            }


        }
    }
}
