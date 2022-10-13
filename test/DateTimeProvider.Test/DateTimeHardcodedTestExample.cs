using Xunit;

namespace DateTimeProvider.Test;

public class DateTimeHardcodedTestExample
{
    [Fact]
    public void ShouldReturnGoodMorning_WhenCurrentTimeIsMorning()
    {
        var dateTimeExample = new DateTimeHardcodedExample();
        Assert.Equal("Good morning!", dateTimeExample.GetCurrentTimeMessage());
    }
    
    [Fact]
    public void ShouldReturnGoodAfternoon_WhenCurrentTimeIsAfternoon()
    {
        var dateTimeExample = new DateTimeHardcodedExample();
        Assert.Equal("Good afternoon!", dateTimeExample.GetCurrentTimeMessage());
    }
    
    [Fact]
    public void ShouldReturnGoodEvening_WhenCurrentTimeIsEvening()
    {
        var dateTimeExample = new DateTimeHardcodedExample();
        Assert.Equal("Good evening!", dateTimeExample.GetCurrentTimeMessage());
    }
}