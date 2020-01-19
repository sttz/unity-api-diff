using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public class EditorResources
{
    static public string brushesPath { get; }
    static public int darkSkinIndex { get; }
    static public string darkSkinSourcePath { get; }
    static public string dataPath { get; }
    static public string editorDefaultResourcesPath { get; }
    static public string emptyFolderIconName { get; }
    static public string folderIconName { get; }
    static public string fontsPath { get; }
    static public string generatedIconsPath { get; }
    static public string iconsPath { get; }
    static public string libraryBundlePath { get; }
    static public string lightSkinSourcePath { get; }
    static public int normalSkinIndex { get; }

    static public bool Exists(string path);
    static public string ExpandPath(string path);
    static public string GetAssetPath(Object obj);
    static public string GetFullPath(string path);
    static public Object Load(string assetPath, Type type);
    static public T Load<T>(string assetPath, bool isRequired = true);

    public EditorResources();

}

}
