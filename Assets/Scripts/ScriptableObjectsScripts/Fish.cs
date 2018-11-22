using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Fish", menuName = "Fish")]
public class Fish : ScriptableObject {
    [Header("Basic Fish Information")]
    public new string name;
    public string description;
    public FishGenus Genus;
    public FishSpecies Species;
    public Difficulty difficulty;
    public float avgAge;
    public float maxAge;
    public Sprite artwork;

    [Header("Aquarium Parameters")]
    public float avgSize;
    public float maxSize;
    public WaterRegion waterRegion;
    public float minWaterVolume;

    [Header("Water Parameters")]
    public float minPH;
    public float maxPH;
    public float minTemp;
    public float maxTemp;
    public WaterType waterType;

    [Header("Feeding Parameters")]
    public FishFood[] food;
    public float feedInterval;

    [Header("AI Behaviour")]
    public Action[] actions;

    //Enums
    public enum FishGenus
    {
        none,
        Goldfish,
        Cichlid,
        Catfish,
        Tetra,
        Barb,
        Loach,
        Clownfish,
        Damsel,
        Chromis,
        Tang,
        Mandarinfish,
        Gobie
    }
    public enum FishSpecies
    {
        none,
        Mbuna,
        Neon,
    }

    public enum WaterType
    {
        none,
        Freshwater,
        Saltwater,
        Brackish
    }

    public enum WaterRegion
    {
        none,
        Top,
        Middle,
        Buttom,
        All
    }

    public enum Difficulty
    {
        none,
        Easy,
        Medium,
        Hard,
        Expert
    }

    

    public enum WaterCurrent
    {
        none,
        Weak,
        Medium,
        Strong
    }

    public enum Lighting
    {
        none,
        Little,
        Medium,
        Strong
    }
    
}
