using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafeItems : MonoBehaviour
{
    public Button buyCoffeeButton;
    public GameObject showCurrentEC;

    public static float energyCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyCoins = EnergyCoins.energyCoins;
        showCurrentEC.GetComponent<Text>().text = "Energy Coins: " + Mathf.RoundToInt(energyCoins);
    }

    public void BuyCoffee()
    {
        if (energyCoins >= 10f)
        {
            Debug.Log("You have purchased: Coffee");
            EnergyCoins.energyCoins -= 10f;
        }
    }
}
