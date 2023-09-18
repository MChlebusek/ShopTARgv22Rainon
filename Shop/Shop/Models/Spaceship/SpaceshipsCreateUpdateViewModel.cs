namespace Shop.Models.Spaceship
{
    public class SpaceshipsCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Passengers { get; set; }
        public int EnginePower { get; set; }
        public int Crew { get; set; }
        public int Company { get; set; }
        public int CargoWeight { get; set; }
        public object CreatedAt { get; internal set; }
        public object ModifiedAt { get; internal set; }
    }
}
