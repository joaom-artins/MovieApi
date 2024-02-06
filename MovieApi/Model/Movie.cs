using MovieApi.Model.Enum;
using System.Text.Json.Serialization;

namespace MovieApi.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public Review Review { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }

    }
}
