using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms.Impl
{

public class LocalUser : SocialPlatforms.Impl.UserProfile, SocialPlatforms.ILocalUser, SocialPlatforms.IUserProfile
{
    public bool authenticated { get; }
    public SocialPlatforms.IUserProfile[] friends { get; }
    public bool underage { get; }

    public LocalUser();

    public void Authenticate(Action<bool> callback);
    public void Authenticate(Action<bool, string> callback);
    public void LoadFriends(Action<bool> callback);
    public void SetAuthenticated(bool value);
    public void SetFriends(SocialPlatforms.IUserProfile[] friends);
    public void SetUnderage(bool value);

}

}
