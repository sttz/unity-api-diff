using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Caching
{
    static public int cacheCount { get; }
    static public bool compressionEnabled { get; set; }
    static public Cache currentCacheForWriting { get; set; }
    static public Cache defaultCache { get; }
    static public int expirationDelay { get; set; }
    static public long maximumAvailableDiskSpace { get; set; }
    static public bool ready { get; }
    static public int spaceAvailable { get; }
    static public long spaceFree { get; }
    static public long spaceOccupied { get; }
    static public int spaceUsed { get; }

    static public Cache AddCache(string cachePath);
    static public bool CleanCache();
    static public bool ClearAllCachedVersions(string assetBundleName);
    static public bool ClearCache();
    static public bool ClearCache(int expiration);
    static public bool ClearCachedVersion(string assetBundleName, Hash128 hash);
    static public bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash);
    static public void GetAllCachePaths(System.Collections.Generic.List<string> cachePaths);
    static public Cache GetCacheAt(int cacheIndex);
    static public Cache GetCacheByPath(string cachePath);
    static public void GetCachedVersions(string assetBundleName, System.Collections.Generic.List<Hash128> outCachedVersions);
    static public int GetVersionFromCache(string url);
    static public bool IsVersionCached(string url, int version);
    static public bool IsVersionCached(string url, Hash128 hash);
    static public bool IsVersionCached(CachedAssetBundle cachedBundle);
    static public bool MarkAsUsed(string url, int version);
    static public bool MarkAsUsed(string url, Hash128 hash);
    static public bool MarkAsUsed(CachedAssetBundle cachedBundle);
    static public void MoveCacheAfter(Cache src, Cache dst);
    static public void MoveCacheBefore(Cache src, Cache dst);
    static public bool RemoveCache(Cache cache);
    static public void ResetNoBackupFlag(string url, int version);
    static public void ResetNoBackupFlag(string url, Hash128 hash);
    static public void ResetNoBackupFlag(CachedAssetBundle cachedBundle);
    static public void SetNoBackupFlag(string url, int version);
    static public void SetNoBackupFlag(string url, Hash128 hash);
    static public void SetNoBackupFlag(CachedAssetBundle cachedBundle);

    public Caching();

}

}
