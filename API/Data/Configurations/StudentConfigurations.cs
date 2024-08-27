using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Smith",
                    PhoneNumber = "555-1234",
                    Email = "alice.smith@example.com",
                    BirthDate = new DateTime(2001, 5, 15),
                    StudentRegNumber = "STU10001"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Johnson",
                    PhoneNumber = "555-5678",
                    Email = "bob.johnson@example.com",
                    BirthDate = new DateTime(2000, 11, 20),
                    StudentRegNumber = "STU10002"
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Charlie",
                    LastName = "Brown",
                    PhoneNumber = "555-8765",
                    Email = "charlie.brown@example.com",
                    BirthDate = new DateTime(1999, 7, 23),
                    StudentRegNumber = "STU10003"
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Diana",
                    LastName = "Prince",
                    PhoneNumber = "555-9999",
                    Email = "diana.prince@example.com",
                    BirthDate = new DateTime(2002, 10, 10),
                    StudentRegNumber = "STU10004"
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Eva",
                    LastName = "Green",
                    PhoneNumber = "555-1122",
                    Email = "eva.green@example.com",
                    BirthDate = new DateTime(2003, 1, 25),
                    StudentRegNumber = "STU10005"
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Frank",
                    LastName = "Moore",
                    PhoneNumber = "555-2233",
                    Email = "frank.moore@example.com",
                    BirthDate = new DateTime(2004, 2, 14),
                    StudentRegNumber = "STU10006"
                },
                new Student
                {
                    Id = 7,
                    FirstName = "Grace",
                    LastName = "Lee",
                    PhoneNumber = "555-3344",
                    Email = "grace.lee@example.com",
                    BirthDate = new DateTime(2005, 3, 19),
                    StudentRegNumber = "STU10007"
                },
                new Student
                {
                    Id = 8,
                    FirstName = "Hannah",
                    LastName = "Wilson",
                    PhoneNumber = "555-4455",
                    Email = "hannah.wilson@example.com",
                    BirthDate = new DateTime(2006, 4, 12),
                    StudentRegNumber = "STU10008"
                },
                new Student
                {
                    Id = 9,
                    FirstName = "Ian",
                    LastName = "Taylor",
                    PhoneNumber = "555-5566",
                    Email = "ian.taylor@example.com",
                    BirthDate = new DateTime(2007, 5, 9),
                    StudentRegNumber = "STU10009"
                },
                new Student
                {
                    Id = 10,
                    FirstName = "Jasmine",
                    LastName = "Anderson",
                    PhoneNumber = "555-6677",
                    Email = "jasmine.anderson@example.com",
                    BirthDate = new DateTime(2008, 6, 15),
                    StudentRegNumber = "STU10010"
                }
            );
        }
    }
}
