using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTime : MonoBehaviour
{
    public static int time = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Time");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Time()
    {
        while(true)
        {
            yield return new WaitForSeconds(120);
            time += 1;
        }
        
    }
}
