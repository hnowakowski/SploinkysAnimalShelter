namespace SploinkyAPI.Models
{
    public class Cat : Animal
    {
        public int Test {  get; set; }
        public Cat(int Id, string Name, int Test) { this.Id = Id; this.Name = Name; this.Test = Test; }

    }
}
