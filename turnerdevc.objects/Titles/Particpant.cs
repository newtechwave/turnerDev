namespace turnerdevc.objects.Titles
{
    public class Particpant : IParticpant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParticipantType { get; set; }
        public string RoleType { get; set; }
        public bool IsKey { get; set; }
        public bool IsOnScreen { get; set; }
    }
}