using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace SploinkyAPI.Models
{
    [JsonPolymorphic]
    [JsonDerivedType(typeof(Cat))] // <-- needed so that polymorphism actually works in the api responses
    public abstract class Animal
    {
        [NotNull]
        public int Id { get; protected set; }
        [NotNull]
        public string Name { get; protected set; } = String.Empty;
        [NotNull]
        public AnimalColor Color { get; protected set; }
        public string PicturePath { get; protected set; } = String.Empty;
    }
}
