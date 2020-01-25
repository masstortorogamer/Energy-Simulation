using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafeItems : MonoBehaviour
{
    public Button buyCoffeeButton;
    public GameObject showCurrentEC;

    public static float rewardCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rewardCoins = EnergyCoins.rewardCoins;
        showCurrentEC.GetComponent<Text>().text = "Reward Coins: " + Mathf.RoundToInt(rewardCoins);
    }

    public void BuyCoffee()
    {
        if (rewardCoins >= 10f)
        {
            Debug.Log("You have purchased: Coffee");
            EnergyCoins.rewardCoins -= 10f;
        }
    }
}
