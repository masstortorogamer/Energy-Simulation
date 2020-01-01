using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject smallHouse;
    public GameObject clickObject;
    public GameObject spawnLocation;
    public GameObject information;
    public GameObject houseLocation;
    public Button informationButton;

    private TextMesh informationText;
    private bool constructed = false;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Create a ray from camera towards where the mouse is.
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //See if mouse was clicked on something and see if the clicked object is the one defined.
                if (hit.transform != null && hit.transform.gameObject.name == "ClickBox" && !constructed)
                {
                    //If the player clicks on the ClickBox, get that HouseLocation's children and assign their place.
                    clickObject = hit.transform.gameObject;
                    houseLocation = clickObject.transform.parent.gameObject;
                    spawnLocation = houseLocation.transform.Find("HouseSpawnLocation").gameObject;
                    information = houseLocation.transform.Find("InformationText").gameObject;
                    informationText = information.GetComponent<TextMesh>();
                    spawnLocation.gameObject.tag = "PlayerSpawn";
                    constructed = true;

                    //If what the player clicks is the clickObject, and the house is not constructed yet, build a new one.
                    if (hit.transform.gameObject == clickObject)
                    {
                        Instantiate(smallHouse, spawnLocation.transform.position, spawnLocation.transform.rotation);
                        informationText.text = "Building";
                        StartCoroutine("Construct");
                        
                    }
                }
            }
        }
    }

    //Waiting for the building to be completed, updating the 3DText.
    IEnumerator Construct()
    {
        yield return new WaitForSeconds(10);
        informationText.text = "Building Complete!";
        informationButton.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        informationText.text = "";
        AIStart.start = true;
    }
}
