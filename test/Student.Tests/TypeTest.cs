using Xunit;
using StudentApp;

namespace Student.Tests;

public class TypeTest
{
    [Fact]
    public void GetStudentsReturnsDiffrentObjects()
    {
        var stud1 = GetDisciple("Michal", "Kowalski");
        var stud2 = GetDisciple("Tomek", "Kowalski");

        Assert.Equal("Michal Kowalski", stud1.FullName);
        Assert.Equal("Tomek Kowalski", stud2.FullName);
        Assert.NotSame(stud1, stud2);
        Assert.False(object.ReferenceEquals(stud1, stud2));
        Assert.False(Disciple.Equals(stud1, stud2));
    }

    [Fact]
    public void GetReferenceSameObjects()
    {
        var stud1 = GetDisciple("Michal", "Nowak");
        var stud2 = stud1;
        Assert.Equal("Michal Nowak", stud1.FullName);
        Assert.Equal("Michal Olesiak", stud2.FullName);
        Assert.Same(stud1, stud2);     
        Assert.True(object.ReferenceEquals(stud1, stud2));
        Assert.True(Disciple.Equals(stud1, stud2));

    }

    [Fact]
    public void CanSetNameFromReferency()
    {
        var stud1 = GetDisciple("Michal", "Kowalski");
        this.SetNameAndSurename(ref stud1, "Michal", "Nowak");
        Assert.Equal("Michal Nowak", stud1.FullName);
    }
    private Disciple GetDisciple(string name, string surename)
    {
        return new Disciple(name, surename);
    }
    private void SetNameAndSurename(ref Disciple disciple, string name, string surename)
    {
        disciple.FullName = name + " " + surename;
    }
}