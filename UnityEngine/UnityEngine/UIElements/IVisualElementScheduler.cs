using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IVisualElementScheduler
{
    public UIElements.IVisualElementScheduledItem Execute(Action<UIElements.TimerState> timerUpdateEvent);
    public UIElements.IVisualElementScheduledItem Execute(Action updateEvent);

}

}
