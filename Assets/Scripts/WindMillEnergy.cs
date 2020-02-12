using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindMillEnergy : MonoBehaviour
{
    public static float percentage = 0f;
    public static float gain = 0f;
    public Image[] smokes;
    public Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        infoText.GetComponent<Text>().text = 0 + "%";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gain);
    }

     public void Energy0()
    {
        percentage = 0f;
        gain = 0f;
        FactoryScript.pollution = 100f;
        infoText.GetComponent<Text>().text = 0 + "%";
        foreach (Image smoke in smokes)
        {
            smoke.GetComponent<Image>().color = new Color(smoke.color.r, smoke.color.g, smoke.color.b, 1f);
        }
    }

    public void Energy25()
    {
        percentage = 0.25f;
        gain = 0.25f;
        FactoryScript.pollution = 75f;
        infoText.GetComponent<Text>().text = 25 + "%";
        foreach (Image smoke in smokes)
        {
            smoke.GetComponent<Image>().color = new Color(smoke.color.r, smoke.color.g, smoke.color.b, 0.75f);
        }
    }

    public void Energy50()
    {
        percentage = 0.50f;
        gain = 0.50f;
        FactoryScript.pollution = 50f;
        infoText.GetComponent<Text>().text = 50 + "%";
        foreach (Image smoke in smokes)
        {
            smoke.GetComponent<Image>().color = new Color(smoke.color.r, smoke.color.g, smoke.color.b, 0.50f);
        } 
    }

    public void Energy75()
    {
        percentage = 0.75f;
        gain = 0.75f;
        FactoryScript.pollution = 25f;
        infoText.GetComponent<Text>().text = 75 + "%";
        foreach (Image smoke in smokes)
        {
            smoke.GetComponent<Image>().color = new Color(smoke.color.r, smoke.color.g, smoke.color.b, 0.25f);
        }
    }

    public void Energy100()
    {
        percentage = 1.00f;
        gain = 1f;
        FactoryScript.pollution = 10f;
        infoText.GetComponent<Text>().text = 100 + "%";
        foreach (Image smoke in smokes)
        {
            smoke.GetComponent<Image>().color = new Color(smoke.color.r, smoke.color.g, smoke.color.b, 0.10f);
        }
    }
}
