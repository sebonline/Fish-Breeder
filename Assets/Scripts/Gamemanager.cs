using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    public float money;
    public float xp;
    public int level;
    public string playerName;
    public GameObject selectedObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                
                if (hitInfo.transform.gameObject.GetComponent<Selectable>()!=null)
                {
                    if(selectedObject != null)
                    { selectedObject.GetComponent<Selectable>().isSelected = false; }
                    
                    selectedObject = hitInfo.transform.gameObject;
                    selectedObject.GetComponent<Selectable>().isSelected = true;
                    Debug.Log("you Selected: " + selectedObject.name );
                }
                else
                {
                    if (selectedObject != null)
                    {
                        selectedObject.GetComponent<Selectable>().isSelected = false;
                    }
                        
                    selectedObject = null;
                    Debug.Log("You Hit " + hitInfo.transform.gameObject.name);
                }
            }
            else
            {
                Debug.Log("No hit");
            }
          
        }
    }
}
