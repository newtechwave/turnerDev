namespace turnerdevc.objects.Titles
{
    public class Award : IAward
    {
        public int TitleId { get; set; }
        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        public string AwardName { get; set; }
        public string AwardCompany { get; set; }
        public int Id { get; set; }

    }
}