using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs
{

public static class IJobExtensions
{
    static public void Run<T>(T jobData);
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, Unity.Jobs.JobHandle dependsOn = null);

}

}
