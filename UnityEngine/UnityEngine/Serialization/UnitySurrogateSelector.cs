using System;
using UnityEngine;

namespace UnityEngine.Serialization
{

public class UnitySurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
{
    public UnitySurrogateSelector();

    public void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector);
    public System.Runtime.Serialization.ISurrogateSelector GetNextSelector();
    public System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector selector);

}

}
