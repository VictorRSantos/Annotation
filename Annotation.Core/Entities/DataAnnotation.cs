namespace Annotation.Core.Entities
{
    public class DataAnnotation : BaseEntity
    {
        public DataAnnotation(string systemName, string login, string password, string description)
        {
            SystemName = systemName;
            Login = login;
            Password = password;
            Description = description ?? "";
        }

        public string SystemName { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Description { get; private set; }

        public void Update(string systemName, string login, string password, string description)
        {
            SystemName=systemName;
            Login=login;
            Password=password;
            Description = description ?? "";
        }

    }
}
