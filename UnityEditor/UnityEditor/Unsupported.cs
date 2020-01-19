using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class Unsupported
{
    static public bool useScriptableRenderPipeline { get; set; }

    static public bool AreAllParametersInDestination(Object transition, UnityEditor.Animations.AnimatorController controller, List<string> missingParameters);
    static public bool CanPasteParametersToTransition(Object transition, UnityEditor.Animations.AnimatorController controller);
    static public void CaptureScreenshotImmediate(string filePath, int x, int y, int width, int height);
    static public void ClearSkinCache();
    static public bool CopyComponentToPasteboard(Component component);
    static public void CopyGameObjectsToPasteboard();
    static public void CopyStateMachineDataToPasteboard(Object stateMachineObject, UnityEditor.Animations.AnimatorController controller, int layerIndex);
    static public void CopyStateMachineTransitionParametersToPasteboard(Object transition, UnityEditor.Animations.AnimatorController controller);
    static public void DeleteGameObjectSelection();
    static public bool DestinationHasCompatibleParameterTypes(Object transition, UnityEditor.Animations.AnimatorController controller, List<string> mismatchedParameters);
    static public void DuplicateGameObjectsUsingPasteboard();
    static public bool GetApplicationSettingCompressAssetsOnImport();
    static public string GetBaseUnityDeveloperFolder();
    static public int GetLocalIdentifierInFile(int instanceID);
    static public Object GetSerializedAssetInterfaceSingleton(string className);
    static public string[] GetSubmenus(string menuPath);
    static public string[] GetSubmenusCommands(string menuPath);
    static public string[] GetSubmenusIncludingSeparators(string menuPath);
    static public Type GetTypeFromFullName(string fullName);
    static public bool HasStateMachineDataInPasteboard();
    static public bool HasStateMachineTransitionDataInPasteboard();
    static public bool IsBleedingEdgeBuild();
    static public bool IsDestroyScriptableObject(ScriptableObject target);
    static public bool IsDeveloperBuild();
    static public bool IsDeveloperMode();
    static public bool IsHiddenFile(string path);
    static public bool IsNativeCodeBuiltInReleaseMode();
    static public bool IsSourceBuild();
    static public bool PasteComponentFromPasteboard(GameObject go);
    static public bool PasteComponentValuesFromPasteboard(Component component);
    static public void PasteGameObjectsFromPasteboard();
    static public void PasteToStateMachineFromPasteboard(UnityEditor.Animations.AnimatorStateMachine sm, UnityEditor.Animations.AnimatorController controller, int layerIndex, Vector3 position);
    static public void PasteToStateMachineTransitionParametersFromPasteboard(Object transition, UnityEditor.Animations.AnimatorController controller, bool conditions, bool parameters);
    static public void PrepareObjectContextMenu(Object c, int contextUserData);
    static public string ResolveSymlinks(string path);
    static public void RestoreOverrideLightingSettings();
    static public void SceneTrackerFlushDirty();
    static public void SetAllowCursorHide(bool allow);
    static public void SetApplicationSettingCompressAssetsOnImport(bool value);
    static public bool SetOverrideLightingSettings(SceneManagement.Scene scene);
    static public void SetQualitySettingsShadowDistanceTemporarily(float distance);
    static public void SetRenderSettingsUseFogNoDirty(bool fog);
    static public void SmartReset(Object obj);
    static public void StopPlayingImmediately();

}

}
