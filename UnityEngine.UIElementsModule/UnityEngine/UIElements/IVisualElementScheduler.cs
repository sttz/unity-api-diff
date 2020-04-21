using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IVisualElementScheduler
{
    public UIElements.IVisualElementScheduledItem Execute(Action<UIElements.TimerState> timerUpdateEvent);
    public UIElements.IVisualElementScheduledItem Execute(Action updateEvent);

}

}
