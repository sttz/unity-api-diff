using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface IAchievementDescription
{
    public string achievedDescription { get; }
    public bool hidden { get; }
    public string id { get; set; }
    public Texture2D image { get; }
    public int points { get; }
    public string title { get; }
    public string unachievedDescription { get; }

}

}
