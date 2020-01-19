using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements.Experimental
{

public interface ITransitionAnimations
{
    public UIElements.Experimental.ValueAnimation<Rect> Layout(Rect to, int durationMs);
    public UIElements.Experimental.ValueAnimation<Vector3> Position(Vector3 to, int duration);
    public UIElements.Experimental.ValueAnimation<Quaternion> Rotation(Quaternion to, int duration);
    public UIElements.Experimental.ValueAnimation<float> Scale(float to, int duration);
    public UIElements.Experimental.ValueAnimation<Vector2> Size(Vector2 to, int durationMs);
    public UIElements.Experimental.ValueAnimation<UIElements.Experimental.StyleValues> Start(UIElements.Experimental.StyleValues to, int durationMs);
    public UIElements.Experimental.ValueAnimation<UIElements.Experimental.StyleValues> Start(UIElements.Experimental.StyleValues from, UIElements.Experimental.StyleValues to, int durationMs);
    public UIElements.Experimental.ValueAnimation<float> Start(float from, float to, int durationMs, Action<UIElements.VisualElement, float> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Color> Start(Color from, Color to, int durationMs, Action<UIElements.VisualElement, Color> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Quaternion> Start(Quaternion from, Quaternion to, int durationMs, Action<UIElements.VisualElement, Quaternion> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Rect> Start(Rect from, Rect to, int durationMs, Action<UIElements.VisualElement, Rect> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Vector2> Start(Vector2 from, Vector2 to, int durationMs, Action<UIElements.VisualElement, Vector2> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Vector3> Start(Vector3 from, Vector3 to, int durationMs, Action<UIElements.VisualElement, Vector3> onValueChanged);
    public UIElements.Experimental.ValueAnimation<float> Start(Func<UIElements.VisualElement, float> fromValueGetter, float to, int durationMs, Action<UIElements.VisualElement, float> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Color> Start(Func<UIElements.VisualElement, Color> fromValueGetter, Color to, int durationMs, Action<UIElements.VisualElement, Color> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Quaternion> Start(Func<UIElements.VisualElement, Quaternion> fromValueGetter, Quaternion to, int durationMs, Action<UIElements.VisualElement, Quaternion> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Rect> Start(Func<UIElements.VisualElement, Rect> fromValueGetter, Rect to, int durationMs, Action<UIElements.VisualElement, Rect> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Vector2> Start(Func<UIElements.VisualElement, Vector2> fromValueGetter, Vector2 to, int durationMs, Action<UIElements.VisualElement, Vector2> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Vector3> Start(Func<UIElements.VisualElement, Vector3> fromValueGetter, Vector3 to, int durationMs, Action<UIElements.VisualElement, Vector3> onValueChanged);
    public UIElements.Experimental.ValueAnimation<Vector2> TopLeft(Vector2 to, int durationMs);

}

}
