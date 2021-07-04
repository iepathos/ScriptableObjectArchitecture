using System;
using UnityEngine;

[CreateAssetMenu]
public class DoubleVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public double InitialValue;

    [NonSerialized]
    public double RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}