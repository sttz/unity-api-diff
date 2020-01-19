using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class CurveField : Experimental.UIElements.BaseField<AnimationCurve>
{
    public Rect ranges { get; set; }
    public RenderMode renderMode { get; set; }
    public AnimationCurve value { get; set; }

    public CurveField();

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    public void OnPersistentDataReady();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle style);
    public void SetValueAndNotify(AnimationCurve newValue);
    public void SetValueWithoutNotify(AnimationCurve newValue);

    public enum RenderMode
    {
        Texture = 0,
        Default = 0,
        Mesh = 1,
    }

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.CurveField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<AnimationCurve>
    {
        public UxmlTraits();

    }

}

}
