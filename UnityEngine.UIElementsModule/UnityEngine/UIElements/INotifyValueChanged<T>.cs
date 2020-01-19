using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface INotifyValueChanged<T>
{
    public T value { get; set; }

    public void SetValueWithoutNotify(T newValue);

}

}
