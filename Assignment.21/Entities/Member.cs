namespace Assignment._21.Entities
{
    public class Member:GymUser
    {
        // JoinDate 
        public string? Photo {  set; get; }
        public ICollection<MemberShip> Members { set; get; }
    }
}
