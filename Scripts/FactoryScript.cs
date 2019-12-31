using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryScript : MonoBehaviour
{
    public static float cleanliness = 0f;
    public GameObject[] smokes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cleanliness >= 25f && cleanliness < 50)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 50 / 255f);
            }
        }

        if (cleanliness >= 50f && cleanliness < 75)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 35 / 255f);
            }
        }

        if (cleanliness >= 75f && cleanliness < 100)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 20 / 255f);
            }
        }

        if (cleanliness == 100)
        {
            foreach (GameObject particles in smokes)
            {
               var main = particles.GetComponentInChildren<ParticleSystem>().main;
               main.startColor = new Color(82 / 255f , 82 / 255f , 82 / 255f , 10 / 255f);
            }
        }
    }
}
