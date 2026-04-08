using System.Diagnostics.CodeAnalysis;

namespace SploinkyAPI.Models
{
    public abstract class Animal
    {
        [NotNull]
        public int Id { get; protected set; }
        [NotNull]
        public string Name { get; set; } = String.Empty;
    }
}
