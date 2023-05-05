namespace IndividualAssessment2_BasicDevExtreme.Models 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class SampleUsersData {
        public static List<User> Users = new List<User>() {
            new User {
                ID = 10248,
                Name = "Dean",
                Surname = "Winchester",
                BirthDate = new DateTime(1979, 1, 24),
                Age = 44
            },
            new User {
                ID = 10249,
                Name = "Sam",
                Surname = "Winchester",
                BirthDate = new DateTime(1983, 5, 2),
                Age = 40
            },
        };
    }
}
