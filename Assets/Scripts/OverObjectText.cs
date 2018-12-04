using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OverObjectText : MonoBehaviour {


    public Transform target;
    public TextMeshPro text;
    // Update is called once per frame
    private void Start()
    {
        text =  GetComponent<TextMeshPro>();
        target = Camera.main.transform;
        text.text = transform.parent.name;
    }

    void Update () {
        if (GetComponentInParent<Selectable>().isSelected)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }

        transform.forward = target.forward;
	}
}
