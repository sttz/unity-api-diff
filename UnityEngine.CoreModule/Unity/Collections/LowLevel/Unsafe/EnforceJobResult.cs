using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public enum EnforceJobResult
{
    AllJobsAlreadySynced = 0,
    DidSyncRunningJobs = 1,
    HandleWasAlreadyDeallocated = 2,
}

}
