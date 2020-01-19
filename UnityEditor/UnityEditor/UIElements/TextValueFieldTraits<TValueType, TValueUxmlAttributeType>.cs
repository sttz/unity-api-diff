using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : UIElements.BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
    public TextValueFieldTraits();

    public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
