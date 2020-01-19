using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IVisualElementScheduler
{
    public Experimental.UIElements.IVisualElementScheduledItem Execute(Action<Experimental.UIElements.TimerState> timerUpdateEvent);
    public Experimental.UIElements.IVisualElementScheduledItem Execute(Action updateEvent);

}

}
