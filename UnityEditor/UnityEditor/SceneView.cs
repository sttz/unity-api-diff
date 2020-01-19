using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SceneView : UnityEditor.SearchableEditorWindow, UnityEditor.IHasCustomMenu
{
    static public OnSceneFunc onSceneGUIDelegate;

    static public UnityEditor.SceneView currentDrawingSceneView { get; }
    static public UnityEditor.SceneView lastActiveSceneView { get; }
    static public ArrayList sceneViews { get; }

    static public CameraMode AddCameraMode(string name, string section);
    static public void ClearUserDefinedCameraModes();
    static public bool FrameLastActiveSceneView();
    static public bool FrameLastActiveSceneViewWithLock();
    static public Camera[] GetAllSceneCameras();
    static public CameraMode GetBuiltinCameraMode(UnityEditor.DrawCameraMode cameraMode);
    static public void RepaintAll();
    static public void ShowCompileErrorNotification();

    public bool m_AudioPlay;
    public UnityEditor.DrawCameraMode m_RenderMode;
    public bool m_SceneLighting;
    public bool m_ValidateTrueMetals;

    public Camera camera { get; }
    public float cameraDistance { get; }
    public CameraMode cameraMode { get; set; }
    public bool in2DMode { get; set; }
    public bool isRotationLocked { get; set; }
    public Quaternion lastSceneViewRotation { get; set; }
    public bool orthographic { get; set; }
    public Vector3 pivot { get; set; }
    public UnityEditor.DrawCameraMode renderMode { get; set; }
    public Quaternion rotation { get; set; }
    public SceneViewState sceneViewState { get; set; }
    public float size { get; set; }

    public event Action<CameraMode> onCameraModeChanged;
    public event Func<CameraMode, bool> onValidateCameraMode;

    public SceneView();

    public void AddItemsToMenu(UnityEditor.GenericMenu menu);
    public void AlignViewToObject(Transform t);
    public void AlignWithView();
    public void FixNegativeSize();
    public bool Frame(Bounds bounds, bool instant = true);
    public bool FrameSelected();
    public bool FrameSelected(bool lockView);
    public bool FrameSelected(bool lockView, bool instant);
    public bool IsCameraDrawModeEnabled(CameraMode mode);
    public void LookAt(Vector3 pos);
    public void LookAt(Vector3 pos, Quaternion rot);
    public void LookAt(Vector3 pos, Quaternion rot, float newSize);
    public void LookAt(Vector3 pos, Quaternion rot, float newSize, bool ortho);
    public void LookAt(Vector3 pos, Quaternion rot, float newSize, bool ortho, bool instant);
    public void LookAtDirect(Vector3 pos, Quaternion rot);
    public void LookAtDirect(Vector3 pos, Quaternion rot, float newSize);
    public void MoveToView();
    public void MoveToView(Transform target);
    public void OnDestroy();
    public void OnDisable();
    public void OnEnable();
    protected void OnGUI();
    public void OnSelectionChange();
    public void SetSceneViewFiltering(bool enable);
    public void SetSceneViewShaderReplace(Shader shader, string replaceString);
    protected bool SupportsStageHandling();

    public struct CameraMode
    {
        public UnityEditor.DrawCameraMode drawMode;
        public string name;
        public string section;

        public bool Equals(object otherObject);
        public int GetHashCode();
        public string ToString();

    }

    public delegate void OnSceneFunc(UnityEditor.SceneView sceneView);

    public class SceneViewState
    {
        public bool showFlares;
        public bool showFog;
        public bool showImageEffects;
        public bool showMaterialUpdate;
        public bool showParticleSystems;
        public bool showSkybox;

        public SceneViewState();
        public SceneViewState(SceneViewState other);

        public bool IsAllOn();
        public void Toggle(bool value);

    }

}

}
