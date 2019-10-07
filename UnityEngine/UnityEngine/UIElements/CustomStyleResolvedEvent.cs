using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class CustomStyleResolvedEvent : UIElements.EventBase<UIElements.CustomStyleResolvedEvent>
{
    public UIElements.ICustomStyle customStyle { get; }

    public CustomStyleResolvedEvent();

}

}
