﻿namespace MovieApi.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
