using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class InternalEditorUtility
{
    static public float defaultScreenHeight { get; }
    static public float defaultScreenWidth { get; }
    static public float defaultWebScreenHeight { get; }
    static public float defaultWebScreenWidth { get; }
    static public int[] expandedProjectWindowItems { get; set; }
    static public bool inBatchMode { get; }
    static public bool isApplicationActive { get; }
    static public bool isHumanControllingUs { get; }
    static public string[] layers { get; }
    static public float remoteScreenHeight { get; }
    static public float remoteScreenWidth { get; }
    static public string[] tags { get; }
    static public string unityPreferencesFolder { get; }

    static public void AddTag(string tag);
    static public UnityEditorInternal.CanAppendBuild BuildCanBeAppended(UnityEditor.BuildTarget target, string location);
    static public void BumpMapSettingsFixingWindowReportResult(int result);
    static public bool BumpMapTextureNeedsFixingInternal(Material material, string propName, bool flaggedAsNormal);
    static public string CalculateHashForObjectsAndDependencies(Object[] objects);
    static public Bounds CalculateSelectionBounds(bool usePivotOnlyForParticles, bool onlyUseActiveSelection);
    static public Bounds CalculateSelectionBounds(bool usePivotOnlyForParticles, bool onlyUseActiveSelection, bool ignoreEditableField);
    static public bool CanConnectToCacheServer();
    static public LayerMask ConcatenatedLayersMaskToLayerMask(int concatenatedLayersMask);
    static public string CountToString(ulong count);
    static public bool CurrentThreadIsMainThread();
    static public UnityEditorInternal.DllType DetectDotNetDll(string path);
    static public int DetermineDepthOrder(Transform lhs, Transform rhs);
    static public bool EnsureSceneHasBeenSaved(string operation);
    static public void ExecuteCommandOnKeyWindow(string commandName);
    static public Texture2D FindIconForFile(string fileName);
    static public ulong FixCacheServerIntegrityErrors();
    static public void FixNormalmapTextureInternal(Material material, string propName);
    static public string GetAssetsFolder();
    static public string GetAuthToken();
    static public string[] GetAvailableDiffTools();
    static public Rect GetBoundsOfDesktopAtPoint(Vector2 pos);
    static public uint GetCrashHandlerProcessID();
    static public string GetCrashReportFolder();
    static public string GetDisplayStringOfInvalidCharsOfFileName(string filename);
    static public string GetEditorAssemblyPath();
    static public string GetEditorFolder();
    static public string[] GetEditorSettingsList(string prefix, int count);
    static public string GetEngineAssemblyPath();
    static public string GetEngineCoreModuleAssemblyPath();
    static public string GetFullUnityVersion();
    static public int GetGameObjectInstanceIDFromComponent(int instanceID);
    static public string[] GetGpuDevices();
    static public Texture2D GetIconForFile(string fileName);
    static public bool GetIsInspectorExpanded(Object obj);
    static public string GetLayerName(int layer);
    static public int[] GetLicenseFlags();
    static public string GetLicenseInfo();
    static public Object GetLoadedObjectFromInstanceID(int instanceID);
    static public List<int> GetNewSelection(int clickedInstanceID, List<int> allInstanceIDs, List<int> selectedInstanceIDs, int lastClickedInstanceID, bool keepMultiSelection, bool useShiftAsActionKey, bool allowMultiSelection);
    static public string GetNoDiffToolsDetectedMessage();
    static public Object GetObjectFromInstanceID(int instanceID);
    static public Camera[] GetSceneViewCameras();
    static public Vector4 GetSpriteOuterUV(Sprite sprite, bool getAtlasData);
    static public Type GetTypeWithoutLoadingObject(int instanceID);
    static public string GetUnityBuildBranch();
    static public string GetUnityCopyright();
    static public int GetUnityRevision();
    static public Version GetUnityVersion();
    static public int GetUnityVersionDate();
    static public string GetUnityVersionDigits();
    static public bool HasAdvancedLicenseOnBuildTarget(UnityEditor.BuildTarget target);
    static public bool HasEduLicense();
    static public bool HasFreeLicense();
    static public bool HasFullscreenCamera();
    static public bool HasPro();
    static public bool HasTeamLicense();
    static public UnityEditor.DragAndDropVisualMode HierarchyWindowDrag(UnityEditor.HierarchyProperty property, HierarchyDropMode dropMode, Transform parentForDraggedObjects, bool perform);
    static public UnityEditor.DragAndDropVisualMode HierarchyWindowDragByID(int hierarchyItemInstanceID, HierarchyDropMode dropMode, Transform parentForDraggedObjects, bool perform);
    static public Material[] InstantiateMaterialsInEditMode(Renderer renderer);
    static public bool IsDotNet4Dll(string path);
    static public bool IsGpuDeviceSelectionSupported();
    static public bool IsInEditorFolder(string path);
    static public bool IsMobilePlatform(UnityEditor.BuildTarget target);
    static public bool IsUnityBeta();
    static public bool IsValidFileName(string filename);
    static public int LayerMaskToConcatenatedLayersMask(LayerMask mask);
    static public System.Reflection.Assembly LoadAssemblyWrapper(string dllName, string dllLocation);
    static public void LoadDefaultLayout();
    static public Object[] LoadSerializedFileAndForget(string path);
    static public void OnGameViewFocus(bool focus);
    static public void OpenEditorConsole();
    static public bool OpenFileAtLineExternal(string filename, int line);
    static public void OpenPlayerConsole();
    static public Color32 PassAndReturnColor32(Color32 c);
    static public Vector2 PassAndReturnVector2(Vector2 v);
    static public UnityEditor.DragAndDropVisualMode ProjectWindowDrag(UnityEditor.HierarchyProperty property, bool perform);
    static public Color[] ReadScreenPixel(Vector2 pixelPos, int sizex, int sizey);
    static public Color[] ReadScreenPixelUnderCursor(Vector2 cursorPosHint, int sizex, int sizey);
    static public void ReloadWindowLayoutMenu();
    static public void RemoveCustomLighting();
    static public string RemoveInvalidCharsFromFileName(string filename, bool logIfInvalidChars);
    static public void RemoveTag(string tag);
    static public void RepaintAllViews();
    static public void RequestScriptReload();
    static public void ResetCursor();
    static public void RevertFactoryLayoutSettings(bool quitOnCancel);
    static public bool SaveCursorToFile(string path, Texture2D image, Vector2 hotSpot);
    static public void SaveEditorSettingsList(string prefix, string[] aList, int count);
    static public void SaveToSerializedFileAndForget(Object[] obj, string path, bool allowTextSerialization);
    static public UnityEditor.DragAndDropVisualMode SceneViewDrag(Object dropUpon, Vector3 worldPosition, Vector2 viewportPosition, Transform parentForDraggedObjects, bool perform);
    static public void SetCustomLighting(Light[] lights, Color ambient);
    static public void SetCustomLightingInternal(Light[] lights, Color ambient);
    static public void SetGpuDeviceAndRecreateGraphics(int index, string name);
    static public void SetIsInspectorExpanded(Object obj, bool isExpanded);
    static public void SetRectTransformTemporaryRect(RectTransform rectTransform, Rect rect);
    static public void SetShowGizmos(bool value);
    static public void SetupShaderMenu(Material material);
    static public void ShowGameView();
    static public void ShowPackageManagerWindow();
    static public void SwitchSkinAndRepaintAllViews();
    static public string TextAreaForDocBrowser(Rect position, string text, GUIStyle style);
    static public string TextifyEvent(Event evt);
    static public Bounds TransformBounds(Bounds b, Transform t);
    static public bool TryOpenErrorFileFromConsole(string path, int line);
    static public ulong VerifyCacheServerIntegrity();

    public InternalEditorUtility();

    public enum HierarchyDropMode
    {
        kHierarchyDragNormal = 0,
        kHierarchyDropUpon = 1,
        kHierarchyDropBetween = 2,
        kHierarchyDropAfterParent = 4,
        kHierarchySearchActive = 8,
        kHierarchyDropAbove = 16,
    }

}

}
