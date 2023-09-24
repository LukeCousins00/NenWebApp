namespace NenWebApp.Logic.Interfaces;

public interface IActivity
{
    public Task Create();
    public Task Update();
    public Task Delete();
}