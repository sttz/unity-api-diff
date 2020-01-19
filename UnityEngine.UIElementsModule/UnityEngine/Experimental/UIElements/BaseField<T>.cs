using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class BaseField<T> : Experimental.UIElements.BindableElement, Experimental.UIElements.INotifyValueChanged<T>
{
    protected T m_Value;

    public T value { get; set; }

    public BaseField();

    public void OnPersistentDataReady();
    public void OnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<T>> callback);
    public void RemoveOnValueChanged(Experimental.UIElements.EventCallback<Experimental.UIElements.ChangeEvent<T>> callback);
    public void SetValueAndNotify(T newValue);
    public void SetValueWithoutNotify(T newValue);

    public class UxmlTraits<T> : UxmlTraits
    {
        public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
