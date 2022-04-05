using Xunit;
using StudentApp;

namespace Student.Tests;

public class DiscipleTests
{
    [Fact]
    public void Test1()
    {
        // arrange
        var stud = new Disciple("Michal", "Kowalski");
        stud.AddGrade(15);
        stud.AddGrade(20);
        stud.AddGrade(30);

        // act
        var result = stud.GetStatistics();

        // asserts
        Assert.Equal(21.7, result.Average, 1);
        Assert.Equal(30, result.High);
        Assert.Equal(15, result.Low);
    }
}