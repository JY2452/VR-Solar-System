using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Global Settings")]
public class GlobalSettings : ScriptableObject
{
    [SerializeField]
    public double scale;
    public Body[] bodies;
}
