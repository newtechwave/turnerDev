﻿namespace turnerdevc.objects.Titles
{
    public class Storyline  : IStoryLine
    {
        public int TitleId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}