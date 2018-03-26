using System;
using Xunit;
using Project;

namespace ProjectTests
{
    public class PersonTests
    {
        [Fact]
        public void Can_CreatePerson_Object()
        {
            var person = new Person();

            Assert.True(person != null);
        }

        [Fact]
        public void Can_Set_FirstName_Of_A_Person()
        {
            var person = new Person();

            person.FirstName = "Dimitar";

            Assert.True(person.FirstName == "Dimitar");
        }

        [Fact]
        public void Can_Set_LastName_Of_A_Person()
        {
            var person = new Person();

            person.LastName = "Valkov";

            Assert.True(person.LastName == "Valkov");
        }
    }
}
