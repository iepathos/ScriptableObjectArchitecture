using System;
using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public int InitialValue;

    [NonSerialized]
    public int RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}