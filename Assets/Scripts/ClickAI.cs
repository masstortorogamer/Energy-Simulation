using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if(!EventSystem.current.IsPointerOverGameObject() && hit.transform.parent.name == "AIHouse")
                {
                    if (GameObject.Find("BarGraph"))
                    {
                        GameObject.Find("BarGraph").gameObject.SetActive(false);
                        hit.transform.parent.Find("BarGraph").gameObject.SetActive(true);
                    }
                    else
                    hit.transform.parent.Find("BarGraph").gameObject.SetActive(true);
                }
            }
        }
        
    }
}
