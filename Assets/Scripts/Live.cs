using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Live : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] greenBars;

    private float powerUsage = 0.5f;
    private float math = WindMillEnergy.percentage + 0.10f;

    private int time;
    private int lastHour;
    private bool spendTime = false;
    void Start()
    {
        foreach (GameObject gbars in greenBars)
                 {
                     gbars.gameObject.SetActive(true);
                 }
        time = PassTime.time;
        lastHour = time;
        StartCoroutine("Living");
        


    }

    // Update is called once per frame
    void Update()
    {
        if (PassTime.time == 24)
        {
            StartCoroutine("RestartGraph");
        }

        if (PassTime.time <= 24 && !spendTime)
        {
            StartCoroutine("Living");
            spendTime = true;
        }
    }

    IEnumerator Living()
    {
            lastHour = PassTime.time;
            powerUsage = Random.Range(0.1f, 1f);


            if (transform.Find("GeneratorRight").gameObject.active && transform.Find("GeneratorLeft").gameObject.active && PassTime.time > 8 && PassTime.time < 18)
            {
             transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time).GetComponent<RectTransform>().localScale = new Vector3(0.1838f, powerUsage, 0);
             transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time + "G").GetComponent<RectTransform>().localScale = new Vector3(0.1838f, Mathf.Clamp(powerUsage * (WindMillEnergy.percentage + 0.10f), 0f, powerUsage), 1);
            }
            else
            {
                transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time).GetComponent<RectTransform>().localScale = new Vector3(0.1838f, powerUsage, 0);
                transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time + "G").GetComponent<RectTransform>().localScale = new Vector3(0.1838f, Mathf.Clamp(powerUsage * WindMillEnergy.percentage, 0f, powerUsage), 1);
            }

            

            yield return new WaitUntil(() => lastHour != PassTime.time );
            spendTime = false;
        
    }

    IEnumerator RestartGraph()
    {
        yield return new WaitForSeconds(PassTime.waitTime);
        foreach(Transform img in transform.Find("BarGraph/GraphPanel/Bars"))
                {
                    img.GetComponent<RectTransform>().localScale = new Vector3(0.1838f, 0.01f, 0);
                    
                }
                transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time).GetComponent<RectTransform>().localScale = new Vector3(0.1838f, powerUsage, 0);
                transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time + "G").GetComponent<RectTransform>().localScale = new Vector3(0.1838f, Mathf.Clamp(powerUsage * WindMillEnergy.percentage, 0f, powerUsage), 1);
                if (transform.Find("GeneratorRight").gameObject.active && transform.Find("GeneratorLeft").gameObject.active)
                {
                foreach (GameObject gbars in greenBars)
                 {
                     gbars.gameObject.SetActive(true);
                 }
                 transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time).GetComponent<RectTransform>().localScale = new Vector3(0.1838f, powerUsage, 0);
                 transform.Find("BarGraph/GraphPanel/Bars/B" + PassTime.time + "G").GetComponent<RectTransform>().localScale = new Vector3(0.1838f, Mathf.Clamp(powerUsage * WindMillEnergy.percentage, 0f, powerUsage), 1);
            }
    }
}
