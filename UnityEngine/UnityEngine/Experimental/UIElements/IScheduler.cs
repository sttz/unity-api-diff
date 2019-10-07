using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IScheduler
{
    public void Schedule(Experimental.UIElements.IScheduledItem item);
    public Experimental.UIElements.IScheduledItem ScheduleForDuration(Action<Experimental.UIElements.TimerState> timerUpdateEvent, long delayMs, long intervalMs, long durationMs);
    public Experimental.UIElements.IScheduledItem ScheduleOnce(Action<Experimental.UIElements.TimerState> timerUpdateEvent, long delayMs);
    public Experimental.UIElements.IScheduledItem ScheduleUntil(Action<Experimental.UIElements.TimerState> timerUpdateEvent, long delayMs, long intervalMs, Func<bool> stopCondition = null);
    public void Unschedule(Experimental.UIElements.IScheduledItem item);

}

}
