using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Aquarium", menuName = "Aquarium")]
public class Aquarium : ScriptableObject
{
    public new string name;
    public string description;
    public float height;
    public float width;
    public float length;
    public float glassThickness;
    public bool isClearGlass;
    public Silikon silikon;
    

    

   
    public enum Silikon
    {
        Black,
        White,
        Clear
    }



}