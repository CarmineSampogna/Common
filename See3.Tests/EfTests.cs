using Microsoft.VisualStudio.TestTools.UnitTesting;
using See3.Common.Models;
using See3.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Tests
{
    [TestClass]
    public class EfTests
    {
        [TestMethod]
        public void CreatePerson()
        {
            using (var context = new PersonDbContext())
            {
                var person = new Person { FirstName = "Test", DateOfBirth = DateTime.Today };
                context.People.Add(person);
                context.SaveChanges();
                Assert.IsTrue(person.Id != Guid.Empty);
            }
        }
        
    }
}
