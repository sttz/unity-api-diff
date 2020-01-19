using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlAttributeOverridesTraits : UIElements.UxmlTraits
{
    public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    public UxmlAttributeOverridesTraits();

}

}
