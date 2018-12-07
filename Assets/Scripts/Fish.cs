using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {

    public FishObject baseFish;
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
    public Action[] actions;// Use this for initialization



    void Start () {

        ConstructFishFromFishObject();
	}

    private void ConstructFishFromFishObject()
    {
        name = baseFish.name;
        description = baseFish.description;
        genus = baseFish.genus;
        species = baseFish.species;
        difficulty = baseFish.difficulty;
        avgAge = baseFish.avgAge;
        maxAge = baseFish.maxAge;
        artwork = baseFish.artwork;
        avgSize = baseFish.avgSize;
        maxSize = baseFish.maxSize;
        waterRegion = baseFish.waterRegion;
        minWaterVolume = baseFish.minWaterVolume;
        minPH = baseFish.minPH;
        maxPH = baseFish.maxPH;
        minTemp = baseFish.minTemp;
        maxTemp = baseFish.maxTemp;
        waterType = baseFish.waterType;
        food = baseFish.food;
        feedInterval = baseFish.feedInterval;
        actions = baseFish.actions;


    }

    // Update is called once per frame
    void Update () {
		
	}
}
