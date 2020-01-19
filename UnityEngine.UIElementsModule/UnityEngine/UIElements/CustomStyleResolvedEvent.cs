using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class CustomStyleResolvedEvent : UIElements.EventBase<UIElements.CustomStyleResolvedEvent>
{
    public UIElements.ICustomStyle customStyle { get; }

    public CustomStyleResolvedEvent();

}

}
