using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCoins : MonoBehaviour
{
    public static float energyCoins = 0f;
    public GameObject energyCoinsText;
    public static float savedPower;
    public GameObject shortageInfoPanel;
    public float timeBeforeStorm = 25f;
    public float originalStormTime = 20f;
    public float stormTime;
    public float warningTime;

    public GameObject snowStormLocation;
    public GameObject snowStorm;
    
    public Button autoLightsSelect;
    public Button sunGeneratorsSelect;

    public static List<string> chosenUpgrades = new List<string>();

    private Text energyCoinsInformation;

    private bool warning = false;
    public static bool snowStormOnGoing = false;
    // Start is called before the first frame update
    void Start()
    {
        energyCoinsInformation = energyCoinsText.GetComponent<Text>();
        //Warning time will always be timeBeforeStorm's half.
        warningTime = timeBeforeStorm / 2;
        //Keep the value of Storm Time to call it back at the end.
        stormTime = originalStormTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeBeforeStorm > 0f && Click.startGame == true)
        {
            timeBeforeStorm -= 1f * Time.deltaTime;
            //Make the upgrades appear if the Player owns them.
            if (Upgrades.readyToUseUpgrades.Contains("Auto Lights"))
            {
                autoLightsSelect.gameObject.SetActive(true);
            }
            if (Upgrades.readyToUseUpgrades.Contains("Sun Generators"))
            {
                sunGeneratorsSelect.gameObject.SetActive(true);
            }
            //Show the warning panel and set the bool to true.
            if (timeBeforeStorm <= warningTime && timeBeforeStorm > 0 && warning == false)
            {

            shortageInfoPanel.SetActive(true);
            warning = true;

            }
        }
        
        //Create the Snow Storm.
        if (timeBeforeStorm <= 0 && snowStormOnGoing == false)
        {
            Instantiate(snowStorm, snowStormLocation.transform.position, snowStormLocation.transform.rotation);
            snowStormOnGoing = true;
            shortageInfoPanel.SetActive(false);
        }
        //Give the Player Energy Coins for providing Energy during Snow Storm.
        if (stormTime > 0f && snowStormOnGoing == true)
        {
            stormTime -= 1f * Time.deltaTime;
            energyCoins += 0.2f * Upgrades.appliedUpgrades.Count * Time.deltaTime;
            energyCoinsInformation.text = "Energy Coins: " + Mathf.Round(energyCoins);
            Debug.Log("Currently increasing EC by: " + 0.2f * Upgrades.appliedUpgrades.Count);
        }
        if (stormTime <= 0)
        //Set values back to their original value.
        {
            timeBeforeStorm = warningTime * 2;
            warning = false;
            GameObject spawnedSnowStorm = GameObject.FindWithTag("SnowStorm");
            Destroy(spawnedSnowStorm);
            snowStormOnGoing = false;
            stormTime = originalStormTime;
            Upgrades.appliedUpgrades.Clear();
        }
    }
}
