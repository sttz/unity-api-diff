using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface INotifyValueChanged<T>
{
    public T value { get; set; }

    public void SetValueWithoutNotify(T newValue);

}

}
