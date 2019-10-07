using System;
using UnityEngine;

namespace Unity.Jobs
{

public static class IJobExtensions
{
    static public void Run(T jobData);
    static public Unity.Jobs.JobHandle Schedule(T jobData, Unity.Jobs.JobHandle dependsOn = null);

}

}
