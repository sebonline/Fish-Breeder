using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Fish Food")]
public class FishFood : ScriptableObject
{
    [Header("Basic Fish Food Information")]
    public new string name;
    public string description;
    public Sprite artwork;

    public float energy;
    public bool isSinking;


}