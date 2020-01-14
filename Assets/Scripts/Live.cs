using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Live : MonoBehaviour
{
    // Start is called before the first frame update
    public float powerUsage = 0.5f;

    private int time;
    void Start()
    {
        time = PassTime.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        switch(time)
        {
            case 1:
                powerUsage = Random.Range(0.1f, 1f);
                GameObject.Find("B1").GetComponent<RectTransform>().localScale = new Vector3(0.1838f, powerUsage, 0);
                break;

        }
    }
}
