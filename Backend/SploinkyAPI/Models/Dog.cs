namespace SploinkyAPI.Models
{
    public class Dog : Animal
    {
        public int DogTest { get; set; } // for differenciating this type
        public Dog(int Id, string Name, AnimalColor Color, string PicturePath, int Test)
        { this.Id = Id; this.Name = Name; this.Color = Color; this.PicturePath = PicturePath; this.DogTest = Test; }
    }
}
