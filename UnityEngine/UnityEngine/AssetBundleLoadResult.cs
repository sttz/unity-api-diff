using System;
using UnityEngine;

namespace UnityEngine
{

public enum AssetBundleLoadResult
{
    Success = 0,
    Cancelled = 1,
    NotMatchingCrc = 2,
    FailedCache = 3,
    NotValidAssetBundle = 4,
    NoSerializedData = 5,
    NotCompatible = 6,
    AlreadyLoaded = 7,
    FailedRead = 8,
    FailedDecompression = 9,
    FailedWrite = 10,
    FailedDeleteRecompressionTarget = 11,
    RecompressionTargetIsLoaded = 12,
    RecompressionTargetExistsButNotArchive = 13,
}

}
