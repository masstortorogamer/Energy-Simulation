using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafeItems : MonoBehaviour
{
    public Button buyCoffeeButton;
    public Button buyCakeButton;
    public Button buyMilkShakeButton;
    public Image cake;
    public Image milkShake;
    public Image coffee;
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

    public void BuyCake()
    {
        if (rewardCoins >= 10f)
        {
            Debug.Log("You have purchased: Cake");
            EnergyCoins.rewardCoins -= 10f;
            buyCakeButton.interactable = false;
            buyCakeButton.transform.Find("Text").GetComponent<Text>().text = "Bought";
            Destroy(cake);
        }
    }

    public void BuyMilkShake()
    {
        if (rewardCoins >= 7f)
        {
            Debug.Log("You have purchased: Milkshake");
            EnergyCoins.rewardCoins -= 7f;
            buyMilkShakeButton.interactable = false;
            buyMilkShakeButton.transform.Find("Text").GetComponent<Text>().text = "Bought";
            Destroy(milkShake);
        }
    }

    public void BuyCoffee()
    {
        if (rewardCoins >= 5f)
        {
            Debug.Log("You have purchased: Coffee");
            EnergyCoins.rewardCoins -= 5f;
            buyCoffeeButton.interactable = false;
            buyCoffeeButton.transform.Find("Text").GetComponent<Text>().text = "Bought";
            Destroy(coffee);
        }
    }
}
