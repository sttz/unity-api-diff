using System;
using UnityEngine;

namespace UnityEngine.SocialPlatforms
{

public interface IUserProfile
{
    public string gameId { get; }
    public string id { get; }
    public Texture2D image { get; }
    public bool isFriend { get; }
    public SocialPlatforms.UserState state { get; }
    public string userName { get; }

}

}
