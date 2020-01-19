using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DragExitedEvent : UIElements.DragAndDropEventBase<UIElements.DragExitedEvent>
{
    static public UIElements.DragExitedEvent GetPooled(Event systemEvent);

    public DragExitedEvent();

    protected void Init();

}

}
