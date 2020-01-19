using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public abstract class TextValueField<TValueType> : UIElements.TextInputBaseField<TValueType>, UnityEditor.UIElements.IValueField<TValueType>
{
    public string formatString { get; set; }
    public TValueType value { get; set; }

    protected TextValueField(int maxLength, TextValueInput<TValueType> textValueInput);
    protected TextValueField(string label, int maxLength, TextValueInput<TValueType> textValueInput);

    protected void AddLabelDragger<TDraggerType>();
    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, TValueType startValue);
    public void SetValueWithoutNotify(TValueType newValue);
    public void StartDragging();
    public void StopDragging();
    protected TValueType StringToValue(string str);
    protected string ValueToString(TValueType value);

    protected abstract class TextValueInput<TValueType> : TextInputBase<TValueType>
    {
        protected string allowedCharacters { get; }
        public string formatString { get; set; }

        protected TextValueInput();

        public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, TValueType startValue);
        protected void ExecuteDefaultAction(UIElements.EventBase evt);
        protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
        public void StartDragging();
        public void StopDragging();
        protected TValueType StringToValue(string str);
        protected string ValueToString(TValueType value);

    }

}

}
