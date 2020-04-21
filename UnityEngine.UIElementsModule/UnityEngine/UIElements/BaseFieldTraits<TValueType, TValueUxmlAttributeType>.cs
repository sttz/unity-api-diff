using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : UxmlTraits<TValueType>
{
    public BaseFieldTraits();

    public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

}

}
