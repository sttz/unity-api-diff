using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorGUI
{
    static public bool actionKey { get; }
    static public int indentLevel { get; set; }
    static public bool showMixedValue { get; set; }

    static public void BeginChangeCheck();
    static public void BeginDisabledGroup(bool disabled);
    static public bool BeginFoldoutHeaderGroup(Rect position, bool foldout, string content, GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
    static public bool BeginFoldoutHeaderGroup(Rect position, bool foldout, GUIContent content, GUIStyle style = null, Action<Rect> menuAction = null, GUIStyle menuIcon = null);
    static public GUIContent BeginProperty(Rect totalPosition, GUIContent label, UnityEditor.SerializedProperty property);
    static public Bounds BoundsField(Rect position, Bounds value);
    static public Bounds BoundsField(Rect position, string label, Bounds value);
    static public Bounds BoundsField(Rect position, GUIContent label, Bounds value);
    static public BoundsInt BoundsIntField(Rect position, BoundsInt value);
    static public BoundsInt BoundsIntField(Rect position, string label, BoundsInt value);
    static public BoundsInt BoundsIntField(Rect position, GUIContent label, BoundsInt value);
    static public bool CanCacheInspectorGUI(UnityEditor.SerializedProperty property);
    static public Color ColorField(Rect position, Color value);
    static public Color ColorField(Rect position, string label, Color value);
    static public Color ColorField(Rect position, GUIContent label, Color value);
    static public Color ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr, UnityEditor.ColorPickerHDRConfig hdrConfig);
    static public Color ColorField(Rect position, GUIContent label, Color value, bool showEyedropper, bool showAlpha, bool hdr);
    static public AnimationCurve CurveField(Rect position, AnimationCurve value);
    static public AnimationCurve CurveField(Rect position, string label, AnimationCurve value);
    static public AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value);
    static public AnimationCurve CurveField(Rect position, AnimationCurve value, Color color, Rect ranges);
    static public AnimationCurve CurveField(Rect position, string label, AnimationCurve value, Color color, Rect ranges);
    static public AnimationCurve CurveField(Rect position, GUIContent label, AnimationCurve value, Color color, Rect ranges);
    static public void CurveField(Rect position, UnityEditor.SerializedProperty property, Color color, Rect ranges);
    static public void CurveField(Rect position, UnityEditor.SerializedProperty property, Color color, Rect ranges, GUIContent label);
    static public double DelayedDoubleField(Rect position, double value);
    static public double DelayedDoubleField(Rect position, double value, GUIStyle style);
    static public double DelayedDoubleField(Rect position, string label, double value);
    static public double DelayedDoubleField(Rect position, string label, double value, GUIStyle style);
    static public double DelayedDoubleField(Rect position, GUIContent label, double value);
    static public double DelayedDoubleField(Rect position, GUIContent label, double value, GUIStyle style);
    static public float DelayedFloatField(Rect position, float value);
    static public float DelayedFloatField(Rect position, float value, GUIStyle style);
    static public float DelayedFloatField(Rect position, string label, float value);
    static public float DelayedFloatField(Rect position, string label, float value, GUIStyle style);
    static public float DelayedFloatField(Rect position, GUIContent label, float value);
    static public float DelayedFloatField(Rect position, GUIContent label, float value, GUIStyle style);
    static public void DelayedFloatField(Rect position, UnityEditor.SerializedProperty property);
    static public void DelayedFloatField(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    static public int DelayedIntField(Rect position, int value);
    static public int DelayedIntField(Rect position, int value, GUIStyle style);
    static public int DelayedIntField(Rect position, string label, int value);
    static public int DelayedIntField(Rect position, string label, int value, GUIStyle style);
    static public int DelayedIntField(Rect position, GUIContent label, int value);
    static public int DelayedIntField(Rect position, GUIContent label, int value, GUIStyle style);
    static public void DelayedIntField(Rect position, UnityEditor.SerializedProperty property);
    static public void DelayedIntField(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    static public string DelayedTextField(Rect position, string text);
    static public string DelayedTextField(Rect position, string text, GUIStyle style);
    static public string DelayedTextField(Rect position, string label, string text);
    static public string DelayedTextField(Rect position, string label, string text, GUIStyle style);
    static public string DelayedTextField(Rect position, GUIContent label, string text);
    static public string DelayedTextField(Rect position, GUIContent label, string text, GUIStyle style);
    static public void DelayedTextField(Rect position, UnityEditor.SerializedProperty property);
    static public void DelayedTextField(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    static public string DelayedTextField(Rect position, GUIContent label, int controlId, string text);
    static public string DelayedTextField(Rect position, GUIContent label, int controlId, string text, GUIStyle style);
    static public string DoPasswordField(int id, Rect position, string password, GUIStyle style);
    static public string DoPasswordField(int id, Rect position, GUIContent label, string password, GUIStyle style);
    static public double DoubleField(Rect position, double value);
    static public double DoubleField(Rect position, double value, GUIStyle style);
    static public double DoubleField(Rect position, string label, double value);
    static public double DoubleField(Rect position, string label, double value, GUIStyle style);
    static public double DoubleField(Rect position, GUIContent label, double value);
    static public double DoubleField(Rect position, GUIContent label, double value, GUIStyle style);
    static public void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect, float mipLevel, Rendering.ColorWriteMask colorWriteMask);
    static public void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect, float mipLevel);
    static public void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode, float imageAspect);
    static public void DrawPreviewTexture(Rect position, Texture image, Material mat, ScaleMode scaleMode);
    static public void DrawPreviewTexture(Rect position, Texture image, Material mat);
    static public void DrawPreviewTexture(Rect position, Texture image);
    static public void DrawRect(Rect rect, Color color);
    static public void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode, float imageAspect, float mipLevel);
    static public void DrawTextureAlpha(Rect position, Texture image);
    static public void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode);
    static public void DrawTextureAlpha(Rect position, Texture image, ScaleMode scaleMode, float imageAspect);
    static public void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect, float mipLevel, Rendering.ColorWriteMask colorWriteMask);
    static public void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode);
    static public void DrawTextureTransparent(Rect position, Texture image);
    static public void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect);
    static public void DrawTextureTransparent(Rect position, Texture image, ScaleMode scaleMode, float imageAspect, float mipLevel);
    static public bool DropdownButton(Rect position, GUIContent content, FocusType focusType);
    static public bool DropdownButton(Rect position, GUIContent content, FocusType focusType, GUIStyle style);
    static public void DropShadowLabel(Rect position, string text);
    static public void DropShadowLabel(Rect position, GUIContent content);
    static public void DropShadowLabel(Rect position, string text, GUIStyle style);
    static public void DropShadowLabel(Rect position, GUIContent content, GUIStyle style);
    static public bool EndChangeCheck();
    static public void EndDisabledGroup();
    static public void EndFoldoutHeaderGroup();
    static public void EndProperty();
    static public Enum EnumFlagsField(Rect position, Enum enumValue);
    static public Enum EnumFlagsField(Rect position, Enum enumValue, GUIStyle style);
    static public Enum EnumFlagsField(Rect position, string label, Enum enumValue);
    static public Enum EnumFlagsField(Rect position, string label, Enum enumValue, GUIStyle style);
    static public Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue);
    static public Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue, GUIStyle style);
    static public Enum EnumFlagsField(Rect position, GUIContent label, Enum enumValue, bool includeObsolete, GUIStyle style = null);
    static public Enum EnumMaskField(Rect position, Enum enumValue);
    static public Enum EnumMaskField(Rect position, Enum enumValue, GUIStyle style);
    static public Enum EnumMaskField(Rect position, string label, Enum enumValue);
    static public Enum EnumMaskField(Rect position, string label, Enum enumValue, GUIStyle style);
    static public Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue);
    static public Enum EnumMaskField(Rect position, GUIContent label, Enum enumValue, GUIStyle style);
    static public Enum EnumMaskPopup(Rect position, string label, Enum selected);
    static public Enum EnumMaskPopup(Rect position, string label, Enum selected, GUIStyle style);
    static public Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected);
    static public Enum EnumMaskPopup(Rect position, GUIContent label, Enum selected, GUIStyle style);
    static public Enum EnumPopup(Rect position, Enum selected);
    static public Enum EnumPopup(Rect position, Enum selected, GUIStyle style);
    static public Enum EnumPopup(Rect position, string label, Enum selected);
    static public Enum EnumPopup(Rect position, string label, Enum selected, GUIStyle style);
    static public Enum EnumPopup(Rect position, GUIContent label, Enum selected);
    static public Enum EnumPopup(Rect position, GUIContent label, Enum selected, GUIStyle style);
    static public Enum EnumPopup(Rect position, GUIContent label, Enum selected, Func<Enum, bool> checkEnabled, bool includeObsolete = false, GUIStyle style = null);
    static public float FloatField(Rect position, float value);
    static public float FloatField(Rect position, float value, GUIStyle style);
    static public float FloatField(Rect position, string label, float value);
    static public float FloatField(Rect position, string label, float value, GUIStyle style);
    static public float FloatField(Rect position, GUIContent label, float value);
    static public float FloatField(Rect position, GUIContent label, float value, GUIStyle style);
    static public void FocusTextInControl(string name);
    static public bool Foldout(Rect position, bool foldout, string content);
    static public bool Foldout(Rect position, bool foldout, string content, GUIStyle style);
    static public bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick);
    static public bool Foldout(Rect position, bool foldout, string content, bool toggleOnLabelClick, GUIStyle style);
    static public bool Foldout(Rect position, bool foldout, GUIContent content);
    static public bool Foldout(Rect position, bool foldout, GUIContent content, GUIStyle style);
    static public bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick);
    static public bool Foldout(Rect position, bool foldout, GUIContent content, bool toggleOnLabelClick, GUIStyle style);
    static public float GetPropertyHeight(UnityEditor.SerializedPropertyType type, GUIContent label);
    static public float GetPropertyHeight(UnityEditor.SerializedProperty property, bool includeChildren);
    static public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label);
    static public float GetPropertyHeight(UnityEditor.SerializedProperty property);
    static public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label, bool includeChildren);
    static public Gradient GradientField(Rect position, Gradient gradient);
    static public Gradient GradientField(Rect position, string label, Gradient gradient);
    static public Gradient GradientField(Rect position, GUIContent label, Gradient gradient);
    static public Gradient GradientField(Rect position, GUIContent label, Gradient gradient, bool hdr);
    static public void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, int id);
    static public void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label);
    static public void HandlePrefixLabel(Rect totalPosition, Rect labelPosition, GUIContent label, int id, GUIStyle style);
    static public void HelpBox(Rect position, string message, UnityEditor.MessageType type);
    static public Rect IndentedRect(Rect source);
    static public void InspectorTitlebar(Rect position, Object[] targetObjs);
    static public bool InspectorTitlebar(Rect position, bool foldout, Object targetObj, bool expandable);
    static public bool InspectorTitlebar(Rect position, bool foldout, Object[] targetObjs, bool expandable);
    static public bool InspectorTitlebar(Rect position, bool foldout, UnityEditor.Editor editor);
    static public int IntField(Rect position, int value);
    static public int IntField(Rect position, int value, GUIStyle style);
    static public int IntField(Rect position, string label, int value);
    static public int IntField(Rect position, string label, int value, GUIStyle style);
    static public int IntField(Rect position, GUIContent label, int value);
    static public int IntField(Rect position, GUIContent label, int value, GUIStyle style);
    static public int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues);
    static public int IntPopup(Rect position, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style);
    static public int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues);
    static public int IntPopup(Rect position, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style);
    static public int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues);
    static public int IntPopup(Rect position, GUIContent label, int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style);
    static public void IntPopup(Rect position, UnityEditor.SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues);
    static public void IntPopup(Rect position, UnityEditor.SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label);
    static public int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues);
    static public int IntPopup(Rect position, string label, int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style);
    static public int IntSlider(Rect position, int value, int leftValue, int rightValue);
    static public int IntSlider(Rect position, string label, int value, int leftValue, int rightValue);
    static public int IntSlider(Rect position, GUIContent label, int value, int leftValue, int rightValue);
    static public void IntSlider(Rect position, UnityEditor.SerializedProperty property, int leftValue, int rightValue);
    static public void IntSlider(Rect position, UnityEditor.SerializedProperty property, int leftValue, int rightValue, string label);
    static public void IntSlider(Rect position, UnityEditor.SerializedProperty property, int leftValue, int rightValue, GUIContent label);
    static public void LabelField(Rect position, string label);
    static public void LabelField(Rect position, string label, GUIStyle style);
    static public void LabelField(Rect position, GUIContent label);
    static public void LabelField(Rect position, GUIContent label, GUIStyle style);
    static public void LabelField(Rect position, string label, string label2);
    static public void LabelField(Rect position, string label, string label2, GUIStyle style);
    static public void LabelField(Rect position, GUIContent label, GUIContent label2);
    static public void LabelField(Rect position, GUIContent label, GUIContent label2, GUIStyle style);
    static public int LayerField(Rect position, int layer);
    static public int LayerField(Rect position, int layer, GUIStyle style);
    static public int LayerField(Rect position, string label, int layer);
    static public int LayerField(Rect position, string label, int layer, GUIStyle style);
    static public int LayerField(Rect position, GUIContent label, int layer);
    static public int LayerField(Rect position, GUIContent label, int layer, GUIStyle style);
    static public long LongField(Rect position, long value);
    static public long LongField(Rect position, long value, GUIStyle style);
    static public long LongField(Rect position, string label, long value);
    static public long LongField(Rect position, string label, long value, GUIStyle style);
    static public long LongField(Rect position, GUIContent label, long value);
    static public long LongField(Rect position, GUIContent label, long value, GUIStyle style);
    static public int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions);
    static public int MaskField(Rect position, GUIContent label, int mask, string[] displayedOptions, GUIStyle style);
    static public int MaskField(Rect position, string label, int mask, string[] displayedOptions);
    static public int MaskField(Rect position, string label, int mask, string[] displayedOptions, GUIStyle style);
    static public int MaskField(Rect position, int mask, string[] displayedOptions);
    static public int MaskField(Rect position, int mask, string[] displayedOptions, GUIStyle style);
    static public void MinMaxSlider(GUIContent label, Rect position, float minValue, float maxValue, float minLimit, float maxLimit);
    static public void MinMaxSlider(Rect position, string label, float minValue, float maxValue, float minLimit, float maxLimit);
    static public void MinMaxSlider(Rect position, GUIContent label, float minValue, float maxValue, float minLimit, float maxLimit);
    static public void MinMaxSlider(Rect position, float minValue, float maxValue, float minLimit, float maxLimit);
    static public void MultiFloatField(Rect position, GUIContent label, GUIContent[] subLabels, float[] values);
    static public void MultiFloatField(Rect position, GUIContent[] subLabels, float[] values);
    static public void MultiIntField(Rect position, GUIContent[] subLabels, int[] values);
    static public void MultiPropertyField(Rect position, GUIContent[] subLabels, UnityEditor.SerializedProperty valuesIterator, GUIContent label);
    static public void MultiPropertyField(Rect position, GUIContent[] subLabels, UnityEditor.SerializedProperty valuesIterator);
    static public void ObjectField(Rect position, UnityEditor.SerializedProperty property);
    static public void ObjectField(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    static public void ObjectField(Rect position, UnityEditor.SerializedProperty property, Type objType);
    static public void ObjectField(Rect position, UnityEditor.SerializedProperty property, Type objType, GUIContent label);
    static public Object ObjectField(Rect position, Object obj, Type objType, Object targetBeingEdited);
    static public Object ObjectField(Rect position, Object obj, Type objType, bool allowSceneObjects);
    static public Object ObjectField(Rect position, Object obj, Type objType);
    static public Object ObjectField(Rect position, string label, Object obj, Type objType, Object targetBeingEdited);
    static public Object ObjectField(Rect position, string label, Object obj, Type objType, bool allowSceneObjects);
    static public Object ObjectField(Rect position, string label, Object obj, Type objType);
    static public Object ObjectField(Rect position, GUIContent label, Object obj, Type objType, Object targetBeingEdited);
    static public Object ObjectField(Rect position, GUIContent label, Object obj, Type objType, bool allowSceneObjects);
    static public Object ObjectField(Rect position, GUIContent label, Object obj, Type objType);
    static public string PasswordField(Rect position, string password);
    static public string PasswordField(Rect position, string password, GUIStyle style);
    static public string PasswordField(Rect position, string label, string password);
    static public string PasswordField(Rect position, string label, string password, GUIStyle style);
    static public string PasswordField(Rect position, GUIContent label, string password);
    static public string PasswordField(Rect position, GUIContent label, string password, GUIStyle style);
    static public int Popup(Rect position, int selectedIndex, string[] displayedOptions);
    static public int Popup(Rect position, int selectedIndex, string[] displayedOptions, GUIStyle style);
    static public int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions);
    static public int Popup(Rect position, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style);
    static public int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions);
    static public int Popup(Rect position, string label, int selectedIndex, string[] displayedOptions, GUIStyle style);
    static public int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions);
    static public int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions, GUIStyle style);
    static public Rect PrefixLabel(Rect totalPosition, GUIContent label);
    static public Rect PrefixLabel(Rect totalPosition, GUIContent label, GUIStyle style);
    static public Rect PrefixLabel(Rect totalPosition, int id, GUIContent label);
    static public Rect PrefixLabel(Rect totalPosition, int id, GUIContent label, GUIStyle style);
    static public void ProgressBar(Rect position, float value, string text);
    static public bool PropertyField(Rect position, UnityEditor.SerializedProperty property);
    static public bool PropertyField(Rect position, UnityEditor.SerializedProperty property, bool includeChildren);
    static public bool PropertyField(Rect position, UnityEditor.SerializedProperty property, GUIContent label);
    static public bool PropertyField(Rect position, UnityEditor.SerializedProperty property, GUIContent label, bool includeChildren);
    static public Rect RectField(Rect position, Rect value);
    static public Rect RectField(Rect position, string label, Rect value);
    static public Rect RectField(Rect position, GUIContent label, Rect value);
    static public RectInt RectIntField(Rect position, RectInt value);
    static public RectInt RectIntField(Rect position, string label, RectInt value);
    static public RectInt RectIntField(Rect position, GUIContent label, RectInt value);
    static public void SelectableLabel(Rect position, string text);
    static public void SelectableLabel(Rect position, string text, GUIStyle style);
    static public float Slider(Rect position, float value, float leftValue, float rightValue);
    static public float Slider(Rect position, string label, float value, float leftValue, float rightValue);
    static public float Slider(Rect position, GUIContent label, float value, float leftValue, float rightValue);
    static public void Slider(Rect position, UnityEditor.SerializedProperty property, float leftValue, float rightValue);
    static public void Slider(Rect position, UnityEditor.SerializedProperty property, float leftValue, float rightValue, string label);
    static public void Slider(Rect position, UnityEditor.SerializedProperty property, float leftValue, float rightValue, GUIContent label);
    static public string TagField(Rect position, string tag);
    static public string TagField(Rect position, string tag, GUIStyle style);
    static public string TagField(Rect position, string label, string tag);
    static public string TagField(Rect position, string label, string tag, GUIStyle style);
    static public string TagField(Rect position, GUIContent label, string tag);
    static public string TagField(Rect position, GUIContent label, string tag, GUIStyle style);
    static public string TextArea(Rect position, string text);
    static public string TextArea(Rect position, string text, GUIStyle style);
    static public string TextField(Rect position, string text);
    static public string TextField(Rect position, string text, GUIStyle style);
    static public string TextField(Rect position, string label, string text);
    static public string TextField(Rect position, string label, string text, GUIStyle style);
    static public string TextField(Rect position, GUIContent label, string text);
    static public string TextField(Rect position, GUIContent label, string text, GUIStyle style);
    static public bool Toggle(Rect position, bool value);
    static public bool Toggle(Rect position, string label, bool value);
    static public bool Toggle(Rect position, bool value, GUIStyle style);
    static public bool Toggle(Rect position, string label, bool value, GUIStyle style);
    static public bool Toggle(Rect position, GUIContent label, bool value);
    static public bool Toggle(Rect position, GUIContent label, bool value, GUIStyle style);
    static public bool ToggleLeft(Rect position, string label, bool value);
    static public bool ToggleLeft(Rect position, string label, bool value, GUIStyle labelStyle);
    static public bool ToggleLeft(Rect position, GUIContent label, bool value);
    static public bool ToggleLeft(Rect position, GUIContent label, bool value, GUIStyle labelStyle);
    static public Vector2 Vector2Field(Rect position, string label, Vector2 value);
    static public Vector2 Vector2Field(Rect position, GUIContent label, Vector2 value);
    static public Vector2Int Vector2IntField(Rect position, string label, Vector2Int value);
    static public Vector2Int Vector2IntField(Rect position, GUIContent label, Vector2Int value);
    static public Vector3 Vector3Field(Rect position, string label, Vector3 value);
    static public Vector3 Vector3Field(Rect position, GUIContent label, Vector3 value);
    static public Vector3Int Vector3IntField(Rect position, string label, Vector3Int value);
    static public Vector3Int Vector3IntField(Rect position, GUIContent label, Vector3Int value);
    static public Vector4 Vector4Field(Rect position, string label, Vector4 value);
    static public Vector4 Vector4Field(Rect position, GUIContent label, Vector4 value);

    public EditorGUI();

    public class DisabledGroupScope : Scope
    {
        public DisabledGroupScope(bool disabled);

        protected void CloseScope();

    }

    public struct DisabledScope : IDisposable
    {
        public DisabledScope(bool disabled);

        public void Dispose();

    }

    public class ChangeCheckScope : Scope
    {
        public bool changed { get; }

        public ChangeCheckScope();

        protected void CloseScope();

    }

    public class IndentLevelScope : Scope
    {
        public IndentLevelScope();
        public IndentLevelScope(int increment);

        protected void CloseScope();

    }

    public class PropertyScope : Scope
    {
        public GUIContent content { get; protected set; }

        public PropertyScope(Rect totalPosition, GUIContent label, UnityEditor.SerializedProperty property);

        protected void CloseScope();

    }

}

}
