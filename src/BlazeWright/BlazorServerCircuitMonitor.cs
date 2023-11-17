using Microsoft.AspNetCore.Components.Server.Circuits;

namespace BlazeWright;

internal sealed class BlazorServerCircuitMonitor : CircuitHandler
{
    private TaskCompletionSource circuitUpTcs = new();

    /// <summary>
    /// Gets a task that is completed when the Blazor Server SignalR connection has been established.
    /// </summary>
    public Task CircuitUp => circuitUpTcs.Task;

    // Ensure the circuit monitor is executed last.
    public override int Order { get; } = int.MaxValue;

    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        circuitUpTcs.TrySetResult();
        return base.OnConnectionUpAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        if (circuitUpTcs.Task.IsCompleted)
        {
            circuitUpTcs = new();
        }

        return base.OnConnectionDownAsync(circuit, cancellationToken);
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        if (circuitUpTcs.Task.IsCompleted)
        {
            circuitUpTcs = new();
        }

        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }
}

