using Microsoft.VisualBasic;

namespace ClinicDemo.Models
{
    public class Seeding
    {
        public static List<Client> clients = new List<Client>
        {
           new Client
           {
               Id = 1,
               Name = "yasir",
               DateOfBirth = new DateOnly(1990, 1, 1),
           },
           new Client
           {
               Id = 2,
               Name = "jhon",
               DateOfBirth = new DateOnly(1984,4,12)
           },
           new Client
           {
               Id = 3,
               Name = "danial",
               DateOfBirth = new DateOnly(1988,5,12)
           }
        };
} }
