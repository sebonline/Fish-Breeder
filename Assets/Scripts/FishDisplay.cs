using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class FishDisplay : MonoBehaviour {

    public FishObject fish;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI waterTypeText;
    public TextMeshProUGUI waterRegionText;
    public TextMeshProUGUI difficultyText;
    public Image FishArtwork;
    public Slider ageSlider;
    public Slider phSlider;
    public Slider tempSlider;
    public Slider sizeSlider;



    private void Start()
    {
        nameText.text = fish.name;
        descriptionText.text = fish.description;
        typeText.text ="Type: "+ fish.genus.ToString();
        waterTypeText.text = "Water Type: " + fish.waterType.ToString();
        waterRegionText.text = "Type: " + fish.waterType.ToString();
        difficultyText.text = "Difficulty: " + fish.difficulty.ToString();
        FishArtwork.sprite = fish.artwork;

        SetSliders();
    }

    private void SetSliders()
    {
        ageSlider.minValue = 0f;
        ageSlider.maxValue = fish.maxAge;
        ageSlider.value = fish.avgAge;

        phSlider.minValue = fish.minPH;
        phSlider.maxValue = fish.maxPH;
        phSlider.value = (( fish.maxPH - fish.minPH) / 2f) + fish.minPH;

        tempSlider.minValue = fish.minTemp;
        tempSlider.maxValue = fish.maxTemp;
        tempSlider.value = ((fish.maxTemp - fish.minTemp) / 2f) + fish.minTemp;

        sizeSlider.minValue = 0f;
        sizeSlider.maxValue = fish.maxSize;
        sizeSlider.value = fish.avgSize;


    }
}
