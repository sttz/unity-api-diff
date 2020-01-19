using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlRootElementTraits : UIElements.UxmlTraits
{
    protected UIElements.UxmlStringAttributeDescription m_Name;

    public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    public UxmlRootElementTraits();

}

}
