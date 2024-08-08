﻿using System.Threading;
using System.Threading.Tasks;

namespace Klab.Toolkit.Event;

/// <summary>
/// Marker interface for event handlers
/// </summary>
/// <typeparam name="TEvent"></typeparam>
public interface IEventHandler<in TEvent> where TEvent : IEvent
{
    /// <summary>
    /// Handle the event
    /// </summary>
    /// <param name="notification"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task Handle(TEvent notification, CancellationToken cancellationToken);
}
