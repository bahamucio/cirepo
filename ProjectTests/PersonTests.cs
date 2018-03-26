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
        public void SetName_ChangesTheName_WhenCalled()
        {
            var person = new Person();

            person.Name = "Dimitar";

            Assert.True(person.Name == "Dimitar");
        }
    }
}
