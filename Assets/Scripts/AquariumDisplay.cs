using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AquariumDisplay : MonoBehaviour
{
    public Aquarium aquarium;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI heightText;
    public TextMeshProUGUI widthText;
    public TextMeshProUGUI lengthText;
    public TextMeshProUGUI glassThicknessText;
    public TextMeshProUGUI isClearGlassText;  
    public TextMeshProUGUI silikonText;
    public TextMeshProUGUI volumeText;

    public void Start()
    {
        nameText.text = aquarium.name;
        descriptionText.text = aquarium.description;
        heightText.text = "height: " + aquarium.height.ToString() +" cm";
        widthText.text = "width: " + aquarium.width.ToString() + " cm";
        lengthText.text = "length: "+ aquarium.length.ToString() + " cm";
        glassThicknessText.text = "Glass Thickness: " +aquarium.glassThickness.ToString() + " cm";

        if (aquarium.isClearGlass)
        {
            isClearGlassText.text = "This Aquarium uses Clear Glass with low Iron parts";
        }
        else
        {
            isClearGlassText.text = "This Aquarium uses Float Glass which will appear a little green";
        }
        silikonText.text = "Silicon: " + aquarium.silikon.ToString();  
        volumeText.text = "Water Volume: " + CalcVolume(aquarium.height, aquarium.width, aquarium.length, aquarium.glassThickness).ToString("#.#") +" Liters";
    }

    public float CalcVolume(float height, float width, float length, float glassThickness)
    {
        float VolReturn = ((height - glassThickness) * (width - glassThickness) * (length - glassThickness))/1000f;
        return VolReturn;
    }




}