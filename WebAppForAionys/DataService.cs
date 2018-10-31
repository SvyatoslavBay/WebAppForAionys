using System.Collections.Generic;
using WebAppForAionys.Models;

namespace WebAppForAionys
{
    public static class DataService
    {
        public static List<Client> clients = new List<Client>
        {
            new Client
            {
                Id = 1,
                FirstName = "John",
                LastName = "Heart",
                Address = "New York, 351 Hill St.",
                PhoneNumbers = "89243854, 38243594",
                ClientTasks = new List<ClientTask>
                {
                    new ClientTask
                    {
                        Id = 1,
                        Name = "Cleaning",
                        Description = "High-quality cleaning in the hotel room",
                        Address = "Atlanta, 1700 Grandview Dr.",
                        StartTime = "15:00 PM",
                        EndTime = "20:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 2,
                        Name = "Washing",
                        Description = "Washing bed linen",
                        Address = "Los Angeles, 807 Paseo Del Mar",
                        StartTime = "11:00 AM",
                        EndTime = "14:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 3,
                        Name = "Haircut",
                        Description = "Two children haircut",
                        Address = "Chicago, 4 Westmoreland Pl.",
                        StartTime = "13:00 PM",
                        EndTime = "16:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 4,
                        Name = "Computer work",
                        Description = "Installation of Windows",
                        Address = "Washington, 25 Saint St.",
                        StartTime = "9:00 AM",
                        EndTime = "11:00 AM"
                    }
                }
            },
            new Client
            {
                Id = 2,
                FirstName = "Robert",
                LastName = "Reagan",
                Address = "Boise, 1120 Old Mill Rd.",
                PhoneNumbers = "87523384, 13987539",
                ClientTasks = new List<ClientTask>
                {
                    new ClientTask
                    {
                        Id = 5,
                        Name = "Cleaning",
                        Description = "High-quality cleaning in the hotel room",
                        Address = "Atlanta, 1700 Grandview Dr.",
                        StartTime = "15:00 PM",
                        EndTime = "20:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 6,
                        Name = "Washing",
                        Description = "Washing bed linen",
                        Address = "Los Angeles, 807 Paseo Del Mar",
                        StartTime = "11:00 AM",
                        EndTime = "14:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 7,
                        Name = "Haircut",
                        Description = "Two children haircut",
                        Address = "Chicago, 4 Westmoreland Pl.",
                        StartTime = "13:00 PM",
                        EndTime = "16:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 8,
                        Name = "Computer work",
                        Description = "Installation of Windows",
                        Address = "Washington, 25 Saint St.",
                        StartTime = "9:00 AM",
                        EndTime = "11:00 AM"
                    }
                }
            },
            new Client
            {
                Id = 3,
                FirstName = "Brett",
                LastName = "Wade",
                Address = "New York, 4600 Virginia Rd.",
                PhoneNumbers = "39725588, 36754236",
                ClientTasks = new List<ClientTask>
                {
                    new ClientTask
                    {
                        Id = 9,
                        Name = "Cleaning",
                        Description = "High-quality cleaning in the hotel room",
                        Address = "Atlanta, 1700 Grandview Dr.",
                        StartTime = "15:00 PM",
                        EndTime = "20:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 10,
                        Name = "Washing",
                        Description = "Washing bed linen",
                        Address = "Los Angeles, 807 Paseo Del Mar",
                        StartTime = "11:00 AM",
                        EndTime = "14:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 11,
                        Name = "Haircut",
                        Description = "Two children haircut",
                        Address = "Chicago, 4 Westmoreland Pl.",
                        StartTime = "13:00 PM",
                        EndTime = "16:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 12,
                        Name = "Computer work",
                        Description = "Installation of Windows",
                        Address = "Washington, 25 Saint St.",
                        StartTime = "9:00 AM",
                        EndTime = "11:00 AM"
                    }
                }
            },
            new Client
            {
                Id = 4,
                FirstName = "Sandra",
                LastName = "Johnson",
                Address = "San Diego, 424 Main St.",
                PhoneNumbers = "93723859, 78964546",
                ClientTasks = new List<ClientTask>
                {
                    new ClientTask
                    {
                        Id = 13,
                        Name = "Cleaning",
                        Description = "High-quality cleaning in the hotel room",
                        Address = "Atlanta, 1700 Grandview Dr.",
                        StartTime = "15:00 PM",
                        EndTime = "20:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 14,
                        Name = "Washing",
                        Description = "Washing bed linen",
                        Address = "Los Angeles, 807 Paseo Del Mar",
                        StartTime = "11:00 AM",
                        EndTime = "14:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 15,
                        Name = "Haircut",
                        Description = "Two children haircut",
                        Address = "Chicago, 4 Westmoreland Pl.",
                        StartTime = "13:00 PM",
                        EndTime = "16:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 16,
                        Name = "Computer work",
                        Description = "Installation of Windows",
                        Address = "Washington, 25 Saint St.",
                        StartTime = "9:00 AM",
                        EndTime = "11:00 AM"
                    }
                }
            },
            new Client
            {
                Id = 5,
                FirstName = "John",
                LastName = "Carter",
                Address = "Little Rock, 2211 Bonita Dr.",
                PhoneNumbers = "43624674, 57823142",
                ClientTasks = new List<ClientTask>
                {
                    new ClientTask
                    {
                        Id = 17,
                        Name = "Cleaning",
                        Description = "High-quality cleaning in the hotel room",
                        Address = "Atlanta, 1700 Grandview Dr.",
                        StartTime = "15:00 PM",
                        EndTime = "20:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 18,
                        Name = "Washing",
                        Description = "Washing bed linen",
                        Address = "Los Angeles, 807 Paseo Del Mar",
                        StartTime = "11:00 AM",
                        EndTime = "14:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 19,
                        Name = "Haircut",
                        Description = "Two children haircut",
                        Address = "Chicago, 4 Westmoreland Pl.",
                        StartTime = "13:00 PM",
                        EndTime = "16:00 PM"
                    },
                    new ClientTask
                    {
                        Id = 20,
                        Name = "Computer work",
                        Description = "Installation of Windows",
                        Address = "Washington, 25 Saint St.",
                        StartTime = "9:00 AM",
                        EndTime = "11:00 AM"
                    }
                }
            }
        };
    }
}
