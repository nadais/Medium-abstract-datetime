namespace DateTimeProvider;

public class DateTimeExample
{
    public string GetCurrentTimeMessage()
    {
        var currentTime = DateTime.Now;
        return currentTime.Hour switch
        {
            >= 8 and < 12 => "Good morning!",
            < 18 => "Good afternoon!",
            _ => "Good evening!"
        };
    }

    public string GetCurrentTimeMessage(IDateTimeProvider dateTimeProvider)
    {
        var currentTime = dateTimeProvider.Now;
        return currentTime.Hour switch
        {
            >= 8 and < 12 => "Good morning!",
            < 18 => "Good afternoon!",
            _ => "Good evening!"
        };
    }
}