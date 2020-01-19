using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IResolvedStyle
{
    public UIElements.Align alignContent { get; }
    public UIElements.Align alignItems { get; }
    public UIElements.Align alignSelf { get; }
    public Color backgroundColor { get; }
    public Color borderBottomColor { get; }
    public float borderBottomLeftRadius { get; }
    public float borderBottomRightRadius { get; }
    public float borderBottomWidth { get; }
    public Color borderLeftColor { get; }
    public float borderLeftWidth { get; }
    public Color borderRightColor { get; }
    public float borderRightWidth { get; }
    public Color borderTopColor { get; }
    public float borderTopLeftRadius { get; }
    public float borderTopRightRadius { get; }
    public float borderTopWidth { get; }
    public float bottom { get; }
    public Color color { get; }
    public UIElements.DisplayStyle display { get; }
    public UIElements.StyleFloat flexBasis { get; }
    public UIElements.FlexDirection flexDirection { get; }
    public float flexGrow { get; }
    public float flexShrink { get; }
    public UIElements.Wrap flexWrap { get; }
    public float fontSize { get; }
    public float height { get; }
    public UIElements.Justify justifyContent { get; }
    public float left { get; }
    public float marginBottom { get; }
    public float marginLeft { get; }
    public float marginRight { get; }
    public float marginTop { get; }
    public UIElements.StyleFloat maxHeight { get; }
    public UIElements.StyleFloat maxWidth { get; }
    public UIElements.StyleFloat minHeight { get; }
    public UIElements.StyleFloat minWidth { get; }
    public float opacity { get; }
    public float paddingBottom { get; }
    public float paddingLeft { get; }
    public float paddingRight { get; }
    public float paddingTop { get; }
    public UIElements.Position position { get; }
    public float right { get; }
    public float top { get; }
    public Color unityBackgroundImageTintColor { get; }
    public ScaleMode unityBackgroundScaleMode { get; }
    public Font unityFont { get; }
    public FontStyle unityFontStyleAndWeight { get; }
    public int unitySliceBottom { get; }
    public int unitySliceLeft { get; }
    public int unitySliceRight { get; }
    public int unitySliceTop { get; }
    public TextAnchor unityTextAlign { get; }
    public UIElements.Visibility visibility { get; }
    public UIElements.WhiteSpace whiteSpace { get; }
    public float width { get; }

}

}
