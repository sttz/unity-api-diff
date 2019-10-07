using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class INotifyValueChangedExtensions
{
    static public bool RegisterValueChangedCallback(UIElements.INotifyValueChanged<T> control, UIElements.EventCallback<UIElements.ChangeEvent<T>> callback);
    static public bool UnregisterValueChangedCallback(UIElements.INotifyValueChanged<T> control, UIElements.EventCallback<UIElements.ChangeEvent<T>> callback);

}

}
