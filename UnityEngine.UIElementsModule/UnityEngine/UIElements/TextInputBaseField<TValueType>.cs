using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class TextInputBaseField<TValueType> : UIElements.BaseField<TValueType>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string multilineInputUssClassName;
    static public string singleLineInputUssClassName;
    static public string textInputUssName;
    static public string ussClassName;

    public Color cursorColor { get; }
    public int cursorIndex { get; }
    public bool doubleClickSelectsWord { get; set; }
    public bool isDelayed { get; set; }
    public bool isPasswordField { get; set; }
    public bool isReadOnly { get; set; }
    public char maskChar { get; set; }
    public int maxLength { get; set; }
    public int selectIndex { get; }
    public Color selectionColor { get; }
    public string text { get; protected set; }
    protected TextInputBase<TValueType> textInputBase { get; }
    public bool tripleClickSelectsLine { get; set; }

    protected TextInputBaseField(int maxLength, char maskChar, TextInputBase<TValueType> textInputBase);
    protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase<TValueType> textInputBase);

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);
    public void SelectAll();
    protected TValueType StringToValue(string str);
    protected void UpdateMixedValueContent();
    protected string ValueToString(TValueType value);

    protected abstract class TextInputBase<TValueType> : UIElements.VisualElement, UIElements.ITextInputField, UIElements.IEventHandler, UIElements.ITextElement
    {
        public Color cursorColor { get; }
        public int cursorIndex { get; }
        public bool doubleClickSelectsWord { get; set; }
        public bool isPasswordField { get; set; }
        public bool isReadOnly { get; set; }
        public char maskChar { get; set; }
        public int maxLength { get; set; }
        public int selectIndex { get; }
        public Color selectionColor { get; }
        public string text { get; set; }
        public bool tripleClickSelectsLine { get; set; }

        protected void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
        protected void ExecuteDefaultAction(UIElements.EventBase evt);
        protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
        public void ResetValueAndText();
        public void SelectAll();
        protected TValueType StringToValue(string str);

    }

    public class UxmlTraits<TValueType> : UIElements.BaseFieldTraits<string, UIElements.UxmlStringAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
