using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class SliderInt : Experimental.UIElements.BaseSlider<int>
{
    public float pageSize { get; set; }

    public SliderInt();
    public SliderInt(int start, int end, Experimental.UIElements.SliderDirection direction = 0, float pageSize = 0);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.SliderInt, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<int>
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
