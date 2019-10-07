using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class IMGUIEvent : UIElements.EventBase<UIElements.IMGUIEvent>
{
    static public UIElements.IMGUIEvent GetPooled(Event systemEvent);

    public IMGUIEvent();

    protected void Init();

}

}
