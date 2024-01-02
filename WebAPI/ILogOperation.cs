namespace WebAPI;

public interface ILogOperation
{
    void Information<T>(string parameter);
    void Error<T>(string parameter);
}