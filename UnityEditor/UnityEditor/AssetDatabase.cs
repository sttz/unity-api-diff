using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class AssetDatabase
{
    static public event ImportPackageCallback importPackageCancelled;
    static public event ImportPackageCallback importPackageCompleted;
    static public event ImportPackageFailedCallback importPackageFailed;
    static public event ImportPackageCallback importPackageStarted;

    static public void AddObjectToAsset(Object objectToAdd, string path);
    static public void AddObjectToAsset(Object objectToAdd, Object assetObject);
    static public string AssetPathToGUID(string path);
    static public void ClearLabels(Object obj);
    static public bool Contains(Object obj);
    static public bool Contains(int instanceID);
    static public bool CopyAsset(string path, string newPath);
    static public void CreateAsset(Object asset, string path);
    static public string CreateFolder(string parentFolder, string newFolderName);
    static public bool DeleteAsset(string path);
    static public void ExportPackage(string assetPathName, string fileName);
    static public void ExportPackage(string assetPathName, string fileName, UnityEditor.ExportPackageOptions flags);
    static public void ExportPackage(string[] assetPathNames, string fileName, UnityEditor.ExportPackageOptions flags);
    static public void ExportPackage(string[] assetPathNames, string fileName);
    static public string ExtractAsset(Object asset, string newPath);
    static public string[] FindAssets(string filter);
    static public string[] FindAssets(string filter, string[] searchInFolders);
    static public void ForceReserializeAssets(System.Collections.Generic.IEnumerable<string> assetPaths, UnityEditor.ForceReserializeAssetsOptions options = 3);
    static public void ForceReserializeAssets();
    static public string GenerateUniqueAssetPath(string path);
    static public string[] GetAllAssetBundleNames();
    static public string[] GetAllAssetPaths();
    static public string[] GetAssetBundleDependencies(string assetBundleName, bool recursive);
    static public Hash128 GetAssetDependencyHash(string path);
    static public string GetAssetOrScenePath(Object assetObject);
    static public string GetAssetPath(Object assetObject);
    static public string GetAssetPath(int instanceID);
    static public string GetAssetPathFromTextMetaFilePath(string path);
    static public string[] GetAssetPathsFromAssetBundle(string assetBundleName);
    static public string[] GetAssetPathsFromAssetBundleAndAssetName(string assetBundleName, string assetName);
    static public Object GetBuiltinExtraResource(Type type, string path);
    static public T GetBuiltinExtraResource(string path);
    static public Texture GetCachedIcon(string path);
    static public string GetCurrentCacheServerIp();
    static public string[] GetDependencies(string pathName);
    static public string[] GetDependencies(string pathName, bool recursive);
    static public string[] GetDependencies(string[] pathNames);
    static public string[] GetDependencies(string[] pathNames, bool recursive);
    static public string GetImplicitAssetBundleName(string assetPath);
    static public string GetImplicitAssetBundleVariantName(string assetPath);
    static public string[] GetLabels(Object obj);
    static public Type GetMainAssetTypeAtPath(string assetPath);
    static public string[] GetSubFolders(string path);
    static public string GetTextMetaDataPathFromAssetPath(string path);
    static public string GetTextMetaFilePathFromAssetPath(string path);
    static public string[] GetUnusedAssetBundleNames();
    static public string GUIDToAssetPath(string guid);
    static public void ImportAsset(string path, UnityEditor.ImportAssetOptions options);
    static public void ImportAsset(string path);
    static public void ImportPackage(string packagePath, bool interactive);
    static public bool IsForeignAsset(Object obj);
    static public bool IsForeignAsset(int instanceID);
    static public bool IsMainAsset(Object obj);
    static public bool IsMainAsset(int instanceID);
    static public bool IsMainAssetAtPathLoaded(string assetPath);
    static public bool IsMetaFileOpenForEdit(Object assetObject);
    static public bool IsMetaFileOpenForEdit(Object assetObject, UnityEditor.StatusQueryOptions statusOptions);
    static public bool IsMetaFileOpenForEdit(Object assetObject, out string message);
    static public bool IsMetaFileOpenForEdit(Object assetObject, out string message, UnityEditor.StatusQueryOptions statusOptions);
    static public bool IsNativeAsset(Object obj);
    static public bool IsNativeAsset(int instanceID);
    static public bool IsOpenForEdit(Object assetObject);
    static public bool IsOpenForEdit(Object assetObject, UnityEditor.StatusQueryOptions StatusQueryOptions);
    static public bool IsOpenForEdit(string assetOrMetaFilePath);
    static public bool IsOpenForEdit(string assetOrMetaFilePath, UnityEditor.StatusQueryOptions StatusQueryOptions);
    static public bool IsOpenForEdit(Object assetObject, out string message);
    static public bool IsOpenForEdit(Object assetObject, out string message, UnityEditor.StatusQueryOptions statusOptions);
    static public bool IsOpenForEdit(string assetOrMetaFilePath, out string message);
    static public bool IsOpenForEdit(string assetOrMetaFilePath, out string message, UnityEditor.StatusQueryOptions statusOptions);
    static public bool IsSubAsset(Object obj);
    static public bool IsSubAsset(int instanceID);
    static public bool IsValidFolder(string path);
    static public Object[] LoadAllAssetRepresentationsAtPath(string assetPath);
    static public Object[] LoadAllAssetsAtPath(string assetPath);
    static public Object LoadAssetAtPath(string assetPath, Type type);
    static public T LoadAssetAtPath(string assetPath);
    static public Object LoadMainAssetAtPath(string assetPath);
    static public string MoveAsset(string oldPath, string newPath);
    static public bool MoveAssetToTrash(string path);
    static public bool OpenAsset(int instanceID);
    static public bool OpenAsset(int instanceID, int lineNumber);
    static public bool OpenAsset(int instanceID, int lineNumber, int columnNumber);
    static public bool OpenAsset(Object target);
    static public bool OpenAsset(Object target, int lineNumber);
    static public bool OpenAsset(Object target, int lineNumber, int columnNumber);
    static public bool OpenAsset(Object[] objects);
    static public void Refresh(UnityEditor.ImportAssetOptions options);
    static public void Refresh();
    static public void RefreshDelayed(UnityEditor.ImportAssetOptions options);
    static public void RefreshDelayed();
    static public void ReleaseCachedFileHandles();
    static public bool RemoveAssetBundleName(string assetBundleName, bool forceRemove);
    static public void RemoveObjectFromAsset(Object objectToRemove);
    static public void RemoveUnusedAssetBundleNames();
    static public string RenameAsset(string pathName, string newName);
    static public void SaveAssets();
    static public void SetLabels(Object obj, string[] labels);
    static public void SetMainObject(Object mainObject, string assetPath);
    static public void StartAssetEditing();
    static public void StopAssetEditing();
    static public bool TryGetGUIDAndLocalFileIdentifier(Object obj, out string guid, out int localId);
    static public bool TryGetGUIDAndLocalFileIdentifier(int instanceID, out string guid, out int localId);
    static public bool TryGetGUIDAndLocalFileIdentifier(Object obj, out string guid, out long localId);
    static public bool TryGetGUIDAndLocalFileIdentifier(int instanceID, out string guid, out long localId);
    static public string ValidateMoveAsset(string oldPath, string newPath);
    static public bool WriteImportSettingsIfDirty(string path);

    public AssetDatabase();

    public string[] GetAssetBundleNames();

    public delegate void ImportPackageCallback(string packageName);

    public delegate void ImportPackageFailedCallback(string packageName, string errorMessage);

}

}
