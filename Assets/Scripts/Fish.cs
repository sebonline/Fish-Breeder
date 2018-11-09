using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Fish", menuName = "Fish")]
public class Fish : ScriptableObject {

    public new string name;
    public string description;
    public float price;
    public int maxAge;
    public float currentAge;
    public Sprite artwork;
    public float minPH;
    public float maxPH;
    public float minTemp;
    public float maxTemp;
    public float maxSize;
    
    

    enum FishType
    {
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

    enum WaterType
    {
        Freshwater,
        Saltwater
    }

    enum WaterRegion { 
        Top,
        Middle,
        Buttom,
        All

    }
    
}
