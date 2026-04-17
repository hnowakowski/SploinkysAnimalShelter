namespace SploinkyAPI.Models
{
    public class Cat : Animal
    {
        public CatColor Color { get; private set; }

        public override int Purchase(User user)
        {
            throw new NotImplementedException();
        }

        public override Cat LoadFromDb(int Id)
        {
            throw new NotImplementedException();
        }
        public Cat(int Id, string Name, CatColor Color, string PicturePath, int Test) 
        { this.Id = Id; this.Name = Name; this.Color = Color; this.PicturePath = PicturePath; }

    }
}
