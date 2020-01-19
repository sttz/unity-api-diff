using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class INotifyValueChangedExtensions
{
    static public bool RegisterValueChangedCallback<T>(UIElements.INotifyValueChanged<T> control, UIElements.EventCallback<UIElements.ChangeEvent<T>> callback);
    static public bool UnregisterValueChangedCallback<T>(UIElements.INotifyValueChanged<T> control, UIElements.EventCallback<UIElements.ChangeEvent<T>> callback);

}

}
