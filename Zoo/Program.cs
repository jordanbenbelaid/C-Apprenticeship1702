using System.Drawing;
using System.Runtime.InteropServices;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dog GermanShepherd = new Dog("Doggo", 1, "Brown", "German Shepherd", true);
            Dog Doberman = new Dog("Doge", 2, "Black", "Doberman", true);
            Dog Rottweiler = new Dog("Doggy", 3, "Brown and Black", "Rottweiler", true);
            Dog Labrador = new Dog("Dog", 4, "White", "Labrador", true);

            Cat Sphynx = new Cat(5, "Grey", "Sphynx", true, true);
            Cat Siamese = new Cat(6, "White", "Siamese", true, true);
            Cat MaineCoon = new Cat(7, "Brown and White", "Maine Coon", true, true);
            Cat Burmese = new Cat(8, "Brown", "Burmese", true, true);

            Zoo zoo = new Zoo();

            zoo.AddAnimalToList(GermanShepherd);
            zoo.AddAnimalToList(Doberman);
            zoo.AddAnimalToList(Rottweiler);
            zoo.AddAnimalToList(Labrador);
            zoo.AddAnimalToList(Sphynx);
            zoo.AddAnimalToList(Siamese);
            zoo.AddAnimalToList(MaineCoon);
            zoo.AddAnimalToList(Burmese);

            zoo.calculateBillByType(new Cat());

            
        }
    }
}
