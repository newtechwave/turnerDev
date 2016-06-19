namespace turnerdevc.objects.Titles
{
    public class Genre :IGenre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TitleId { get; set; }
        
    }
}