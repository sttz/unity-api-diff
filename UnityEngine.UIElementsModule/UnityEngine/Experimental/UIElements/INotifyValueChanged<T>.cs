using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface INotifyValueChanged<T>
{
    public T value { get; set; }

    public void OnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<T>> callback);
    public void RemoveOnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<T>> callback);
    public void SetValueAndNotify(T newValue);
    public void SetValueWithoutNotify(T newValue);

}

}
