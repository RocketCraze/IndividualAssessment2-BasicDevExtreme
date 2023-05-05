namespace SampleData
{
    using IndividualAssessment2_BasicDevExtreme.Models;

    using System;
    using System.Collections.Generic;

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
            new User {
                ID = 3,
                Name = "Michael",
                Surname = "Scott",
                BirthDate = new DateTime(1965, 3, 15),
                Age = 58
            },
            new User {
                ID = 4,
                Name = "Dwight",
                Surname = "Schrute",
                BirthDate = new DateTime(1970, 1, 20),
                Age = 53
            },
            new User {
                ID = 5,
                Name = "Jim",
                Surname = "Halpert",
                BirthDate = new DateTime(1978, 10, 1),
                Age = 45
            },
            new User {
                ID = 6,
                Name = "Pam",
                Surname = "Beesly",
                BirthDate = new DateTime(1973, 3, 25),
                Age = 50
            },
            new User {
                ID = 7,
                Name = "Ryan",
                Surname = "Howard",
                BirthDate = new DateTime(1979, 5, 5),
                Age = 44
            },
            new User {
                ID = 8,
                Name = "Kevin",
                Surname = "Malone",
                BirthDate = new DateTime(1968, 6, 1),
                Age = 55
            },
            new User {
                ID = 9,
                Name = "Eric",
                Surname = "Forman",
                BirthDate = new DateTime(1959, 5, 18),
                Age = 64
            },
            new User {
                ID = 10,
                Name = "Donna",
                Surname = "Pinciotti",
                BirthDate = new DateTime(1960, 2, 13),
                Age = 63
            },
            new User {
                ID = 11,
                Name = "Michael",
                Surname = "Kelso",
                BirthDate = new DateTime(1959, 8, 28),
                Age = 64
            },
            new User {
                ID = 12,
                Name = "Steven",
                Surname = "Hyde",
                BirthDate = new DateTime(1959, 11, 28),
                Age = 64
            },
            new User {
                ID = 13,
                Name = "Jackie",
                Surname = "Burkhart",
                BirthDate = new DateTime(1961, 9, 24),
                Age = 62
            },
            new User {
                ID = 14,
                Name = "Fez",
                Surname = "",
                BirthDate = new DateTime(1960, 8, 4),
                Age = 63
            },
        };
    }
}
