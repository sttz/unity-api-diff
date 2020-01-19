using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorGUILayout
{
    static public bool BeginFadeGroup(float value);
    static public Rect BeginHorizontal(GUILayoutOption[] options);
    static public Rect BeginHorizontal(GUIStyle style, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
    static public Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options);
    static public bool BeginToggleGroup(string label, bool toggle);
    static public bool BeginToggleGroup(GUIContent label, bool toggle);
    static public Rect BeginVertical(GUILayoutOption[] options);
    static public Rect BeginVertical(GUIStyle style, GUILayoutOption[] options);
    static public Bounds BoundsField(Bounds value, GUILayoutOption[] options);
    static public Bounds BoundsField(string label, Bounds value, GUILayoutOption[] options);
    static public Bounds BoundsField(GUIContent label, Bounds value, GUILayoutOption[] options);
    static public BoundsInt BoundsIntField(BoundsInt value, GUILayoutOption[] options);
    static public BoundsInt BoundsIntField(string label, BoundsInt value, GUILayoutOption[] options);
    static public BoundsInt BoundsIntField(GUIContent label, BoundsInt value, GUILayoutOption[] options);
    static public Color ColorField(Color value, GUILayoutOption[] options);
    static public Color ColorField(string label, Color value, GUILayoutOption[] options);
    static public Color ColorField(GUIContent label, Color value, GUILayoutOption[] options);
    static public Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, GUILayoutOption[] options);
    static public Color ColorField(GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, UnityEditor.ColorPickerHDRConfig hdrConfig, GUILayoutOption[] options);
    static public AnimationCurve CurveField(AnimationCurve value, GUILayoutOption[] options);
    static public AnimationCurve CurveField(string label, AnimationCurve value, GUILayoutOption[] options);
    static public AnimationCurve CurveField(GUIContent label, AnimationCurve value, GUILayoutOption[] options);
    static public void CurveField(UnityEditor.SerializedProperty property, Color color, Rect ranges, GUILayoutOption[] options);
    static public AnimationCurve CurveField(AnimationCurve value, Color color, Rect ranges, GUILayoutOption[] options);
    static public AnimationCurve CurveField(string label, AnimationCurve value, Color color, Rect ranges, GUILayoutOption[] options);
    static public AnimationCurve CurveField(GUIContent label, AnimationCurve value, Color color, Rect ranges, GUILayoutOption[] options);
    static public void CurveField(UnityEditor.SerializedProperty property, Color color, Rect ranges, GUIContent label, GUILayoutOption[] options);
    static public double DelayedDoubleField(double value, GUILayoutOption[] options);
    static public double DelayedDoubleField(string label, double value, GUILayoutOption[] options);
    static public double DelayedDoubleField(GUIContent label, double value, GUILayoutOption[] options);
    static public double DelayedDoubleField(double value, GUIStyle style, GUILayoutOption[] options);
    static public double DelayedDoubleField(string label, double value, GUIStyle style, GUILayoutOption[] options);
    static public double DelayedDoubleField(GUIContent label, double value, GUIStyle style, GUILayoutOption[] options);
    static public void DelayedFloatField(UnityEditor.SerializedProperty property, GUILayoutOption[] options);
    static public float DelayedFloatField(float value, GUILayoutOption[] options);
    static public float DelayedFloatField(string label, float value, GUILayoutOption[] options);
    static public float DelayedFloatField(GUIContent label, float value, GUILayoutOption[] options);
    static public void DelayedFloatField(UnityEditor.SerializedProperty property, GUIContent label, GUILayoutOption[] options);
    static public float DelayedFloatField(float value, GUIStyle style, GUILayoutOption[] options);
    static public float DelayedFloatField(string label, float value, GUIStyle style, GUILayoutOption[] options);
    static public float DelayedFloatField(GUIContent label, float value, GUIStyle style, GUILayoutOption[] options);
    static public void DelayedIntField(UnityEditor.SerializedProperty property, GUILayoutOption[] options);
    static public int DelayedIntField(int value, GUILayoutOption[] options);
    static public int DelayedIntField(string label, int value, GUILayoutOption[] options);
    static public int DelayedIntField(GUIContent label, int value, GUILayoutOption[] options);
    static public void DelayedIntField(UnityEditor.SerializedProperty property, GUIContent label, GUILayoutOption[] options);
    static public int DelayedIntField(int value, GUIStyle style, GUILayoutOption[] options);
    static public int DelayedIntField(string label, int value, GUIStyle style, GUILayoutOption[] options);
    static public int DelayedIntField(GUIContent label, int value, GUIStyle style, GUILayoutOption[] options);
    static public void DelayedTextField(UnityEditor.SerializedProperty property, GUILayoutOption[] options);
    static public string DelayedTextField(string text, GUILayoutOption[] options);
    static public string DelayedTextField(string label, string text, GUILayoutOption[] options);
    static public string DelayedTextField(GUIContent label, string text, GUILayoutOption[] options);
    static public void DelayedTextField(UnityEditor.SerializedProperty property, GUIContent label, GUILayoutOption[] options);
    static public string DelayedTextField(string text, GUIStyle style, GUILayoutOption[] options);
    static public string DelayedTextField(string label, string text, GUIStyle style, GUILayoutOption[] options);
    static public string DelayedTextField(GUIContent label, string text, GUIStyle style, GUILayoutOption[] options);
    static public double DoubleField(double value, GUILayoutOption[] options);
    static public double DoubleField(string label, double value, GUILayoutOption[] options);
    static public double DoubleField(GUIContent label, double value, GUILayoutOption[] options);
    static public double DoubleField(double value, GUIStyle style, GUILayoutOption[] options);
    static public double DoubleField(string label, double value, GUIStyle style, GUILayoutOption[] options);
    static public double DoubleField(GUIContent label, double value, GUIStyle style, GUILayoutOption[] options);
    static public bool DropdownButton(GUIContent content, FocusType focusType, GUILayoutOption[] options);
    static public bool DropdownButton(GUIContent content, FocusType focusType, GUIStyle style, GUILayoutOption[] options);
    static public void EndFadeGroup();
    static public void EndHorizontal();
    static public void EndScrollView();
    static public void EndToggleGroup();
    static public void EndVertical();
    static public Enum EnumFlagsField(Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumFlagsField(Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumFlagsField(string label, Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumFlagsField(GUIContent label, Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, GUILayoutOption[] options);
    static public Enum EnumFlagsField(string label, Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumFlagsField(GUIContent label, Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumFlagsField(GUIContent label, Enum enumValue, bool includeObsolete, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumMaskField(Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumMaskField(Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumMaskField(string label, Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumMaskField(GUIContent label, Enum enumValue, GUILayoutOption[] options);
    static public Enum EnumMaskField(string label, Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumMaskField(GUIContent label, Enum enumValue, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumMaskPopup(string label, Enum selected, GUILayoutOption[] options);
    static public Enum EnumMaskPopup(GUIContent label, Enum selected, GUILayoutOption[] options);
    static public Enum EnumMaskPopup(string label, Enum selected, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumMaskPopup(GUIContent label, Enum selected, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumPopup(Enum selected, GUILayoutOption[] options);
    static public Enum EnumPopup(string label, Enum selected, GUILayoutOption[] options);
    static public Enum EnumPopup(GUIContent label, Enum selected, GUILayoutOption[] options);
    static public Enum EnumPopup(Enum selected, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumPopup(string label, Enum selected, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumPopup(GUIContent label, Enum selected, GUIStyle style, GUILayoutOption[] options);
    static public Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, GUILayoutOption[] options);
    static public Enum EnumPopup(GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete, GUIStyle style, GUILayoutOption[] options);
    static public float FloatField(float value, GUILayoutOption[] options);
    static public float FloatField(string label, float value, GUILayoutOption[] options);
    static public float FloatField(GUIContent label, float value, GUILayoutOption[] options);
    static public float FloatField(float value, GUIStyle style, GUILayoutOption[] options);
    static public float FloatField(string label, float value, GUIStyle style, GUILayoutOption[] options);
    static public float FloatField(GUIContent label, float value, GUIStyle style, GUILayoutOption[] options);
    static public bool Foldout(bool foldout, string content);
    static public bool Foldout(bool foldout, GUIContent content);
    static public bool Foldout(bool foldout, string content, GUIStyle style);
    static public bool Foldout(bool foldout, GUIContent content, GUIStyle style);
    static public bool Foldout(bool foldout, string content, bool toggleOnLabelClick);
    static public bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick);
    static public bool Foldout(bool foldout, string content, bool toggleOnLabelClick, GUIStyle style);
    static public bool Foldout(bool foldout, GUIContent content, bool toggleOnLabelClick, GUIStyle style);
    static public Rect GetControlRect(GUILayoutOption[] options);
    static public Rect GetControlRect(bool hasLabel, GUILayoutOption[] options);
    static public Rect GetControlRect(bool hasLabel, float height, GUILayoutOption[] options);
    static public Rect GetControlRect(bool hasLabel, float height, GUIStyle style, GUILayoutOption[] options);
    static public Gradient GradientField(Gradient value, GUILayoutOption[] options);
    static public Gradient GradientField(string label, Gradient value, GUILayoutOption[] options);
    static public Gradient GradientField(GUIContent label, Gradient value, GUILayoutOption[] options);
    static public Gradient GradientField(GUIContent label, Gradient value, bool hdr, GUILayoutOption[] options);
    static public void HelpBox(GUIContent content, bool wide = true);
    static public void HelpBox(string message, UnityEditor.MessageType type);
    static public void HelpBox(string message, UnityEditor.MessageType type, bool wide);
    static public void InspectorTitlebar(Object[] targetObjs);
    static public bool InspectorTitlebar(bool foldout, UnityEditor.Editor editor);
    static public bool InspectorTitlebar(bool foldout, Object targetObj);
    static public bool InspectorTitlebar(bool foldout, Object[] targetObjs);
    static public bool InspectorTitlebar(bool foldout, Object targetObj, bool expandable);
    static public bool InspectorTitlebar(bool foldout, Object[] targetObjs, bool expandable);
    static public int IntField(int value, GUILayoutOption[] options);
    static public int IntField(string label, int value, GUILayoutOption[] options);
    static public int IntField(GUIContent label, int value, GUILayoutOption[] options);
    static public int IntField(int value, GUIStyle style, GUILayoutOption[] options);
    static public int IntField(string label, int value, GUIStyle style, GUILayoutOption[] options);
    static public int IntField(GUIContent label, int value, GUIStyle style, GUILayoutOption[] options);
    static public void IntPopup(UnityEditor.SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUILayoutOption[] options);
    static public int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, GUILayoutOption[] options);
    static public int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUILayoutOption[] options);
    static public int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUILayoutOption[] options);
    static public int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUILayoutOption[] options);
    static public void IntPopup(UnityEditor.SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, GUILayoutOption[] options);
    static public int IntPopup(int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, GUILayoutOption[] options);
    static public int IntPopup(int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, GUILayoutOption[] options);
    static public int IntPopup(string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, GUILayoutOption[] options);
    static public int IntPopup(GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, GUILayoutOption[] options);
    static public void IntPopup(UnityEditor.SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, GUIStyle style, GUILayoutOption[] options);
    static public void IntSlider(UnityEditor.SerializedProperty property, int leftValue, int rightValue, GUILayoutOption[] options);
    static public int IntSlider(int value, int leftValue, int rightValue, GUILayoutOption[] options);
    static public int IntSlider(string label, int value, int leftValue, int rightValue, GUILayoutOption[] options);
    static public int IntSlider(GUIContent label, int value, int leftValue, int rightValue, GUILayoutOption[] options);
    static public void IntSlider(UnityEditor.SerializedProperty property, int leftValue, int rightValue, string label, GUILayoutOption[] options);
    static public void IntSlider(UnityEditor.SerializedProperty property, int leftValue, int rightValue, GUIContent label, GUILayoutOption[] options);
    static public float Knob(Vector2 knobSize, float value, float minValue, float maxValue, string unit, Color backgroundColor, Color activeColor, bool showValue, GUILayoutOption[] options);
    static public void LabelField(string label, GUILayoutOption[] options);
    static public void LabelField(GUIContent label, GUILayoutOption[] options);
    static public void LabelField(string label, string label2, GUILayoutOption[] options);
    static public void LabelField(GUIContent label, GUIContent label2, GUILayoutOption[] options);
    static public void LabelField(string label, GUIStyle style, GUILayoutOption[] options);
    static public void LabelField(GUIContent label, GUIStyle style, GUILayoutOption[] options);
    static public void LabelField(string label, string label2, GUIStyle style, GUILayoutOption[] options);
    static public void LabelField(GUIContent label, GUIContent label2, GUIStyle style, GUILayoutOption[] options);
    static public int LayerField(int layer, GUILayoutOption[] options);
    static public int LayerField(string label, int layer, GUILayoutOption[] options);
    static public int LayerField(GUIContent label, int layer, GUILayoutOption[] options);
    static public int LayerField(int layer, GUIStyle style, GUILayoutOption[] options);
    static public int LayerField(string label, int layer, GUIStyle style, GUILayoutOption[] options);
    static public int LayerField(GUIContent label, int layer, GUIStyle style, GUILayoutOption[] options);
    static public long LongField(long value, GUILayoutOption[] options);
    static public long LongField(string label, long value, GUILayoutOption[] options);
    static public long LongField(GUIContent label, long value, GUILayoutOption[] options);
    static public long LongField(long value, GUIStyle style, GUILayoutOption[] options);
    static public long LongField(string label, long value, GUIStyle style, GUILayoutOption[] options);
    static public long LongField(GUIContent label, long value, GUIStyle style, GUILayoutOption[] options);
    static public int MaskField(int mask, string[] displayedOptions, GUILayoutOption[] options);
    static public int MaskField(string label, int mask, string[] displayedOptions, GUILayoutOption[] options);
    static public int MaskField(GUIContent label, int mask, string[] displayedOptions, GUILayoutOption[] options);
    static public int MaskField(int mask, string[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public int MaskField(string label, int mask, string[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public int MaskField(GUIContent label, int mask, string[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public void MinMaxSlider(float minValue, float maxValue, float minLimit, float maxLimit, GUILayoutOption[] options);
    static public void MinMaxSlider(string label, float minValue, float maxValue, float minLimit, float maxLimit, GUILayoutOption[] options);
    static public void MinMaxSlider(GUIContent label, float minValue, float maxValue, float minLimit, float maxLimit, GUILayoutOption[] options);
    static public void ObjectField(UnityEditor.SerializedProperty property, GUILayoutOption[] options);
    static public Object ObjectField(Object obj, Type objType, GUILayoutOption[] options);
    static public void ObjectField(UnityEditor.SerializedProperty property, GUIContent label, GUILayoutOption[] options);
    static public void ObjectField(UnityEditor.SerializedProperty property, Type objType, GUILayoutOption[] options);
    static public Object ObjectField(string label, Object obj, Type objType, GUILayoutOption[] options);
    static public Object ObjectField(GUIContent label, Object obj, Type objType, GUILayoutOption[] options);
    static public Object ObjectField(Object obj, Type objType, bool allowSceneObjects, GUILayoutOption[] options);
    static public void ObjectField(UnityEditor.SerializedProperty property, Type objType, GUIContent label, GUILayoutOption[] options);
    static public Object ObjectField(string label, Object obj, Type objType, bool allowSceneObjects, GUILayoutOption[] options);
    static public Object ObjectField(GUIContent label, Object obj, Type objType, bool allowSceneObjects, GUILayoutOption[] options);
    static public string PasswordField(string password, GUILayoutOption[] options);
    static public string PasswordField(string label, string password, GUILayoutOption[] options);
    static public string PasswordField(GUIContent label, string password, GUILayoutOption[] options);
    static public string PasswordField(string password, GUIStyle style, GUILayoutOption[] options);
    static public string PasswordField(string label, string password, GUIStyle style, GUILayoutOption[] options);
    static public string PasswordField(GUIContent label, string password, GUIStyle style, GUILayoutOption[] options);
    static public int Popup(int selectedIndex, string[] displayedOptions, GUILayoutOption[] options);
    static public int Popup(int selectedIndex, GUIContent[] displayedOptions, GUILayoutOption[] options);
    static public int Popup(string label, int selectedIndex, string[] displayedOptions, GUILayoutOption[] options);
    static public int Popup(GUIContent label, int selectedIndex, string[] displayedOptions, GUILayoutOption[] options);
    static public int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUILayoutOption[] options);
    static public int Popup(int selectedIndex, string[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public int Popup(int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public int Popup(string label, int selectedIndex, string[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public int Popup(GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, GUILayoutOption[] options);
    static public void PrefixLabel(string label);
    static public void PrefixLabel(GUIContent label);
    static public void PrefixLabel(string label, GUIStyle followingStyle);
    static public void PrefixLabel(GUIContent label, GUIStyle followingStyle);
    static public void PrefixLabel(string label, GUIStyle followingStyle, GUIStyle labelStyle);
    static public void PrefixLabel(GUIContent label, GUIStyle followingStyle, GUIStyle labelStyle);
    static public bool PropertyField(UnityEditor.SerializedProperty property, GUILayoutOption[] options);
    static public bool PropertyField(UnityEditor.SerializedProperty property, bool includeChildren, GUILayoutOption[] options);
    static public bool PropertyField(UnityEditor.SerializedProperty property, GUIContent label, GUILayoutOption[] options);
    static public bool PropertyField(UnityEditor.SerializedProperty property, GUIContent label, bool includeChildren, GUILayoutOption[] options);
    static public Rect RectField(Rect value, GUILayoutOption[] options);
    static public Rect RectField(string label, Rect value, GUILayoutOption[] options);
    static public Rect RectField(GUIContent label, Rect value, GUILayoutOption[] options);
    static public RectInt RectIntField(RectInt value, GUILayoutOption[] options);
    static public RectInt RectIntField(string label, RectInt value, GUILayoutOption[] options);
    static public RectInt RectIntField(GUIContent label, RectInt value, GUILayoutOption[] options);
    static public void SelectableLabel(string text, GUILayoutOption[] options);
    static public void SelectableLabel(string text, GUIStyle style, GUILayoutOption[] options);
    static public void Separator();
    static public void Slider(UnityEditor.SerializedProperty property, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float Slider(float value, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float Slider(string label, float value, float leftValue, float rightValue, GUILayoutOption[] options);
    static public float Slider(GUIContent label, float value, float leftValue, float rightValue, GUILayoutOption[] options);
    static public void Slider(UnityEditor.SerializedProperty property, float leftValue, float rightValue, string label, GUILayoutOption[] options);
    static public void Slider(UnityEditor.SerializedProperty property, float leftValue, float rightValue, GUIContent label, GUILayoutOption[] options);
    static public void Space();
    static public string TagField(string tag, GUILayoutOption[] options);
    static public string TagField(string label, string tag, GUILayoutOption[] options);
    static public string TagField(GUIContent label, string tag, GUILayoutOption[] options);
    static public string TagField(string tag, GUIStyle style, GUILayoutOption[] options);
    static public string TagField(string label, string tag, GUIStyle style, GUILayoutOption[] options);
    static public string TagField(GUIContent label, string tag, GUIStyle style, GUILayoutOption[] options);
    static public string TextArea(string text, GUILayoutOption[] options);
    static public string TextArea(string text, GUIStyle style, GUILayoutOption[] options);
    static public string TextField(string text, GUILayoutOption[] options);
    static public string TextField(string label, string text, GUILayoutOption[] options);
    static public string TextField(GUIContent label, string text, GUILayoutOption[] options);
    static public string TextField(string text, GUIStyle style, GUILayoutOption[] options);
    static public string TextField(string label, string text, GUIStyle style, GUILayoutOption[] options);
    static public string TextField(GUIContent label, string text, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(bool value, GUILayoutOption[] options);
    static public bool Toggle(string label, bool value, GUILayoutOption[] options);
    static public bool Toggle(GUIContent label, bool value, GUILayoutOption[] options);
    static public bool Toggle(bool value, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(string label, bool value, GUIStyle style, GUILayoutOption[] options);
    static public bool Toggle(GUIContent label, bool value, GUIStyle style, GUILayoutOption[] options);
    static public bool ToggleLeft(string label, bool value, GUILayoutOption[] options);
    static public bool ToggleLeft(GUIContent label, bool value, GUILayoutOption[] options);
    static public bool ToggleLeft(string label, bool value, GUIStyle labelStyle, GUILayoutOption[] options);
    static public bool ToggleLeft(GUIContent label, bool value, GUIStyle labelStyle, GUILayoutOption[] options);
    static public Vector2 Vector2Field(string label, Vector2 value, GUILayoutOption[] options);
    static public Vector2 Vector2Field(GUIContent label, Vector2 value, GUILayoutOption[] options);
    static public Vector2Int Vector2IntField(string label, Vector2Int value, GUILayoutOption[] options);
    static public Vector2Int Vector2IntField(GUIContent label, Vector2Int value, GUILayoutOption[] options);
    static public Vector3 Vector3Field(string label, Vector3 value, GUILayoutOption[] options);
    static public Vector3 Vector3Field(GUIContent label, Vector3 value, GUILayoutOption[] options);
    static public Vector3Int Vector3IntField(string label, Vector3Int value, GUILayoutOption[] options);
    static public Vector3Int Vector3IntField(GUIContent label, Vector3Int value, GUILayoutOption[] options);
    static public Vector4 Vector4Field(string label, Vector4 value, GUILayoutOption[] options);
    static public Vector4 Vector4Field(GUIContent label, Vector4 value, GUILayoutOption[] options);

    public EditorGUILayout();

    public class FadeGroupScope : Scope
    {
        public bool visible { get; protected set; }

        public FadeGroupScope(float value);

        protected void CloseScope();

    }

    public class HorizontalScope : Scope
    {
        public Rect rect { get; protected set; }

        public HorizontalScope(GUILayoutOption[] options);
        public HorizontalScope(GUIStyle style, GUILayoutOption[] options);

        protected void CloseScope();

    }

    public class ScrollViewScope : Scope
    {
        public bool handleScrollWheel { get; set; }
        public Vector2 scrollPosition { get; protected set; }

        public ScrollViewScope(Vector2 scrollPosition, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options);
        public ScrollViewScope(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options);

        protected void CloseScope();

    }

    public class ToggleGroupScope : Scope
    {
        public bool enabled { get; protected set; }

        public ToggleGroupScope(string label, bool toggle);
        public ToggleGroupScope(GUIContent label, bool toggle);

        protected void CloseScope();

    }

    public class VerticalScope : Scope
    {
        public Rect rect { get; protected set; }

        public VerticalScope(GUILayoutOption[] options);
        public VerticalScope(GUIStyle style, GUILayoutOption[] options);

        protected void CloseScope();

    }

}

}
