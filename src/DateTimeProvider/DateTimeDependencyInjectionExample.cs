namespace DateTimeProvider;

public class DateTimeDependencyInjectionExample
{
    private readonly IDateTimeProvider _dateTimeProvider;

    public DateTimeDependencyInjectionExample(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public string GetCurrentTimeMessage()
    {
        var currentTime = _dateTimeProvider.Now;
        return currentTime.Hour switch
        {
            >= 8 and < 12 => "Good morning!",
            < 18 => "Good afternoon!",
            _ => "Good evening!"
        };
    }
}