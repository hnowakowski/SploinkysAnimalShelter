namespace SploinkyAPI.Models
{
    public class Cat : Animal
    {
        public int CatTest {  get; set; } // for differenciating this type
        public Cat(int Id, string Name, AnimalColor Color, string PicturePath, int Test) 
        { this.Id = Id; this.Name = Name; this.Color = Color; this.PicturePath = PicturePath; this.CatTest = Test; }

    }
}
