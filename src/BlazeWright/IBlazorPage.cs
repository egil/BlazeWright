namespace BlazorTestingAZ.Tests.BlazeWright;

public interface IBlazorPage : IPage
{
    /// <summary>
    /// Gets a task that is completed when the Blazor Server SignalR connection has been established.
    /// </summary>
    Task CircuitUp { get; }
}
