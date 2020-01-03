using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAtomEnergy : MonoBehaviour
{
    public GameObject atomEnergyClickBox;
    public GameObject atomEnergyUtilitiesInfoPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (!EventSystem.current.IsPointerOverGameObject() && hit.transform.gameObject == atomEnergyClickBox)
                {
                    atomEnergyUtilitiesInfoPanel.SetActive(true);
                }
            }
        }
    }
}
