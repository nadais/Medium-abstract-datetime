using System;
using NSubstitute;
using Xunit;

namespace DateTimeProvider.Test;

public class DateTimeDependencyInjectionExampleTest
{
    private readonly IDateTimeProvider _dateTimeProvider = Substitute.For<IDateTimeProvider>();
    
    [Fact]
    public void ShouldReturnGoodMorning_WhenProvidedTimeIsMorning()
    {
        _dateTimeProvider.Now.Returns(new DateTime(2022, 10, 21, 9, 0, 0));
        var dateTimeExample = new DateTimeDependencyInjectionExample(_dateTimeProvider);
        Assert.Equal("Good morning!", dateTimeExample.GetCurrentTimeMessage());
    }
    
    [Fact]
    public void ShouldReturnGoodAfternoon_WhenProvidedTimeIsAfternoon()
    {
        _dateTimeProvider.Now.Returns(new DateTime(2022, 10, 21, 13, 0, 0));
        var dateTimeExample = new DateTimeDependencyInjectionExample(_dateTimeProvider);
        Assert.Equal("Good afternoon!", dateTimeExample.GetCurrentTimeMessage());
    }
    
    [Fact]
    public void ShouldReturnGoodEvening_WhenProvidedTimeIsEvening()
    {
        _dateTimeProvider.Now.Returns(new DateTime(2022, 10, 21, 19, 0, 0));
        var dateTimeExample = new DateTimeDependencyInjectionExample(_dateTimeProvider);
        Assert.Equal("Good evening!", dateTimeExample.GetCurrentTimeMessage());
    }
}