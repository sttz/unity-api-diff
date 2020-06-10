using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class GameObjectUtility
{
    static public bool AreStaticEditorFlagsSet(GameObject go, UnityEditor.StaticEditorFlags flags);
    static public void EnsureUniqueNameForSibling(GameObject self);
    static public int GetMonoBehavioursWithMissingScriptCount(GameObject go);
    static public int GetNavMeshArea(GameObject go);
    static public int GetNavMeshAreaFromName(string name);
    static public string[] GetNavMeshAreaNames();
    static public int GetNavMeshLayer(GameObject go);
    static public int GetNavMeshLayerFromName(string name);
    static public string[] GetNavMeshLayerNames();
    static public UnityEditor.StaticEditorFlags GetStaticEditorFlags(GameObject go);
    static public string GetUniqueNameForSibling(Transform parent, string name);
    static public ulong ModifyMaskIfGameObjectIsHiddenForPrefabModeInContext(ulong sceneCullingMask, GameObject gameObject);
    static public int RemoveMonoBehavioursWithMissingScript(GameObject go);
    static public void SetNavMeshArea(GameObject go, int areaIndex);
    static public void SetNavMeshLayer(GameObject go, int areaIndex);
    static public void SetParentAndAlign(GameObject child, GameObject parent);
    static public void SetStaticEditorFlags(GameObject go, UnityEditor.StaticEditorFlags flags);

    public GameObjectUtility();

}

}
