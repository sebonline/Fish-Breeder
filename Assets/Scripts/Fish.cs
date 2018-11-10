using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Fish", menuName = "Fish")]
public class Fish : ScriptableObject {

    public new string name;
    public string description;
    public float avgAge;
    public float maxAge;
    public Sprite artwork;
    
    
    public float avgSize;
    public float maxSize;
    public float minWaterVolume;
    public FishGenus Genus;
    public FishSpecies Species;
    
    public WaterRegion waterRegion;
    public Difficulty difficulty;
    public Action[] actions;
    

    //Water Parameters
    public float minPH;
    public float maxPH;
    public float minTemp;
    public float maxTemp;
    public WaterType waterType;

    //Feeding Parameters
    public Food[] food;
    public float feedInterval;


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

    public enum Food
    {
        none,
        DryFood,
        Shrimps,
        Fish,
        Alge
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
