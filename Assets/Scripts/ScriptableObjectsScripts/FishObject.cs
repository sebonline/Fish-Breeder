using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Fish", menuName = "Fish")]
public class FishObject : ScriptableObject
{
    [Header("Basic Fish Information")]
    public new string name;
    public string description;
    public Enums.FishGenus genus;
    public Enums.FishSpecies species;
    public Enums.Difficulty difficulty;
    public float avgAge;
    public float maxAge;
    public Sprite artwork;

    [Header("Aquarium Parameters")]
    public float avgSize;
    public float maxSize;
    public Enums.WaterRegion waterRegion;
    public float minWaterVolume;

    [Header("Water Parameters")]
    public float minPH;
    public float maxPH;
    public float minTemp;
    public float maxTemp;
    public Enums.WaterType waterType;

    [Header("Feeding Parameters")]
    public FishFood[] food;
    public float feedInterval;

    [Header("AI Behaviour")]
    public Action[] actions;

}
   