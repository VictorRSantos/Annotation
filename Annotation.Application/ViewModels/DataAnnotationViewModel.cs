namespace Annotation.Application.ViewModels
{
    public class DataAnnotationViewModel
    {
        public DataAnnotationViewModel(int id, string systemName, string login, string password, string description)
        {
            Id = id;
            SystemName = systemName;
            Login = login;
            Password = password;
            Description = description;
        }

        public int Id { get; set; }
        public string SystemName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }


    }
}
