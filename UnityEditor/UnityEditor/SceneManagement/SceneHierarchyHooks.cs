using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public static class SceneHierarchyHooks
{
    static public Func<SubSceneInfo, string> provideSubSceneName;
    static public Func<SubSceneInfo[]> provideSubScenes;

    static public event Action<UnityEditor.GenericMenu, GameObject> addItemsToGameObjectContextMenu;
    static public event Action<UnityEditor.GenericMenu, SceneManagement.Scene> addItemsToSceneHeaderContextMenu;

    static public bool CanMoveTransformToScene(Transform transform, SceneManagement.Scene scene);
    static public bool CanSetNewParent(Transform transform, Transform newParent);
    static public void ReloadAllSceneHierarchies();

    public struct SubSceneInfo
    {
        public Color32 color;
        public SceneManagement.Scene scene;
        public UnityEditor.SceneAsset sceneAsset;
        public string sceneName;
        public Transform transform;

        public bool isValid { get; }

    }

}

}
