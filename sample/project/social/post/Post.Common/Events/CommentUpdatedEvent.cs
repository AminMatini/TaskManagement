﻿namespace Post.Common.Events;

public class CommentUpdatedEvent : BaseEvent
{
    public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
    {
    }

    public Guid CommentId { get; set; }
    public string Comment { get; set; } = null!;
    public string Username { get; set; } = null!;
    public DateTime EditDate { get; set; }
}
