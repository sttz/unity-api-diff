using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class UxmlRootElementTraits : Experimental.UIElements.UxmlTraits
{
    public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

    public UxmlRootElementTraits();

}

}
