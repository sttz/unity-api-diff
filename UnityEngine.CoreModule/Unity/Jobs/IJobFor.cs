using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs
{

public interface IJobFor
{
    public void Execute(int index);

}

}
