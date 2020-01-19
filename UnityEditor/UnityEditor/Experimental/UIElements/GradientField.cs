using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class GradientField : Experimental.UIElements.BaseField<Gradient>
{
    public Gradient value { get; set; }

    public GradientField();

    public void OnPersistentDataReady();
    public void SetValueAndNotify(Gradient newValue);
    public void SetValueWithoutNotify(Gradient newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.GradientField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Gradient>
    {
        public UxmlTraits();

    }

}

}
