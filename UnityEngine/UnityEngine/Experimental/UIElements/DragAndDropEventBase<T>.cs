using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class DragAndDropEventBase<T> : Experimental.UIElements.MouseEventBase<T>, Experimental.UIElements.IDragAndDropEvent, Experimental.UIElements.IPropagatableEvent
{
    protected DragAndDropEventBase();

}

}
