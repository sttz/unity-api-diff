using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class PrefabUtility
{
    static public PrefabInstanceUpdated prefabInstanceUpdated;

    static public void ApplyAddedComponent(Component component, string assetPath, UnityEditor.InteractionMode action);
    static public void ApplyAddedGameObject(GameObject gameObject, string assetPath, UnityEditor.InteractionMode action);
    static public void ApplyObjectOverride(Object instanceComponentOrGameObject, string assetPath, UnityEditor.InteractionMode action);
    static public void ApplyPrefabInstance(GameObject instanceRoot, UnityEditor.InteractionMode action);
    static public void ApplyPropertyOverride(UnityEditor.SerializedProperty instanceProperty, string assetPath, UnityEditor.InteractionMode action);
    static public void ApplyRemovedComponent(GameObject instanceGameObject, Component assetComponent, UnityEditor.InteractionMode action);
    static public GameObject ConnectGameObjectToPrefab(GameObject go, GameObject sourcePrefab);
    static public Object CreateEmptyPrefab(string path);
    static public GameObject CreatePrefab(string path, GameObject go);
    static public GameObject CreatePrefab(string path, GameObject go, UnityEditor.ReplacePrefabOptions options);
    static public void DisconnectPrefabInstance(Object targetObject);
    static public GameObject FindPrefabRoot(GameObject source);
    static public GameObject FindRootGameObjectWithSameParentPrefab(GameObject target);
    static public GameObject FindValidUploadPrefabInstanceRoot(GameObject target);
    static public System.Collections.Generic.List<UnityEditor.SceneManagement.AddedComponent> GetAddedComponents(GameObject prefabInstance);
    static public System.Collections.Generic.List<UnityEditor.SceneManagement.AddedGameObject> GetAddedGameObjects(GameObject prefabInstance);
    static public TObject GetCorrespondingObjectFromOriginalSource(TObject componentOrGameObject);
    static public TObject GetCorrespondingObjectFromSource(TObject componentOrGameObject);
    static public TObject GetCorrespondingObjectFromSourceAtPath(TObject componentOrGameObject, string assetPath);
    static public Texture2D GetIconForGameObject(GameObject gameObject);
    static public GameObject GetNearestPrefabInstanceRoot(Object componentOrGameObject);
    static public System.Collections.Generic.List<UnityEditor.SceneManagement.ObjectOverride> GetObjectOverrides(GameObject prefabInstance, bool includeDefaultOverrides = false);
    static public GameObject GetOutermostPrefabInstanceRoot(Object componentOrGameObject);
    static public string GetPrefabAssetPathOfNearestInstanceRoot(Object instanceComponentOrGameObject);
    static public UnityEditor.PrefabAssetType GetPrefabAssetType(Object componentOrGameObject);
    static public Object GetPrefabInstanceHandle(Object instanceComponentOrGameObject);
    static public UnityEditor.PrefabInstanceStatus GetPrefabInstanceStatus(Object componentOrGameObject);
    static public Object GetPrefabObject(Object targetObject);
    static public Object GetPrefabParent(Object obj);
    static public UnityEditor.PrefabType GetPrefabType(Object target);
    static public UnityEditor.PropertyModification[] GetPropertyModifications(Object targetPrefab);
    static public System.Collections.Generic.List<UnityEditor.SceneManagement.RemovedComponent> GetRemovedComponents(GameObject prefabInstance);
    static public bool HasPrefabInstanceAnyOverrides(GameObject instanceRoot, bool includeDefaultOverrides);
    static public Object InstantiateAttachedAsset(Object targetObject);
    static public Object InstantiatePrefab(Object assetComponentOrGameObject);
    static public Object InstantiatePrefab(Object assetComponentOrGameObject, SceneManagement.Scene destinationScene);
    static public Object InstantiatePrefab(Object assetComponentOrGameObject, Transform parent);
    static public bool IsAddedComponentOverride(Object component);
    static public bool IsAddedGameObjectOverride(GameObject gameObject);
    static public bool IsAnyPrefabInstanceRoot(GameObject gameObject);
    static public bool IsDefaultOverride(UnityEditor.PropertyModification modification);
    static public bool IsDisconnectedFromPrefabAsset(Object componentOrGameObject);
    static public bool IsOutermostPrefabInstanceRoot(GameObject gameObject);
    static public bool IsPartOfAnyPrefab(Object componentOrGameObject);
    static public bool IsPartOfImmutablePrefab(Object componentOrGameObject);
    static public bool IsPartOfModelPrefab(Object componentOrGameObject);
    static public bool IsPartOfNonAssetPrefabInstance(Object componentOrGameObject);
    static public bool IsPartOfPrefabAsset(Object componentOrGameObject);
    static public bool IsPartOfPrefabInstance(Object componentOrGameObject);
    static public bool IsPartOfPrefabThatCanBeAppliedTo(Object gameObjectOrComponent);
    static public bool IsPartOfRegularPrefab(Object componentOrGameObject);
    static public bool IsPartOfVariantPrefab(Object componentOrGameObject);
    static public bool IsPrefabAssetMissing(Object instanceComponentOrGameObject);
    static public GameObject LoadPrefabContents(string assetPath);
    static public void LoadPrefabContentsIntoPreviewScene(string prefabPath, SceneManagement.Scene scene);
    static public void MergeAllPrefabInstances(Object targetObject);
    static public bool ReconnectToLastPrefab(GameObject go);
    static public void RecordPrefabInstancePropertyModifications(Object targetObject);
    static public GameObject ReplacePrefab(GameObject go, Object targetPrefab);
    static public GameObject ReplacePrefab(GameObject go, Object targetPrefab, UnityEditor.ReplacePrefabOptions replaceOptions);
    static public bool ResetToPrefabState(Object obj);
    static public void RevertAddedComponent(Component component, UnityEditor.InteractionMode action);
    static public void RevertAddedGameObject(GameObject gameObject, UnityEditor.InteractionMode action);
    static public void RevertObjectOverride(Object instanceComponentOrGameObject, UnityEditor.InteractionMode action);
    static public bool RevertPrefabInstance(GameObject go);
    static public void RevertPrefabInstance(GameObject instanceRoot, UnityEditor.InteractionMode action);
    static public void RevertPropertyOverride(UnityEditor.SerializedProperty instanceProperty, UnityEditor.InteractionMode action);
    static public void RevertRemovedComponent(GameObject instanceGameObject, Component assetComponent, UnityEditor.InteractionMode action);
    static public GameObject SaveAsPrefabAsset(GameObject instanceRoot, string assetPath, out bool success);
    static public GameObject SaveAsPrefabAsset(GameObject instanceRoot, string assetPath);
    static public GameObject SaveAsPrefabAssetAndConnect(GameObject instanceRoot, string assetPath, UnityEditor.InteractionMode action);
    static public GameObject SaveAsPrefabAssetAndConnect(GameObject instanceRoot, string assetPath, UnityEditor.InteractionMode action, out bool success);
    static public GameObject SavePrefabAsset(GameObject asset);
    static public GameObject SavePrefabAsset(GameObject asset, out bool savedSuccessfully);
    static public void SetPropertyModifications(Object targetPrefab, UnityEditor.PropertyModification[] modifications);
    static public void UnloadPrefabContents(GameObject contentsRoot);
    static public void UnpackPrefabInstance(GameObject instanceRoot, UnityEditor.PrefabUnpackMode unpackMode, UnityEditor.InteractionMode action);
    static public GameObject[] UnpackPrefabInstanceAndReturnNewOutermostRoots(GameObject instanceRoot, UnityEditor.PrefabUnpackMode unpackMode);

    public PrefabUtility();

    public delegate void PrefabInstanceUpdated(GameObject instance);

}

}
