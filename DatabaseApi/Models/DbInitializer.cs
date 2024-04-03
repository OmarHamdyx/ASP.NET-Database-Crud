using Microsoft.EntityFrameworkCore;

namespace DatabaseApi.Models
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this._modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            _modelBuilder.Entity<Nationality>().HasData(
                new Nationality
                {
                    NationalityId = 9922111,
                    NationalityName = "Indian"
                }, new Nationality
                {
                    NationalityId = 8822111,
                    NationalityName = "Egyptian"
                }, new Nationality
                {
                    NationalityId = 7722111,
                    NationalityName = "Saudi"
                });


            _modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 111,
                    Name = "Naveen",
                    Age = 28,
                    NationalityId = 9922111,
                    BirthDate = DateTime.Parse("1996/02/27")

                }, new Person
                {
                    PersonId = 222,
                    Name = "Umar",
                    Age = 30,
                    NationalityId = 8822111,
                    BirthDate = DateTime.Parse("1994/01/01")

                }, new Person
                {
                    PersonId = 333,
                    Name = "Qasem",
                    Age = 32,
                    NationalityId = 7722111,
                    BirthDate = DateTime.Parse("1992/02/07")

                }
                );



        }
    }



}
