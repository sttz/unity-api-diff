using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface ILocalUser : SocialPlatforms.IUserProfile
{
    public bool authenticated { get; }
    public SocialPlatforms.IUserProfile[] friends { get; }
    public bool underage { get; }

    public void Authenticate(Action<bool> callback);
    public void Authenticate(Action<bool, string> callback);
    public void LoadFriends(Action<bool> callback);

}

}
