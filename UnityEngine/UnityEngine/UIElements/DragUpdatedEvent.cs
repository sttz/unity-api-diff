using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DragUpdatedEvent : UIElements.DragAndDropEventBase<UIElements.DragUpdatedEvent>
{
    static public UIElements.DragUpdatedEvent GetPooled(Event systemEvent);

    public DragUpdatedEvent();

}

}
