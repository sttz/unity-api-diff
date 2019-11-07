using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class CurveField : UIElements.BaseField<AnimationCurve>
{
    static public string borderUssClassName;
    static public string contentUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Rect ranges { get; set; }
    public RenderMode renderMode { get; set; }
    public AnimationCurve value { get; set; }

    public CurveField();
    public CurveField(string label);

    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public void SetValueWithoutNotify(AnimationCurve newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.CurveField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<AnimationCurve>
    {
        public UxmlTraits();

    }

    public enum RenderMode
    {
        Texture = 0,
        Mesh = 1,
        Default = 0,
    }

}

}
