namespace UserManagement.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}