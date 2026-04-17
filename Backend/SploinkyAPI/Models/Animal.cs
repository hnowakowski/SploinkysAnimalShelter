using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace SploinkyAPI.Models
{
    [JsonPolymorphic]
    [JsonDerivedType(typeof(Cat))] // <-- needed so that polymorphism actually works in the api responses
    [JsonDerivedType(typeof(Dog))]
    public abstract class Animal : IPurchasable, IDbItem<Animal>
    {
        [NotNull]
        public int Id { get; protected set; }
        [NotNull]
        public string Name { get; protected set; } = String.Empty;
        public string PicturePath { get; protected set; } = String.Empty;

        public abstract int Purchase(User user);
        public abstract IDbItem<Animal> LoadFromDb(int Id);
    }
}
