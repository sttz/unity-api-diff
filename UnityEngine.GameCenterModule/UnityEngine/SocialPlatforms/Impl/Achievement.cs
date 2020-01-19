using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class Achievement : SocialPlatforms.IAchievement
{
    public bool completed { get; }
    public bool hidden { get; }
    public string id { get; set; }
    public DateTime lastReportedDate { get; }
    public double percentCompleted { get; set; }

    public Achievement();
    public Achievement(string id, double percent);
    public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate);

    public void ReportProgress(Action<bool> callback);
    public void SetCompleted(bool value);
    public void SetHidden(bool value);
    public void SetLastReportedDate(DateTime date);
    public string ToString();

}

}
