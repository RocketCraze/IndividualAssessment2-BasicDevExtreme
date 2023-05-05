using IndividualAssessment2_BasicDevExtreme.Models;

namespace SampleData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SampleUsersData
    {
        public static readonly List<User> Users = new List<User>() {
            new User {
                ID = 1,
                Name = "Dean",
                Surname = "Winchester",
                BirthDate = new DateTime(1979, 1, 24),
                Age = 44
            },
            new User {
                ID = 2,
                Name = "Sam",
                Surname = "Winchester",
                BirthDate = new DateTime(1983, 5, 2),
                Age = 40
            },
        };
    }
}
