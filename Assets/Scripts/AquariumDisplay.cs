using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Aquarium : MonoBehaviour
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
        heightText.text = aquarium.height.ToString();
        widthText.text = aquarium.width.ToString();
        lengthText.text = aquarium.lenght.ToString();
        glassThicknessText.text = aquarium.glassThickness.ToString();

        if (aquarium.isClearGlass)
        {
            isClearGlassText.text = "This Aquarium uses Clear Glass with low Iron parts";
        }
        else
        {
            isClearGlassText.text = "This Aquarium uses Float Glass which will appear a little green";
        }
        silikonText.text = aquarium.silikon.ToString();  
        volumeText.text = CalcVolume(aquarium.height, aquarium.width, aquarium.length, aquarium.glassThickness).ToString();
    }

    public float CalcVolume(float height, float width, float lenght, float glassThickness)
    {
        float VolReturn = ((height - glassThickness) * (width - glassThickness) * (length - glassThickness));
        return VolReturn;
    }




}