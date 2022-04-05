using Xunit;
using StudentApp;

namespace Student.Tests;

public class TypeTest
{
    [Fact]
    public void Test1()
    {
        var stud1 = GetDisciple("Michal");
        var stud2 = GetDisciple("Tomek");

        Assert.NotEqual(stud1, stud2);
        Assert.False(object.ReferenceEquals(stud1, stud2));
    }
    private Disciple GetDisciple(string name)
    {
        return new Disciple(name);
    }
}