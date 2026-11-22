namespace Assignment._21.Entities
{
    public class Trainer:GymUser
    {
        // HireDate 
        public Speciality Speciality { set; get; }
        public ICollection<Session> Sessions { set; get; }
    }
}
