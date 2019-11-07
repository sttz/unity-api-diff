using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorGUIUtility : GUIUtility
{
    static public FocusType native;

    static public float currentViewWidth { get; }
    static public bool editingTextField { get; set; }
    static public float fieldWidth { get; set; }
    static public bool hierarchyMode { get; set; }
    static public bool isProSkin { get; }
    static public float labelWidth { get; set; }
    static public float pixelsPerPoint { get; }
    static public float singleLineHeight { get; }
    static public float standardVerticalSpacing { get; }
    static public string systemCopyBuffer { get; set; }
    static public bool textFieldHasSelection { get; }
    static public Texture2D whiteTexture { get; }
    static public bool wideMode { get; set; }

    static public void AddCursorRect(Rect position, UnityEditor.MouseCursor mouse);
    static public void AddCursorRect(Rect position, UnityEditor.MouseCursor mouse, int controlID);
    static public Event CommandEvent(string commandName);
    static public void DrawColorSwatch(Rect position, Color color);
    static public void DrawCurveSwatch(Rect position, AnimationCurve curve, UnityEditor.SerializedProperty property, Color color, Color bgColor);
    static public void DrawCurveSwatch(Rect position, AnimationCurve curve, UnityEditor.SerializedProperty property, Color color, Color bgColor, Color topFillColor, Color bottomFillColor);
    static public void DrawCurveSwatch(Rect position, AnimationCurve curve, UnityEditor.SerializedProperty property, Color color, Color bgColor, Color topFillColor, Color bottomFillColor, Rect curveRanges);
    static public void DrawCurveSwatch(Rect position, AnimationCurve curve, UnityEditor.SerializedProperty property, Color color, Color bgColor, Rect curveRanges);
    static public void DrawRegionSwatch(Rect position, UnityEditor.SerializedProperty property, UnityEditor.SerializedProperty property2, Color color, Color bgColor, Rect curveRanges);
    static public void DrawRegionSwatch(Rect position, AnimationCurve curve, AnimationCurve curve2, Color color, Color bgColor, Rect curveRanges);
    static public Texture2D FindTexture(string name);
    static public GUISkin GetBuiltinSkin(UnityEditor.EditorSkin skin);
    static public System.Collections.Generic.List<Rect> GetFlowLayoutedRects(Rect rect, GUIStyle style, float horizontalSpacing, float verticalSpacing, System.Collections.Generic.List<string> items);
    static public Vector2 GetIconSize();
    static public Rect GetMainWindowPosition();
    static public int GetObjectPickerControlID();
    static public Object GetObjectPickerObject();
    static public bool HasObjectThumbnail(Type objType);
    static public Color HSVToRGB(float H, float S, float V);
    static public Color HSVToRGB(float H, float S, float V, bool hdr);
    static public GUIContent IconContent(string name);
    static public GUIContent IconContent(string name, string text);
    static public bool IsDisplayReferencedByCameras(int displayIndex);
    static public Object Load(string path);
    static public Object LoadRequired(string path);
    static public void LookLikeControls(float _labelWidth, float _fieldWidth);
    static public void LookLikeControls(float _labelWidth);
    static public void LookLikeControls();
    static public void LookLikeInspector();
    static public GUIContent ObjectContent(Object obj, Type type);
    static public void PingObject(Object obj);
    static public void PingObject(int targetInstanceID);
    static public Rect PixelsToPoints(Rect rect);
    static public Vector2 PixelsToPoints(Vector2 position);
    static public Rect PointsToPixels(Rect rect);
    static public Vector2 PointsToPixels(Vector2 position);
    static public void QueueGameViewInputEvent(Event evt);
    static public void RenderGameViewCameras(RenderTexture target, int targetDisplay, Rect screenRect, Vector2 mousePosition, bool gizmos);
    static public void RenderGameViewCameras(Rect cameraRect, bool gizmos, bool gui);
    static public void RenderGameViewCameras(Rect cameraRect, Rect statsRect, bool gizmos, bool gui);
    static public void RGBToHSV(Color rgbColor, out float H, out float S, out float V);
    static public string SerializeMainMenuToString();
    static public void SetIconSize(Vector2 size);
    static public void SetMenuLocalizationTestMode(bool onoff);
    static public void SetWantsMouseJumping(int wantz);
    static public void ShowObjectPicker(Object obj, bool allowSceneObjects, string searchFilter, int controlID);
    static public GUIContent TrIconContent(string iconName, string tooltip = null);
    static public GUIContent TrIconContent(Texture icon, string tooltip = null);
    static public GUIContent TrTempContent(string t);
    static public GUIContent[] TrTempContent(string[] texts);
    static public GUIContent[] TrTempContent(string[] texts, string[] tooltips);
    static public GUIContent TrTextContent(string key, string text, string tooltip, Texture icon);
    static public GUIContent TrTextContent(string text, string tooltip = null, Texture icon = null);
    static public GUIContent TrTextContent(string text, string tooltip, string iconName);
    static public GUIContent TrTextContent(string text, Texture icon);
    static public GUIContent TrTextContentWithIcon(string text, Texture icon);
    static public GUIContent TrTextContentWithIcon(string text, string iconName);
    static public GUIContent TrTextContentWithIcon(string text, string tooltip, string iconName);
    static public GUIContent TrTextContentWithIcon(string text, string tooltip, Texture icon);
    static public GUIContent TrTextContentWithIcon(string text, string tooltip, UnityEditor.MessageType messageType);
    static public GUIContent TrTextContentWithIcon(string text, UnityEditor.MessageType messageType);

    public EditorGUIUtility();

    public class IconSizeScope : Scope
    {
        public IconSizeScope(Vector2 iconSizeWithinScope);

        protected void CloseScope();

    }

}

}
