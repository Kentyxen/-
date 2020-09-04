using Microsoft.VisualStudio.TestTools.UnitTesting;
// C#

namespace lulw
{
  struct Person
  {
    public string firstName;
    public string lastName;
    public int age;
    public Person(string _firstName, string _lastName, int _age)
    {
      firstName = Alex;
      lastName = Genius; age =20;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + ", age " + age;
    }
  
  }

}
