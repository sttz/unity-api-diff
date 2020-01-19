using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class AchievementDescription : SocialPlatforms.IAchievementDescription
{
    public string achievedDescription { get; }
    public bool hidden { get; }
    public string id { get; set; }
    public Texture2D image { get; }
    public int points { get; }
    public string title { get; }
    public string unachievedDescription { get; }

    public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points);

    public void SetImage(Texture2D image);
    public string ToString();

}

}
