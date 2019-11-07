using System;
using UnityEngine;

namespace UnityEditor
{

public class MaterialEditor : UnityEditor.Editor
{
    static public int kMiniTextureFieldLabelIndentLevel = 2;

    static public void ApplyMaterialPropertyDrawers(Material material);
    static public void ApplyMaterialPropertyDrawers(Object[] targets);
    static public void FixupEmissiveFlag(Material mat);
    static public MaterialGlobalIlluminationFlags FixupEmissiveFlag(Color col, MaterialGlobalIlluminationFlags flags);
    static public float GetDefaultPropertyHeight(UnityEditor.MaterialProperty prop);
    static public Rect GetFlexibleRectBetweenFieldAndRightEdge(Rect r);
    static public Rect GetFlexibleRectBetweenLabelAndField(Rect r);
    static public Rect GetLeftAlignedFieldRect(Rect r);
    static public UnityEditor.MaterialProperty[] GetMaterialProperties(Object[] mats);
    static public UnityEditor.MaterialProperty GetMaterialProperty(Object[] mats, string name);
    static public UnityEditor.MaterialProperty GetMaterialProperty(Object[] mats, int propertyIndex);
    static public Rect GetRectAfterLabelWidth(Rect r);
    static public Rect GetRightAlignedFieldRect(Rect r);
    static public Renderer PrepareMaterialPropertiesForAnimationMode(UnityEditor.MaterialProperty[] properties, bool isMaterialEditable);
    static public Vector4 TextureScaleOffsetProperty(Rect position, Vector4 scaleOffset);
    static public Vector4 TextureScaleOffsetProperty(Rect position, Vector4 scaleOffset, bool partOfTexturePropertyControl);

    public bool isVisible { get; }

    public MaterialEditor();

