using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IStyle
{
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Align> alignContent { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Align> alignItems { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Align> alignSelf { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Color> backgroundColor { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Texture2D> backgroundImage { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<ScaleMode> backgroundScaleMode { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<ScaleMode> backgroundSize { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderBottom { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderBottomLeftRadius { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderBottomRightRadius { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderBottomWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Color> borderColor { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderLeft { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderLeftWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderRadius { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderRight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderRightWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderTop { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderTopLeftRadius { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderTopRightRadius { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> borderTopWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Color> color { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.CursorStyle> cursor { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.Flex> flex { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> flexBasis { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.FlexDirection> flexDirection { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> flexGrow { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> flexShrink { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Wrap> flexWrap { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Font> font { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> fontSize { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<FontStyle> fontStyle { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<FontStyle> fontStyleAndWeight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> height { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Justify> justifyContent { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> marginBottom { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> marginLeft { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> marginRight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> marginTop { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> maxHeight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> maxWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> minHeight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> minWidth { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> opacity { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Overflow> overflow { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> paddingBottom { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> paddingLeft { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> paddingRight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> paddingTop { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> positionBottom { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> positionLeft { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> positionRight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> positionTop { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.PositionType> positionType { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> sliceBottom { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> sliceLeft { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> sliceRight { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<int> sliceTop { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<TextAnchor> textAlignment { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<TextClipping> textClipping { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Color> textColor { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<TextAnchor> unityTextAlign { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<Experimental.UIElements.StyleEnums.Visibility> visibility { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<float> width { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<bool> wordWrap { get; set; }

}

}
