using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface ICustomStyle
{
    public bool TryGetValue(UIElements.CustomStyleProperty<float> property, out float value);
    public bool TryGetValue(UIElements.CustomStyleProperty<int> property, out int value);
    public bool TryGetValue(UIElements.CustomStyleProperty<bool> property, out bool value);
    public bool TryGetValue(UIElements.CustomStyleProperty<Color> property, out Color value);
    public bool TryGetValue(UIElements.CustomStyleProperty<Texture2D> property, out Texture2D value);
    public bool TryGetValue(UIElements.CustomStyleProperty<UIElements.VectorImage> property, out UIElements.VectorImage value);
    public bool TryGetValue(UIElements.CustomStyleProperty<string> property, out string value);

}

}
