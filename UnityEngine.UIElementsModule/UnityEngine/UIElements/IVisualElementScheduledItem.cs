using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IVisualElementScheduledItem
{
    public UIElements.VisualElement element { get; }
    public bool isActive { get; }

    public UIElements.IVisualElementScheduledItem Every(long intervalMs);
    public void ExecuteLater(long delayMs);
    public UIElements.IVisualElementScheduledItem ForDuration(long durationMs);
    public void Pause();
    public void Resume();
    public UIElements.IVisualElementScheduledItem StartingIn(long delayMs);
    public UIElements.IVisualElementScheduledItem Until(Func<bool> stopCondition);

}

}
