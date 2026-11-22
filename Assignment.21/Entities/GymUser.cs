namespace Assignment._21.Entities
{
    public class GymUser:BaseEntity<int>
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public DateTime DateOfBirth { set; get; }
        public Gender Gender { set; get; }
        public Address Address { set; get; }
    }
}
