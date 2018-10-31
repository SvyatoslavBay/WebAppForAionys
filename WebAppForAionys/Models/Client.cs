using System.Collections.Generic;

namespace WebAppForAionys.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public List<ClientTask> ClientTasks { get; set; }
    }

    public class ClientTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
