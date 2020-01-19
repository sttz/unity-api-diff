using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IVisualElementScheduledItem
{
    public Experimental.UIElements.VisualElement element { get; }
    public bool isActive { get; }

    public Experimental.UIElements.IVisualElementScheduledItem Every(long intervalMs);
    public void ExecuteLater(long delayMs);
    public Experimental.UIElements.IVisualElementScheduledItem ForDuration(long durationMs);
    public void Pause();
    public void Resume();
    public Experimental.UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
    public Experimental.UIElements.IVisualElementScheduledItem Until(Func<bool> stopCondition);

}

}
