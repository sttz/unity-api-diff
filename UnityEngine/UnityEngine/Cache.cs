using System;
using UnityEngine;

namespace UnityEngine
{

public struct Cache : IEquatable<Cache>
{
    public int expirationDelay { get; set; }
    public int index { get; }
    public long maximumAvailableStorageSpace { get; set; }
    public string path { get; }
    public bool readOnly { get; }
    public bool ready { get; }
    public long spaceFree { get; }
    public long spaceOccupied { get; }
    public bool valid { get; }

    public bool ClearCache();
    public bool ClearCache(int expiration);
    public bool Equals(object other);
    public bool Equals(Cache other);
    public int GetHashCode();

}

}
