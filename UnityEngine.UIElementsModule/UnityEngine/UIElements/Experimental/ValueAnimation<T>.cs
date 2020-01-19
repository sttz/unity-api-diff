using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements.Experimental
{

public sealed class ValueAnimation<T> : UIElements.Experimental.IValueAnimationUpdate, UIElements.Experimental.IValueAnimation
{
    static public UIElements.Experimental.ValueAnimation<T> Create(UIElements.VisualElement e, Func<T, T, float, T> interpolator);

    public bool autoRecycle { get; set; }
    public int durationMs { get; set; }
    public Func<float, float> easingCurve { get; set; }
    public T from { get; set; }
    public Func<UIElements.VisualElement, T> initialValue { get; set; }
    public Func<T, T, float, T> interpolator { get; set; }
    public bool isRunning { get; private set; }
    public Action onAnimationCompleted { get; set; }
    public T to { get; set; }
    public Action<UIElements.VisualElement, T> valueUpdated { get; set; }

    public ValueAnimation();

    public UIElements.Experimental.ValueAnimation<T> Ease(Func<float, float> easing);
    public UIElements.Experimental.ValueAnimation<T> KeepAlive();
    public UIElements.Experimental.ValueAnimation<T> OnCompleted(Action callback);
    public void Recycle();
    public void Start();
    public void Stop();

}

}
