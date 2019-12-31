using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIStart : MonoBehaviour
{
    public static bool start = false;
    public GameObject AIHouse;
    public GameObject[] houseLocations;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            houseLocations = GameObject.FindGameObjectsWithTag("HouseSpawn");
            
                foreach (GameObject location in houseLocations)
            {
                Instantiate(AIHouse, location.transform.position, location.transform.rotation);
                start = false;
            }
        }
    }
}
