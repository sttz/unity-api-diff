using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class UsedImplicitlyAttribute : Attribute
{
    public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
    public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }

    public UsedImplicitlyAttribute();
    public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
    public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags);
    public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);

}

}
