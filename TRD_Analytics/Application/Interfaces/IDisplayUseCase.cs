namespace TRD_Analytics.Application;

public interface IDisplayUseCase
{
    void Execute<T>(List<T> inputs)
        where T : class;
}