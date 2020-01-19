using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class DragAndDropEventBase<T> : UIElements.MouseEventBase<T>, UIElements.IDragAndDropEvent
{
    protected DragAndDropEventBase();

}

}
