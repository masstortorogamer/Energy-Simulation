using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbulance : MonoBehaviour
{
    public GameObject turbine;
    public static float windPower = 0f;
    public float waitTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RandomWindPower");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(turbine.transform.position, Vector3.back, windPower * Time.deltaTime);
    }

    IEnumerator RandomWindPower()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            windPower = Random.Range(0f, 50f);
        }
        
    }
}
