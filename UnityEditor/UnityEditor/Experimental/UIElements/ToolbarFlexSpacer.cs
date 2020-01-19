using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarFlexSpacer : UnityEditor.Experimental.UIElements.ToolbarSpacer
{
    public ToolbarFlexSpacer();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarFlexSpacer>
    {
        public UxmlFactory();

    }

}

}
