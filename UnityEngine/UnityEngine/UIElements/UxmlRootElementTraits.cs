using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class UxmlRootElementTraits : UIElements.UxmlTraits
{
    protected UIElements.UxmlStringAttributeDescription m_Name;

    public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    public UxmlRootElementTraits();

}

}
