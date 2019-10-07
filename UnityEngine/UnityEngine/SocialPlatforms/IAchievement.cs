using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface IAchievement
{
    public bool completed { get; }
    public bool hidden { get; }
    public string id { get; set; }
    public DateTime lastReportedDate { get; }
    public double percentCompleted { get; set; }

    public void ReportProgress(Action<bool> callback);

}

}
