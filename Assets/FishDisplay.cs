using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishDisplay : MonoBehaviour {

    public Fish fish;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI waterTypeText;
    public TextMeshProUGUI waterRegionText;
    public TextMeshProUGUI difficultyText;
    public Image FishArtwork;



    private void Start()
    {
        nameText.text = fish.name;
        descriptionText.text = fish.description;
        typeText.text ="Type: "+ fish.fishType.ToString();
        waterTypeText.text = "Water Type: " + fish.waterType.ToString();
        waterRegionText.text = "Type: " + fish.waterType.ToString();
        difficultyText.text = "Difficulty: " + fish.difficulty.ToString();
        FishArtwork.sprite = fish.artwork;
    }

}
