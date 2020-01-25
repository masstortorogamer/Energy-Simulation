using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ClickWindFarm : MonoBehaviour
{
    public GameObject millClickBox;
    public GameObject millPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (!EventSystem.current.IsPointerOverGameObject() && hit.transform.gameObject.name == millClickBox.name)
                {
                    millPanel.gameObject.SetActive(true);
                }
            }
        }
        
    }
}
