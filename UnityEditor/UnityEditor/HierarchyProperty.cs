using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class HierarchyProperty : UnityEditor.IHierarchyProperty
{
    static public void ClearSceneObjectsFilter();
    static public void FilterSingleSceneObject(int instanceID, bool otherVisibilityState);

    public bool alphaSorted { get; set; }
    public int[] ancestors { get; }
    public int colorCode { get; }
    public int depth { get; }
    public UnityEditor.GUID[] dynamicDependencies { get; }
    public string guid { get; }
    public bool hasChildren { get; }
    public bool hasFullPreviewImage { get; }
    public Texture2D icon { get; }
    public UnityEditor.IconDrawStyle iconDrawStyle { get; }
    public int instanceID { get; }
    public bool isFolder { get; }
    public bool isMainRepresentation { get; }
    public bool isValid { get; }
    public string name { get; }
    public Object pptrValue { get; }
    public int row { get; }
    public bool showSceneHeaders { get; set; }

    public HierarchyProperty(UnityEditor.HierarchyType hierarchyType);
    public HierarchyProperty(UnityEditor.HierarchyType hierarchyType, bool forceImport);
    public HierarchyProperty(string rootPath);
    public HierarchyProperty(string rootPath, bool forceImport);
    public HierarchyProperty(UnityEditor.HierarchyType hierarchyType, string rootPath, bool forceImport);

    public int CountRemaining(int[] expanded);
    public bool Find(int instanceID, int[] expanded);
    public int[] FindAllAncestors(int[] instanceIDs);
    public int GetInstanceIDIfImported();
    public SceneManagement.Scene GetScene();
    public bool IsExpanded(int[] expanded);
    public bool Next(int[] expanded);
    public bool NextWithDepthCheck(int[] expanded, int minDepth);
    public bool Parent();
    public bool Previous(int[] expanded);
    public void Reset();
    public void SetCustomScenes(int[] sceneHandles);
    public void SetSearchFilter(string searchString, int mode);
    public void SetSubScenes(SubSceneInfo[] subScenes);
    public bool Skip(int count, int[] expanded);

}

}
