using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindMillEnergy : MonoBehaviour
{
    public static float percentage = 0f;
    public static float gain = 0f;
    public Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        infoText.GetComponent<Text>().text = "Current amount of energy bought: " + 0 + "%";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gain);
    }

    public void Energy25()
    {
        percentage = 0.25f;
        gain = 0.25f;
        infoText.GetComponent<Text>().text = "Current amount of energy bought: " + 25 + "%";
    }

    public void Energy50()
    {
        percentage = 0.50f;
        gain = 0.50f;
        infoText.GetComponent<Text>().text = "Current amount of energy bought: " + 50 + "%"; 
    }

    public void Energy75()
    {
        percentage = 0.75f;
        gain = 0.75f;
        infoText.GetComponent<Text>().text = "Current amount of energy bought: " + 75 + "%";
    }

    public void Energy100()
    {
        percentage = 1.00f;
        gain = 1f;
        infoText.GetComponent<Text>().text = "Current amount of energy bought: " + 100 + "%";
    }
}
