using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.EF_Practice.EF_Practice__New_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.UnitTests
{

     [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void SavePerson()
        {
            string conn = "data source=.;initial catalog=SportStore;integrated security=False;user id=sa;password=Bayer124!;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            using (var context = new EF6RecipesContext())
            {
                var person = new Person
                {
                    FirstName = "Robert",
                    MiddleName = "Allen",
                    LastName = "Doe",
                    PhoneNumber = "867-5309"
                };
                context.People.Add(person);

                person = new Person
                {
                    FirstName = "John",
                    MiddleName = "K.",
                    LastName = "Smith",
                    PhoneNumber = "824-3031"
                };
                context.People.Add(person);

                person = new Person
                {
                    FirstName = "Billy",
                    MiddleName = "Albert",
                    LastName = "Minor",
                    PhoneNumber = "907-2212"
                };
                context.People.Add(person);

                person = new Person
                {
                    FirstName = "Kathy",
                    MiddleName = "Anne",
                    LastName = "Ryan",
                    PhoneNumber = "722-0038"
                };
                context.People.Add(person);

                context.SaveChanges();
            }
        }
    }
}
