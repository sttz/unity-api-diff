using System;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class Provider
{
    static public UnityEditor.VersionControl.Task activeTask { get; }
    static public bool enabled { get; }
    static public bool hasChangelistSupport { get; }
    static public bool hasCheckoutSupport { get; }
    static public bool isActive { get; }
    static public bool isVersioningFolders { get; }
    static public string offlineReason { get; }
    static public UnityEditor.VersionControl.OnlineState onlineState { get; }
    static public bool requiresNetwork { get; }

    static public UnityEditor.VersionControl.Task Add(UnityEditor.VersionControl.AssetList assets, bool recursive);
    static public UnityEditor.VersionControl.Task Add(UnityEditor.VersionControl.Asset asset, bool recursive);
    static public bool AddIsValid(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.Task ChangeSetDescription(UnityEditor.VersionControl.ChangeSet changeset);
    static public UnityEditor.VersionControl.Task ChangeSetMove(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.ChangeSet changeset);
    static public UnityEditor.VersionControl.Task ChangeSetMove(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.ChangeSet changeset);
    static public UnityEditor.VersionControl.Task ChangeSetMove(UnityEditor.VersionControl.AssetList assets, string changesetID);
    static public UnityEditor.VersionControl.Task ChangeSetMove(UnityEditor.VersionControl.Asset asset, string changesetID);
    static public UnityEditor.VersionControl.Task ChangeSets();
    static public UnityEditor.VersionControl.Task ChangeSetStatus(UnityEditor.VersionControl.ChangeSet changeset);
    static public UnityEditor.VersionControl.Task ChangeSetStatus(string changesetID);
    static public UnityEditor.VersionControl.Task Checkout(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.CheckoutMode mode);
    static public UnityEditor.VersionControl.Task Checkout(string[] assets, UnityEditor.VersionControl.CheckoutMode mode);
    static public UnityEditor.VersionControl.Task Checkout(Object[] assets, UnityEditor.VersionControl.CheckoutMode mode);
    static public UnityEditor.VersionControl.Task Checkout(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.CheckoutMode mode);
    static public UnityEditor.VersionControl.Task Checkout(string asset, UnityEditor.VersionControl.CheckoutMode mode);
    static public UnityEditor.VersionControl.Task Checkout(Object asset, UnityEditor.VersionControl.CheckoutMode mode);
    static public bool CheckoutIsValid(UnityEditor.VersionControl.AssetList assets);
    static public bool CheckoutIsValid(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.CheckoutMode mode);
    static public bool CheckoutIsValid(UnityEditor.VersionControl.Asset asset);
    static public bool CheckoutIsValid(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.CheckoutMode mode);
    static public void ClearCache();
    static public UnityEditor.VersionControl.Task Delete(string assetProjectPath);
    static public UnityEditor.VersionControl.Task Delete(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.Task Delete(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task DeleteChangeSets(UnityEditor.VersionControl.ChangeSets changesets);
    static public bool DeleteChangeSetsIsValid(UnityEditor.VersionControl.ChangeSets changesets);
    static public UnityEditor.VersionControl.Task DiffHead(UnityEditor.VersionControl.AssetList assets, bool includingMetaFiles);
    static public bool DiffIsValid(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.ConfigField[] GetActiveConfigFields();
    static public UnityEditor.VersionControl.Plugin GetActivePlugin();
    static public UnityEditor.VersionControl.Asset GetAssetByGUID(string guid);
    static public UnityEditor.VersionControl.Asset GetAssetByPath(string unityPath);
    static public UnityEditor.VersionControl.AssetList GetAssetListFromSelection();
    static public UnityEditor.VersionControl.Task GetLatest(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.Task GetLatest(UnityEditor.VersionControl.Asset asset);
    static public bool GetLatestIsValid(UnityEditor.VersionControl.AssetList assets);
    static public bool GetLatestIsValid(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task Incoming();
    static public UnityEditor.VersionControl.Task IncomingChangeSetAssets(UnityEditor.VersionControl.ChangeSet changeset);
    static public UnityEditor.VersionControl.Task IncomingChangeSetAssets(string changesetID);
    static public bool IsOpenForEdit(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task Lock(UnityEditor.VersionControl.AssetList assets, bool locked);
    static public UnityEditor.VersionControl.Task Lock(UnityEditor.VersionControl.Asset asset, bool locked);
    static public bool LockIsValid(UnityEditor.VersionControl.AssetList assets);
    static public bool LockIsValid(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task Merge(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.MergeMethod method);
    static public UnityEditor.VersionControl.Task Move(string from, string to);
    static public UnityEditor.VersionControl.Task Resolve(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.ResolveMethod resolveMethod);
    static public bool ResolveIsValid(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.Task Revert(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.RevertMode mode);
    static public UnityEditor.VersionControl.Task Revert(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.RevertMode mode);
    static public bool RevertIsValid(UnityEditor.VersionControl.AssetList assets, UnityEditor.VersionControl.RevertMode mode);
    static public bool RevertIsValid(UnityEditor.VersionControl.Asset asset, UnityEditor.VersionControl.RevertMode mode);
    static public UnityEditor.VersionControl.Task Status(UnityEditor.VersionControl.AssetList assets);
    static public UnityEditor.VersionControl.Task Status(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task Status(UnityEditor.VersionControl.AssetList assets, bool recursively);
    static public UnityEditor.VersionControl.Task Status(UnityEditor.VersionControl.Asset asset, bool recursively);
    static public UnityEditor.VersionControl.Task Status(string[] assets);
    static public UnityEditor.VersionControl.Task Status(string[] assets, bool recursively);
    static public UnityEditor.VersionControl.Task Status(string asset);
    static public UnityEditor.VersionControl.Task Status(string asset, bool recursively);
    static public UnityEditor.VersionControl.Task Submit(UnityEditor.VersionControl.ChangeSet changeset, UnityEditor.VersionControl.AssetList list, string description, bool saveOnly);
    static public bool SubmitIsValid(UnityEditor.VersionControl.ChangeSet changeset, UnityEditor.VersionControl.AssetList assets);
    static public bool UnlockIsValid(UnityEditor.VersionControl.AssetList assets);
    static public bool UnlockIsValid(UnityEditor.VersionControl.Asset asset);
    static public UnityEditor.VersionControl.Task UpdateSettings();

    public Provider();

}

}
