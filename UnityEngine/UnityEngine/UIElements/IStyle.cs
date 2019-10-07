using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IStyle
{
    public UIElements.StyleEnum<UIElements.Align> alignContent { get; set; }
    public UIElements.StyleEnum<UIElements.Align> alignItems { get; set; }
    public UIElements.StyleEnum<UIElements.Align> alignSelf { get; set; }
    public UIElements.StyleColor backgroundColor { get; set; }
    public UIElements.StyleBackground backgroundImage { get; set; }
    public UIElements.StyleLength borderBottomLeftRadius { get; set; }
    public UIElements.StyleLength borderBottomRightRadius { get; set; }
    public UIElements.StyleFloat borderBottomWidth { get; set; }
    public UIElements.StyleColor borderColor { get; set; }
    public UIElements.StyleFloat borderLeftWidth { get; set; }
    public UIElements.StyleFloat borderRightWidth { get; set; }
    public UIElements.StyleLength borderTopLeftRadius { get; set; }
    public UIElements.StyleLength borderTopRightRadius { get; set; }
    public UIElements.StyleFloat borderTopWidth { get; set; }
    public UIElements.StyleLength bottom { get; set; }
    public UIElements.StyleColor color { get; set; }
    public UIElements.StyleCursor cursor { get; set; }
    public UIElements.StyleEnum<UIElements.DisplayStyle> display { get; set; }
    public UIElements.StyleLength flexBasis { get; set; }
    public UIElements.StyleEnum<UIElements.FlexDirection> flexDirection { get; set; }
    public UIElements.StyleFloat flexGrow { get; set; }
    public UIElements.StyleFloat flexShrink { get; set; }
    public UIElements.StyleEnum<UIElements.Wrap> flexWrap { get; set; }
    public UIElements.StyleLength fontSize { get; set; }
    public UIElements.StyleLength height { get; set; }
    public UIElements.StyleEnum<UIElements.Justify> justifyContent { get; set; }
    public UIElements.StyleLength left { get; set; }
    public UIElements.StyleLength marginBottom { get; set; }
    public UIElements.StyleLength marginLeft { get; set; }
    public UIElements.StyleLength marginRight { get; set; }
    public UIElements.StyleLength marginTop { get; set; }
    public UIElements.StyleLength maxHeight { get; set; }
    public UIElements.StyleLength maxWidth { get; set; }
    public UIElements.StyleLength minHeight { get; set; }
    public UIElements.StyleLength minWidth { get; set; }
    public UIElements.StyleFloat opacity { get; set; }
    public UIElements.StyleEnum<UIElements.Overflow> overflow { get; set; }
    public UIElements.StyleLength paddingBottom { get; set; }
    public UIElements.StyleLength paddingLeft { get; set; }
    public UIElements.StyleLength paddingRight { get; set; }
    public UIElements.StyleLength paddingTop { get; set; }
    public UIElements.StyleEnum<UIElements.Position> position { get; set; }
    public UIElements.StyleLength right { get; set; }
    public UIElements.StyleLength top { get; set; }
    public UIElements.StyleColor unityBackgroundImageTintColor { get; set; }
    public UIElements.StyleEnum<ScaleMode> unityBackgroundScaleMode { get; set; }
    public UIElements.StyleFont unityFont { get; set; }
    public UIElements.StyleEnum<FontStyle> unityFontStyleAndWeight { get; set; }
    public UIElements.StyleInt unitySliceBottom { get; set; }
    public UIElements.StyleInt unitySliceLeft { get; set; }
    public UIElements.StyleInt unitySliceRight { get; set; }
    public UIElements.StyleInt unitySliceTop { get; set; }
    public UIElements.StyleEnum<TextAnchor> unityTextAlign { get; set; }
    public UIElements.StyleEnum<UIElements.Visibility> visibility { get; set; }
    public UIElements.StyleEnum<UIElements.WhiteSpace> whiteSpace { get; set; }
    public UIElements.StyleLength width { get; set; }

}

}
