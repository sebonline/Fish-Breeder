using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquariumParameters : MonoBehaviour {

    public Aquarium aquariumPreset;
    public float maxWaterVolume;
    public float height;
    public float width;
    public float length;
    public float glassThickness;
    public bool isClearGlass;

    public float currentTemp;
    public float currentPH;
    public float currentSalinity;
    public float currentWaterVolume;

    public float evaporationRate;
    public GameObject WaterPivot;

    public Gamemanager gamemanager;

    public Selectable selectedable;
    public Fish[] fishes;






    private void Start()
    {
        gamemanager = FindObjectOfType<Gamemanager>();
        selectedable = GetComponent<Selectable>();


        if (aquariumPreset)
        {
            SetupFromPreset();
        }
        else
        {
            SetupAquarium();
        }
    }

    private void Update()
    {
        Evaporation();
        
    }

    private void Evaporation()
    {
        currentWaterVolume = Mathf.Clamp(currentWaterVolume - (evaporationRate * Time.deltaTime),0,maxWaterVolume);
        WaterPivot.transform.localScale = new Vector3(1,
                                                    Mathf.Clamp((currentWaterVolume / maxWaterVolume),0.1f,(maxWaterVolume*1.01f)),
                                                    1);
    }

    private void SetupFromPreset()
    {
        maxWaterVolume = CalcWaterVolume(aquariumPreset.height, aquariumPreset.width, aquariumPreset.length);
        currentWaterVolume = maxWaterVolume;
    }

    private void SetupAquarium()
    {
        Debug.Log("setting upcustom");
    }


    public float CalcWaterVolume(float height,float width,float length)
    {
        float volume;

        volume = (height * width * length)/1000f;
        return volume;
    }
}
