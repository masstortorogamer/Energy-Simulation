using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public GameObject autoLightsUpgrade;
    public GameObject sunGeneratorsUpgrade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyAutoLights()
    {
        Destroy(autoLightsUpgrade);
        GameObject myHouse = GameObject.Find("MyHouse");
        myHouse.transform.Find("LeftWindowLight").gameObject.SetActive(true);
        myHouse.transform.Find("RightWindowLight").gameObject.SetActive(true);
        FactoryScript.cleanliness += 3.3f;
    }

    public void DestroySunGenerators()
    {
        Destroy(sunGeneratorsUpgrade);
        GameObject myHouse = GameObject.Find("MyHouse");
        myHouse.transform.Find("GeneratorRight").gameObject.SetActive(true);
        myHouse.transform.Find("GeneratorLeft").gameObject.SetActive(true);
        FactoryScript.cleanliness += 3.3f;
    }
}
