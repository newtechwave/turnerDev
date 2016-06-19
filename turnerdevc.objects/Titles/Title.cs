using System;

namespace turnerdevc.objects.Titles
{
    public class Title :ITitle
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string OtherName { get; set; }
        public string OtherNameLanguage { get; set; }
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime ProcessedDate { get; set; }
    }
}