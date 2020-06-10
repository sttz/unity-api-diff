using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public sealed class AssetDatabaseExperimental
{
    static public OnDemandMode ActiveOnDemandMode { get; set; }
    static public AssetDatabaseCounters counters { get; }

    static public event Action<CacheServerConnectionChangedParameters> cacheServerConnectionChanged;

    static public bool CanConnectToCacheServer(string ip, ushort port);
    static public void ClearImporterOverride(string path);
    static public UnityEditor.Experimental.ArtifactID ForceProduceArtifact(UnityEditor.Experimental.ArtifactKey artifactKey);
    static public Hash128 GetArtifactHash(string guid, ImportSyncMode mode = 0);
    static public Hash128 GetArtifactHash(string guid, Type importerType, ImportSyncMode mode = 0);
    static public Hash128[] GetArtifactHashes(string[] guids, ImportSyncMode mode = 0);
    static public bool GetArtifactPaths(UnityEditor.Experimental.ArtifactID hash, out string paths);
    static public bool GetArtifactPaths(Hash128 hash, out string paths);
    static public Type[] GetAvailableImporterTypes(string path);
    static public string GetCacheServerAddress();
    static public bool GetCacheServerEnableDownload();
    static public bool GetCacheServerEnableUpload();
    static public string GetCacheServerNamespacePrefix();
    static public ushort GetCacheServerPort();
    static public Type GetImporterOverride(string path);
    static public UnityEditor.Experimental.OnDemandProgress GetOnDemandArtifactProgress(UnityEditor.Experimental.ArtifactKey artifactKey);
    static public UnityEditor.Experimental.OnDemandProgress GetOnDemandArtifactProgress(string guid);
    static public UnityEditor.Experimental.OnDemandProgress GetOnDemandArtifactProgress(string guid, Type importerType);
    static public bool IsAssetImportWorkerProcess();
    static public bool IsCacheServerEnabled();
    static public bool IsConnectedToCacheServer();
    static public bool IsDirectoryMonitoringEnabled();
    static public UnityEditor.Experimental.ArtifactID LookupArtifact(UnityEditor.Experimental.ArtifactKey artifactKey);
    static public UnityEditor.Experimental.ArtifactID ProduceArtifact(UnityEditor.Experimental.ArtifactKey artifactKey);
    static public UnityEditor.Experimental.ArtifactID ProduceArtifactAsync(UnityEditor.Experimental.ArtifactKey artifactKey);
    static public UnityEditor.Experimental.ArtifactID[] ProduceArtifactsAsync(UnityEditor.GUID[] artifactKey, Type importerType = null);
    static public void ReconnectToCacheServer();
    static public void RefreshSettings();
    static public void RegisterCustomDependency(string dependency, Hash128 hashOfValue);
    static public void SetImporterOverride<T>(string path);
    static public uint UnregisterCustomDependencyPrefixFilter(string prefixFilter);

    public AssetDatabaseExperimental();

    public struct AssetDatabaseCounters
    {
        public CacheServerCounters cacheServer;
        public ImportCounters import;

        public void ResetDeltas();

        public struct CacheServerCounters
        {
            public Counter artifactFilesDownloaded;
            public Counter artifactFilesFailedToDownload;
            public Counter artifactFilesFailedToUpload;
            public Counter artifactFilesUploaded;
            public Counter artifactsDownloaded;
            public Counter artifactsUploaded;
            public Counter connects;
            public Counter disconnects;
            public Counter metadataDownloaded;
            public Counter metadataFailedToDownload;
            public Counter metadataFailedToUpload;
            public Counter metadataMatched;
            public Counter metadataRequested;
            public Counter metadataUploaded;
            public Counter metadataVersionsDownloaded;

        }

        public struct Counter
        {
            public long delta;
            public long total;

        }

        public struct ImportCounters
        {
            public Counter domainReload;
            public Counter imported;
            public Counter importedInProcess;
            public Counter importedOutOfProcess;
            public Counter refresh;

        }

    }

    public struct CacheServerConnectionChangedParameters
    {
    }

    public enum ImportSyncMode
    {
        Block = 0,
        Queue = 1,
        Poll = 2,
    }

    public enum OnDemandMode
    {
        Off = 0,
        Lazy = 1,
        Background = 2,
    }

}

}
