namespace WebAPI;

public class LogOperation : ILogOperation
{
    private readonly ILogger<LogOperation> _logger;

    public LogOperation(ILogger<LogOperation> logger)
    {
        _logger = logger;
    }

    public void Information<T>(string parameter)
    {
        if(!string.IsNullOrEmpty(parameter))
            _logger.LogInformation("[{0}]<{1}> - {2}", DateTimeOffset.Now, typeof(T), parameter);
    }

    public void Error<T>(string parameter)
    {
        if(!string.IsNullOrEmpty(parameter))
            _logger.LogError("[{0}]<{1}> - {2}", DateTimeOffset.Now, typeof(T), parameter);
    }
}