﻿namespace CQRS.Core.Events;

public class BaseEvent : BaseMessage
{
    protected BaseEvent(string type)
    {
        Type = type;
    }

    public string Type { get; set; }
    public int Version { get; set; }
}
