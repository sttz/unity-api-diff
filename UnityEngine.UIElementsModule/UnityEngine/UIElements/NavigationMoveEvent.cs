using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class NavigationMoveEvent : UIElements.NavigationEventBase<UIElements.NavigationMoveEvent>
{
    static public UIElements.NavigationMoveEvent GetPooled(Vector2 moveVector);

    public Direction direction { get; private set; }
    public Vector2 move { get; private set; }

    public NavigationMoveEvent();

    protected void Init();

    public enum Direction
    {
        None = 0,
        Left = 1,
        Up = 2,
        Right = 3,
        Down = 4,
    }

}

}
