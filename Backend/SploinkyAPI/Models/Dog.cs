namespace SploinkyAPI.Models
{
    public class Dog : Animal
    {
        public DogBreed Breed;

        public override int Purchase(User user)
        {
            throw new NotImplementedException();
        }

        public override Dog LoadFromDb(int Id)
        {
            throw new NotImplementedException();
        }

        public Dog(int Id, string Name, DogBreed Breed, string PicturePath)
        { this.Id = Id; this.Name = Name; this.Breed = Breed; this.PicturePath = PicturePath; }
    }
}
