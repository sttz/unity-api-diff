using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorApplication
{
    static public SerializedPropertyCallbackFunction contextualPropertyMenu;
    static public CallbackFunction delayCall;
    static public CallbackFunction hierarchyWindowChanged;
    static public HierarchyWindowItemCallback hierarchyWindowItemOnGUI;
    static public CallbackFunction modifierKeysChanged;
    static public CallbackFunction playmodeStateChanged;
    static public CallbackFunction projectWindowChanged;
    static public ProjectWindowItemCallback projectWindowItemOnGUI;
    static public CallbackFunction searchChanged;
    static public CallbackFunction update;

    static public string applicationContentsPath { get; }
    static public string applicationPath { get; }
    static public string currentScene { get; set; }
    static public bool isCompiling { get; }
    static public bool isPaused { get; set; }
    static public bool isPlaying { get; set; }
    static public bool isPlayingOrWillChangePlaymode { get; }
    static public bool isRemoteConnected { get; }
    static public bool isSceneDirty { get; }
    static public bool isTemporaryProject { get; }
    static public bool isUpdating { get; }
    static public UnityEditor.ScriptingRuntimeVersion scriptingRuntimeVersion { get; }
    static public double timeSinceStartup { get; }

    static public event Action hierarchyChanged;
    static public event Action<UnityEditor.PauseState> pauseStateChanged;
    static public event Action<UnityEditor.PlayModeStateChange> playModeStateChanged;
    static public event Action projectChanged;
    static public event Action quitting;
    static public event Func<bool> wantsToQuit;

    static public void Beep();
    static public void DirtyHierarchyWindowSorting();
    static public bool ExecuteMenuItem(string menuItemPath);
    static public void Exit(int returnValue);
    static public AsyncOperation LoadLevelAdditiveAsyncInPlayMode(string path);
    static public void LoadLevelAdditiveInPlayMode(string path);
    static public AsyncOperation LoadLevelAsyncInPlayMode(string path);
    static public void LoadLevelInPlayMode(string path);
    static public void LockReloadAssemblies();
    static public void MarkSceneDirty();
    static public void NewEmptyScene();
    static public void NewScene();
    static public void OpenProject(string projectPath, string[] args);
    static public bool OpenScene(string path);
    static public void OpenSceneAdditive(string path);
    static public void QueuePlayerLoopUpdate();
    static public void RepaintAnimationWindow();
    static public void RepaintHierarchyWindow();
    static public void RepaintProjectWindow();
    static public void SaveAssets();
    static public bool SaveCurrentSceneIfUserWantsTo();
    static public bool SaveScene();
    static public bool SaveScene(string path);
    static public bool SaveScene(string path, bool saveAsCopy);
    static public void SetTemporaryProjectKeepPath(string path);
    static public void Step();
    static public void UnlockReloadAssemblies();

    public EditorApplication();

    public delegate void ProjectWindowItemCallback(string guid, Rect selectionRect);

    public delegate void HierarchyWindowItemCallback(int instanceID, Rect selectionRect);

    public delegate void CallbackFunction();

    public delegate void SerializedPropertyCallbackFunction(UnityEditor.GenericMenu menu, UnityEditor.SerializedProperty property);

}

}
