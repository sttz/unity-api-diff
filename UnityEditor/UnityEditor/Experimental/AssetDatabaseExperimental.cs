using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public sealed class AssetDatabaseExperimental
{
    static public AssetDatabaseCounters counters { get; }

    static public Hash128 GetArtifactHash(string guid);
    static public Hash128 GetArtifactHash(string guid, Type importerType);
    static public Hash128 GetArtifactHash(Hash128 hash, Type importerType);
    static public bool GetArtifactPaths(Hash128 hash, out string paths);

    public AssetDatabaseExperimental();

    public struct AssetDatabaseCounters
    {
        public CacheServerCounters cacheServer;
        public ImportCounters import;

        public void ResetDeltas();

        public struct CacheServerCounters
        {
            public Counter artifactFilesDownloaded;
            public Counter artifactFilesUploaded;
            public Counter artifactsDownloaded;
            public Counter artifactsInResolveReplies;
            public Counter artifactsMatchedResolveVersion;
            public Counter artifactsRequestedResolved;
            public Counter artifactsUploaded;
            public Counter artifactVersionsInResolveReplies;
            public Counter connects;
            public Counter disconnects;
            public Counter reliabilityCheckReportedArtifactVersionMatched;
            public Counter reliabilityCheckReportedIndeterminism;
            public Counter reliabilityCheckReportedNewArtifactVersion;
            public Counter reliabilityChecks;
            public Counter resolveReplies;
            public Counter resolveRequests;

        }

        public struct Counter
        {
            public int delta;
            public int total;

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

}

}
