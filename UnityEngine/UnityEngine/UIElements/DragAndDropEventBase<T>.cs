using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class DragAndDropEventBase<T> : UIElements.MouseEventBase<T>, UIElements.IDragAndDropEvent
{
    protected DragAndDropEventBase();

}

}