    public void Awake();
    public void BeginAnimatedCheck(Rect totalPosition, UnityEditor.MaterialProperty prop);
    public void BeginAnimatedCheck(UnityEditor.MaterialProperty prop);
    public Color ColorProperty(UnityEditor.MaterialProperty prop, string label);
    public Color ColorProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public Color ColorProperty(string propertyName, string label);
    public void DefaultPreviewGUI(Rect r, GUIStyle background);
    public void DefaultPreviewSettingsGUI();
    public void DefaultShaderProperty(UnityEditor.MaterialProperty prop, string label);
    public void DefaultShaderProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public bool DoubleSidedGIField();
    public bool EmissionEnabledProperty();
    public bool EnableInstancingField();
    public void EnableInstancingField(Rect r);
    public void EndAnimatedCheck();
    public float FloatProperty(UnityEditor.MaterialProperty prop, string label);
    public float FloatProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public float FloatProperty(string propertyName, string label);
    public Color GetColor(string propertyName, out bool hasMixedValue);
    public float GetFloat(string propertyName, out bool hasMixedValue);
    public float GetPropertyHeight(UnityEditor.MaterialProperty prop);
    public float GetPropertyHeight(UnityEditor.MaterialProperty prop, string label);
    public Texture GetTexture(string propertyName, out bool hasMixedValue);
    public Vector2 GetTextureOffset(string propertyName, out bool hasMixedValueX, out bool hasMixedValueY);
    public Rect GetTexturePropertyCustomArea(Rect position);
    public Vector2 GetTextureScale(string propertyName, out bool hasMixedValueX, out bool hasMixedValueY);
    public Vector4 GetVector(string propertyName, out bool hasMixedValue);
    public bool HasPreviewGUI();
    public bool HelpBoxWithButton(GUIContent messageContent, GUIContent buttonContent);
    public bool IsInstancingEnabled();
    public void LightmapEmissionFlagsProperty(int indent, bool enabled);
    public void LightmapEmissionProperty();
    public void LightmapEmissionProperty(int labelIndent);
    public void LightmapEmissionProperty(Rect position, int labelIndent);
    public void OnDisable();
    public void OnEnable();
    protected void OnHeaderGUI();
    public void OnInspectorGUI();
    public void OnInteractivePreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewSettings();
    protected void OnShaderChanged();
    public void PropertiesChanged();
    public void PropertiesDefaultGUI(UnityEditor.MaterialProperty[] props);
    public bool PropertiesGUI();
    public float RangeProperty(UnityEditor.MaterialProperty prop, string label);
    public float RangeProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public float RangeProperty(string propertyName, string label, float v2, float v3);
    public void RegisterPropertyChangeUndo(string label);
    public void RenderQueueField();
    public void RenderQueueField(Rect r);
    public Texture2D RenderStaticPreview(string assetPath, Object[] subAssets, int width, int height);
    public bool RequiresConstantRepaint();
    public void SetColor(string propertyName, Color value);
    public void SetDefaultGUIWidths();
    public void SetFloat(string propertyName, float value);
    public void SetShader(Shader shader);
    public void SetShader(Shader newShader, bool registerUndo);
    public void SetTexture(string propertyName, Texture value);
    public void SetTextureOffset(string propertyName, Vector2 value, int coord);
    public void SetTextureScale(string propertyName, Vector2 value, int coord);
    public void SetVector(string propertyName, Vector4 value);
    public void ShaderProperty(UnityEditor.MaterialProperty prop, string label);
    public void ShaderProperty(UnityEditor.MaterialProperty prop, GUIContent label);
    public void ShaderProperty(UnityEditor.MaterialProperty prop, string label, int labelIndent);
    public void ShaderProperty(UnityEditor.MaterialProperty prop, GUIContent label, int labelIndent);
    public void ShaderProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public void ShaderProperty(Rect position, UnityEditor.MaterialProperty prop, GUIContent label);
    public void ShaderProperty(Rect position, UnityEditor.MaterialProperty prop, string label, int labelIndent);
    public void ShaderProperty(Rect position, UnityEditor.MaterialProperty prop, GUIContent label, int labelIndent);
    public void ShaderProperty(Shader shader, int propertyIndex);
    public void TextureCompatibilityWarning(UnityEditor.MaterialProperty prop);
    public Texture TextureProperty(UnityEditor.MaterialProperty prop, string label);
    public Texture TextureProperty(UnityEditor.MaterialProperty prop, string label, bool scaleOffset);
    public Texture TextureProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public Texture TextureProperty(Rect position, UnityEditor.MaterialProperty prop, string label, bool scaleOffset);
    public Texture TextureProperty(Rect position, UnityEditor.MaterialProperty prop, string label, string tooltip, bool scaleOffset);
    public Texture TextureProperty(string propertyName, string label, ShaderPropertyTexDim texDim);
    public Texture TextureProperty(string propertyName, string label, ShaderPropertyTexDim texDim, bool scaleOffset);
    public Texture TexturePropertyMiniThumbnail(Rect position, UnityEditor.MaterialProperty prop, string label, string tooltip);
    public Rect TexturePropertySingleLine(GUIContent label, UnityEditor.MaterialProperty textureProp);
    public Rect TexturePropertySingleLine(GUIContent label, UnityEditor.MaterialProperty textureProp, UnityEditor.MaterialProperty extraProperty1);
    public Rect TexturePropertySingleLine(GUIContent label, UnityEditor.MaterialProperty textureProp, UnityEditor.MaterialProperty extraProperty1, UnityEditor.MaterialProperty extraProperty2);
    public Rect TexturePropertyTwoLines(GUIContent label, UnityEditor.MaterialProperty textureProp, UnityEditor.MaterialProperty extraProperty1, GUIContent label2, UnityEditor.MaterialProperty extraProperty2);
    public Rect TexturePropertyWithHDRColor(GUIContent label, UnityEditor.MaterialProperty textureProp, UnityEditor.MaterialProperty colorProperty, UnityEditor.ColorPickerHDRConfig hdrConfig, bool showAlpha);
    public Rect TexturePropertyWithHDRColor(GUIContent label, UnityEditor.MaterialProperty textureProp, UnityEditor.MaterialProperty colorProperty, bool showAlpha);
    public void TextureScaleOffsetProperty(UnityEditor.MaterialProperty property);
    public float TextureScaleOffsetProperty(Rect position, UnityEditor.MaterialProperty property);
    public float TextureScaleOffsetProperty(Rect position, UnityEditor.MaterialProperty property, bool partOfTexturePropertyControl);
    public void UndoRedoPerformed();
    public Vector4 VectorProperty(UnityEditor.MaterialProperty prop, string label);
    public Vector4 VectorProperty(Rect position, UnityEditor.MaterialProperty prop, string label);
    public Vector4 VectorProperty(string propertyName, string label);

}

}
