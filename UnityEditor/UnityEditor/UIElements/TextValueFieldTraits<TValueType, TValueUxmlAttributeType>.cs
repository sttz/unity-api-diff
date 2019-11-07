using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : UIElements.BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
    public TextValueFieldTraits();

    public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
