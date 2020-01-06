using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactoryScript : MonoBehaviour
{
    public static float pollution = 100f;
    public GameObject[] smokes;

    public GameObject percentage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        percentage.GetComponent<Text>().text = "" + Mathf.RoundToInt(pollution) + "%";
        if (pollution >= 50f && pollution < 75)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 50 / 255f);
            }
        }

        if (pollution >= 25f && pollution < 50)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 35 / 255f);
            }
        }

        if (pollution >= 0f && pollution < 25)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 20 / 255f);
            }
        }

        if (pollution == 0)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 10 / 255f);
            }
        }
    }
}
