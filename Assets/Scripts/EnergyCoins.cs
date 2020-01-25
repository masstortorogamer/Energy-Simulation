using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCoins : MonoBehaviour
{
    public static float rewardCoins = 0f;
    public Text totalECCount;
    public Text totalPlayerECGainedText;
    public Text rewardCoinsText;

    public static float totalECGained = 0f;

    private float totalPlayerECGained;

    private Text rewardCoinsInformation;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Gain");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rewardCoins);
        totalECCount.text = "" + totalECGained.ToString("0");
        totalPlayerECGainedText.text = "Total Coins Earned: " + totalPlayerECGained.ToString("0");
        rewardCoinsText.text = "Reward Coins: " + rewardCoins.ToString("0");
    }

    IEnumerator Gain()
    {
        while (true)
        {
            yield return new WaitForSeconds(PassTime.waitTime);
            if (WindMillEnergy.gain < 1f && GameObject.Find("MyHouse/GeneratorRight")) 
            {
                rewardCoins += WindMillEnergy.gain + 0.10f; 
                totalPlayerECGained += WindMillEnergy.gain + 0.10f;
            }
            if (WindMillEnergy.gain < 1f)
            {
                rewardCoins += WindMillEnergy.gain;
                totalPlayerECGained += WindMillEnergy.gain;
            } 
            else
            {
                rewardCoins += WindMillEnergy.gain;
                totalPlayerECGained += WindMillEnergy.gain;
            }
        }
    }
}
