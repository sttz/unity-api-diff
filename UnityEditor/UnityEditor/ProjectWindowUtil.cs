using System;
using UnityEngine;

namespace UnityEditor
{

public class ProjectWindowUtil
{
    static public void CreateAsset(Object asset, string pathName);
    static public void CreateAssetWithContent(string filename, string content, Texture2D icon = null);
    static public void CreateFolder();
    static public void CreateNewGUISkin();
    static public void CreateScene();
    static public int[] GetAncestors(int instanceID);
    static public string[] GetBaseFolders(string[] folders);
    static public string GetContainingFolder(string path);
    static public bool IsFolder(int instanceID);
    static public void ShowCreatedAsset(Object o);
    static public void StartNameEditingIfProjectWindowExists(int instanceID, UnityEditor.ProjectWindowCallback.EndNameEditAction endAction, string pathName, Texture2D icon, string resourceFile);

    public ProjectWindowUtil();

}

}
