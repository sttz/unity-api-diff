using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ObjectField : Experimental.UIElements.BaseField<Object>
{
    public bool allowSceneObjects { get; set; }
    public int focusIndex { get; set; }
    public Type objectType { get; set; }

    public ObjectField();

    public void SetValueAndNotify(Object newValue);
    public void SetValueWithoutNotify(Object newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ObjectField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Object>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
