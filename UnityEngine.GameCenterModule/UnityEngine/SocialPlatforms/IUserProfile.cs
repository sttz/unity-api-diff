using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface IUserProfile
{
    public string id { get; }
    public Texture2D image { get; }
    public bool isFriend { get; }
    public SocialPlatforms.UserState state { get; }
    public string userName { get; }

}

}
