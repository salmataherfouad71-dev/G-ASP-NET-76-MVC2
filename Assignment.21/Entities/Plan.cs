namespace Assignment._21.Entities
{
    public class Plan :BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> Plans { get; set; }
    }
}
