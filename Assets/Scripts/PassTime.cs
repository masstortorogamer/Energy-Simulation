using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassTime : MonoBehaviour
{
    public static int time = 6;
    public static float waitTime;
    public Text currentTime;
    public Light sun;

    private bool passTime = true;

    public float personalWaitTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = personalWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime.GetComponent<Text>().text = "" + time + " O'Clock";
        if (time == 24)
            {
                StartCoroutine("RestartTime");
            }
        if (time < 24 && passTime)
        {
            StartCoroutine("Time");
            passTime = false;
        }
    }

    IEnumerator Time()
    {
            yield return new WaitForSeconds(waitTime);
            if (time == 11 || time == 17 || time == 23 || time == 5)
            {
                sun.transform.Rotate(90,0,0, Space.World);
            }
            time += 1;  
            passTime = true;

        
    }

    IEnumerator RestartTime()
    {
        yield return new WaitForSeconds(waitTime);
        time = 1;
    }
}
