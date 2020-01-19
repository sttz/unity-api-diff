using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public sealed class EditorSceneManager : SceneManagement.SceneManager
{
    static public ulong DefaultSceneCullingMask = 9223372036854775808;

    static public int loadedSceneCount { get; }
    static public UnityEditor.SceneAsset playModeStartScene { get; set; }
    static public bool preventCrossSceneReferences { get; set; }
    static public int previewSceneCount { get; }

    static public event Events.UnityAction<SceneManagement.Scene, SceneManagement.Scene> activeSceneChangedInEditMode;
    static public event NewSceneCreatedCallback newSceneCreated;
    static public event SceneClosedCallback sceneClosed;
    static public event SceneClosingCallback sceneClosing;
    static public event SceneDirtiedCallback sceneDirtied;
    static public event SceneOpenedCallback sceneOpened;
    static public event SceneOpeningCallback sceneOpening;
    static public event SceneSavedCallback sceneSaved;
    static public event SceneSavingCallback sceneSaving;

    static public ulong CalculateAvailableSceneCullingMask();
    static public bool ClosePreviewScene(SceneManagement.Scene scene);
    static public bool CloseScene(SceneManagement.Scene scene, bool removeScene);
    static public bool DetectCrossSceneReferences(SceneManagement.Scene scene);
    static public bool EnsureUntitledSceneHasBeenSaved(string dialogContent);
    static public ulong GetSceneCullingMask(SceneManagement.Scene scene);
    static public UnityEditor.SceneManagement.SceneSetup[] GetSceneManagerSetup();
    static public bool IsPreviewScene(SceneManagement.Scene scene);
    static public bool IsPreviewSceneObject(Object obj);
    static public AsyncOperation LoadSceneAsyncInPlayMode(string path, SceneManagement.LoadSceneParameters parameters);
    static public SceneManagement.Scene LoadSceneInPlayMode(string path, SceneManagement.LoadSceneParameters parameters);
    static public void MarkAllScenesDirty();
    static public bool MarkSceneDirty(SceneManagement.Scene scene);
    static public void MoveSceneAfter(SceneManagement.Scene src, SceneManagement.Scene dst);
    static public void MoveSceneBefore(SceneManagement.Scene src, SceneManagement.Scene dst);
    static public SceneManagement.Scene NewPreviewScene();
    static public SceneManagement.Scene NewScene(UnityEditor.SceneManagement.NewSceneSetup setup);
    static public SceneManagement.Scene NewScene(UnityEditor.SceneManagement.NewSceneSetup setup, UnityEditor.SceneManagement.NewSceneMode mode);
    static public SceneManagement.Scene OpenScene(string scenePath);
    static public SceneManagement.Scene OpenScene(string scenePath, UnityEditor.SceneManagement.OpenSceneMode mode);
    static public void RestoreSceneManagerSetup(UnityEditor.SceneManagement.SceneSetup[] value);
    static public bool SaveCurrentModifiedScenesIfUserWantsTo();
    static public bool SaveModifiedScenesIfUserWantsTo(SceneManagement.Scene[] scenes);
    static public bool SaveOpenScenes();
    static public bool SaveScene(SceneManagement.Scene scene);
    static public bool SaveScene(SceneManagement.Scene scene, string dstScenePath);
    static public bool SaveScene(SceneManagement.Scene scene, string dstScenePath, bool saveAsCopy);
    static public bool SaveScenes(SceneManagement.Scene[] scenes);
    static public void SetSceneCullingMask(SceneManagement.Scene scene, ulong sceneCullingMask);

    public EditorSceneManager();

    public delegate void NewSceneCreatedCallback(SceneManagement.Scene scene, UnityEditor.SceneManagement.NewSceneSetup setup, UnityEditor.SceneManagement.NewSceneMode mode);

    public delegate void SceneClosedCallback(SceneManagement.Scene scene);

    public delegate void SceneClosingCallback(SceneManagement.Scene scene, bool removingScene);

    public delegate void SceneDirtiedCallback(SceneManagement.Scene scene);

    public delegate void SceneOpenedCallback(SceneManagement.Scene scene, UnityEditor.SceneManagement.OpenSceneMode mode);

    public delegate void SceneOpeningCallback(string path, UnityEditor.SceneManagement.OpenSceneMode mode);

    public delegate void SceneSavedCallback(SceneManagement.Scene scene);

    public delegate void SceneSavingCallback(SceneManagement.Scene scene, string path);

}

}
