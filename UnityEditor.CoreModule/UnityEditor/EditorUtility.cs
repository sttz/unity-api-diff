using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class EditorUtility
{
    static public bool audioMasterMute { get; set; }
    static public bool scriptCompilationFailed { get; }

    static public bool BuildResourceFile(Object[] selection, string pathName);
    static public void ClearDirty(Object target);
    static public void ClearProgressBar();
    static public Object[] CollectDeepHierarchy(Object[] roots);
    static public Object[] CollectDependencies(Object[] roots);
    static public string[] CompileCSharp(string[] scripts, string[] references, string[] defines, string outputAssembly);
    static public void CompressCubemapTexture(Cubemap texture, TextureFormat format, int quality);
    static public void CompressCubemapTexture(Cubemap texture, TextureFormat format, UnityEditor.TextureCompressionQuality quality);
    static public void CompressTexture(Texture2D texture, TextureFormat format, int quality);
    static public void CompressTexture(Texture2D texture, TextureFormat format, UnityEditor.TextureCompressionQuality quality);
    static public void CopySerialized(Object source, Object dest);
    static public void CopySerializedIfDifferent(Object source, Object dest);
    static public void CopySerializedManagedFieldsOnly(object source, object dest);
    static public Object CreateEmptyPrefab(string path);
    static public GameObject CreateGameObjectWithHideFlags(string name, HideFlags flags, Type[] components);
    static public bool DisplayCancelableProgressBar(string title, string info, float progress);
    static public void DisplayCustomMenu(Rect position, GUIContent[] options, int selected, SelectMenuItemFunction callback, object userData);
    static public void DisplayCustomMenu(Rect position, GUIContent[] options, int selected, SelectMenuItemFunction callback, object userData, bool showHotkey);
    static public void DisplayCustomMenu(Rect position, GUIContent[] options, Func<int, bool> checkEnabled, int selected, SelectMenuItemFunction callback, object userData, bool showHotkey = false);
    static public void DisplayCustomMenuWithSeparators(Rect position, string[] options, bool[] enabled, bool[] separator, int[] selected, SelectMenuItemFunction callback, object userData);
    static public bool DisplayDialog(string title, string message, string ok);
    static public bool DisplayDialog(string title, string message, string ok, string cancel);
    static public bool DisplayDialog(string title, string message, string ok, UnityEditor.DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
    static public bool DisplayDialog(string title, string message, string ok, string cancel, UnityEditor.DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
    static public int DisplayDialogComplex(string title, string message, string ok, string cancel, string alt);
    static public void DisplayPopupMenu(Rect position, string menuItemPath, UnityEditor.MenuCommand command);
    static public void DisplayProgressBar(string title, string info, float progress);
    static public bool ExtractOggFile(Object obj, string path);
    static public Object FindAsset(string path, Type type);
    static public GameObject FindPrefabRoot(GameObject source);
    static public void FocusProjectWindow();
    static public string FormatBytes(int bytes);
    static public string FormatBytes(long bytes);
    static public string GetAssetPath(Object asset);
    static public bool GetDialogOptOutDecision(UnityEditor.DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
    static public int GetDirtyCount(int instanceID);
    static public int GetDirtyCount(Object target);
    static public int GetObjectEnabled(Object target);
    static public Object GetPrefabParent(Object source);
    static public UnityEditor.PrefabType GetPrefabType(Object target);
    static public Object InstanceIDToObject(int instanceID);
    static public Object InstantiatePrefab(Object target);
    static public string InvokeDiffTool(string leftTitle, string leftFile, string rightTitle, string rightFile, string ancestorTitle, string ancestorFile);
    static public bool IsDirty(int instanceID);
    static public bool IsDirty(Object target);
    static public bool IsPersistent(Object target);
    static public bool IsRunningUnderCPUEmulation();
    static public bool LoadWindowLayout(string path);
    static public int NaturalCompare(string a, string b);
    static public string OpenFilePanel(string title, string directory, string extension);
    static public string OpenFilePanelWithFilters(string title, string directory, string[] filters);
    static public string OpenFolderPanel(string title, string folder, string defaultName);
    static public void OpenWithDefaultApp(string fileName);
    static public bool ReconnectToLastPrefab(GameObject go);
    static public GameObject ReplacePrefab(GameObject go, Object targetPrefab);
    static public GameObject ReplacePrefab(GameObject go, Object targetPrefab, UnityEditor.ReplacePrefabOptions options);
    static public void RequestScriptReload();
    static public bool ResetToPrefabState(Object source);
    static public void RevealInFinder(string path);
    static public string SaveFilePanel(string title, string directory, string defaultName, string extension);
    static public string SaveFilePanelInProject(string title, string defaultName, string extension, string message);
    static public string SaveFilePanelInProject(string title, string defaultName, string extension, string message, string path);
    static public string SaveFolderPanel(string title, string folder, string defaultName);
    static public void SetCameraAnimateMaterials(Camera camera, bool animate);
    static public void SetCameraAnimateMaterialsTime(Camera camera, float time);
    static public void SetCustomDiffTool(string path, string twoWayDiff, string threeWayDiff, string mergeCommand, bool forceEnableCustomTool = false);
    static public void SetDialogOptOutDecision(UnityEditor.DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey, bool optOutDecision);
    static public void SetDirty(Object target);
    static public void SetObjectEnabled(Object target, bool enabled);
    static public void SetSelectedRenderState(Renderer renderer, UnityEditor.EditorSelectedRenderState renderState);
    static public void SetSelectedWireframeHidden(Renderer renderer, bool enabled);
    static public void UnloadUnusedAssets();
    static public void UnloadUnusedAssetsIgnoreManagedReferences();
    static public void UnloadUnusedAssetsImmediate();
    static public void UnloadUnusedAssetsImmediate(bool includeMonoReferencesAsRoots);
    static public void UpdateGlobalShaderProperties(float time);
    static public bool WarnPrefab(Object target, string title, string warning, string okButton);

    public EditorUtility();

    public delegate void SelectMenuItemFunction(object userData, string[] options, int selected);

}

}
