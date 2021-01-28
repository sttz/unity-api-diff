using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class RadioButtonGroup : UIElements.BaseField<int>, UIElements.IGroupBox
{
    static public string ussClassName;

    public IEnumerable<string> choices { get; set; }

    public RadioButtonGroup();
    public RadioButtonGroup(string label, List<string> radioButtonChoices = null);

    public void SetValueWithoutNotify(int newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.RadioButtonGroup, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<int, UIElements.UxmlIntAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
