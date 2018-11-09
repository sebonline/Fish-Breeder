using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Fish", menuName = "Fish")]
public class Fish : ScriptableObject {

    public new string name;
    public string description;
    public int avgAge;
    public int maxAge;
    public Sprite artwork;
    public float minPH;
    public float maxPH;
    public float minTemp;
    public float maxTemp;
    public float avgSize;
    public float maxSize;
    public FishType fishType;
    public WaterType waterType;
    public WaterRegion waterRegion;
    public Difficulty difficulty;
    
    

    public enum FishType
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

    public enum WaterType
    {
        none,
        Freshwater,
        Saltwater
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
    
}
