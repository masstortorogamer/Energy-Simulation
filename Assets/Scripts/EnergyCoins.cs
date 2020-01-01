using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCoins : MonoBehaviour
{
    public static float energyCoins = 0f;
    public GameObject energyCoinsText;
    public static float savedPower;

    private Text energyCoinsInformation;
    // Start is called before the first frame update
    void Start()
    {
        energyCoinsInformation = energyCoinsText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        energyCoinsInformation.text = "Energy Coins: " + Mathf.RoundToInt(energyCoins);
        savedPower = PowerBar.powerSaving;
        if (savedPower == 25f)
        {
            energyCoins += 0.2f * Time.deltaTime;
        }
        if (savedPower == 50f)
        {
            energyCoins += 0.4f * Time.deltaTime;
        }
    }
}
