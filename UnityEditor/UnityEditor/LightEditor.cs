using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class LightEditor : UnityEditor.Editor
{
    static protected Color kGizmoDisabledLight;
    static protected Color kGizmoLight;

    protected Settings settings { get; }

    public LightEditor();

    protected void OnDestroy();
    protected void OnEnable();
    public void OnInspectorGUI();
    protected void OnSceneGUI();

    public sealed class Settings
    {
        public UnityEditor.SerializedProperty areaSizeX { get; private set; }
        public UnityEditor.SerializedProperty areaSizeY { get; private set; }
        public UnityEditor.SerializedProperty bakedShadowAngleProp { get; private set; }
        public UnityEditor.SerializedProperty bakedShadowRadiusProp { get; private set; }
        public UnityEditor.SerializedProperty bounceIntensity { get; private set; }
        public UnityEditor.SerializedProperty color { get; private set; }
        public UnityEditor.SerializedProperty colorTemperature { get; private set; }
        public Texture cookie { get; }
        public UnityEditor.SerializedProperty cookieProp { get; private set; }
        public UnityEditor.SerializedProperty cookieSize { get; private set; }
        public UnityEditor.SerializedProperty cullingMask { get; private set; }
        public UnityEditor.SerializedProperty flare { get; private set; }
        public UnityEditor.SerializedProperty halo { get; private set; }
        public UnityEditor.SerializedProperty innerSpotAngle { get; private set; }
        public UnityEditor.SerializedProperty intensity { get; private set; }
        public bool isAreaLightType { get; }
        public bool isBakedOrMixed { get; }
        public bool isCompletelyBaked { get; }
        public bool isMixed { get; }
        public bool isRealtime { get; }
        public Light light { get; }
        public UnityEditor.SerializedProperty lightmapping { get; private set; }
        public UnityEditor.SerializedProperty lightShape { get; private set; }
        public UnityEditor.SerializedProperty lightType { get; private set; }
        public UnityEditor.SerializedProperty range { get; private set; }
        public UnityEditor.SerializedProperty renderingLayerMask { get; private set; }
        public UnityEditor.SerializedProperty renderMode { get; private set; }
        public UnityEditor.SerializedProperty shadowsBias { get; private set; }
        public UnityEditor.SerializedProperty shadowsNearPlane { get; private set; }
        public UnityEditor.SerializedProperty shadowsNormalBias { get; private set; }
        public UnityEditor.SerializedProperty shadowsResolution { get; private set; }
        public UnityEditor.SerializedProperty shadowsStrength { get; private set; }
        public UnityEditor.SerializedProperty shadowsType { get; private set; }
        public UnityEditor.SerializedProperty spotAngle { get; private set; }
        public UnityEditor.SerializedProperty useColorTemperature { get; private set; }

        public Settings(UnityEditor.SerializedObject so);

        public void ApplyModifiedProperties();
        public void DrawArea();
        public void DrawBakedShadowAngle();
        public void DrawBakedShadowRadius();
        public void DrawBounceIntensity();
        public void DrawColor();
        public void DrawCookie();
        public void DrawCookieSize();
        public void DrawCullingMask();
        public void DrawFlare();
        public void DrawHalo();
        public void DrawInnerAndOuterSpotAngle();
        public void DrawIntensity();
        public void DrawLightmapping();
        public void DrawLightType();
        public void DrawRange();
        public void DrawRange(bool showAreaOptions);
        public void DrawRenderingLayerMask();
        public void DrawRenderMode();
        public void DrawRuntimeShadow();
        public void DrawShadowsType();
        public void DrawSpotAngle();
        public void OnDestroy();
        public void OnEnable();
        public void Update();

    }

}

}
