﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Upgrades : MonoBehaviour
{
    public GameObject autoLightsUpgrade;
    public GameObject sunGeneratorsUpgrade;

    public int math;

    public static List<string> readyToUseUpgrades = new List<string>();
    public static List<string> appliedUpgrades = new List<string>();

    public Button autoLightsSelect;
    public Button sunGeneratorsSelect;
    public Button applyUpgradesButton;
    // Start is called before the first frame update
    void Start()
    {
        math = (100 / GameObject.FindGameObjectsWithTag("HouseSpawn").Length) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyAutoLights()
    {
        Destroy(autoLightsUpgrade);
        GameObject myHouse = GameObject.Find("MyHouse");
        myHouse.transform.Find("LeftWindowLight").gameObject.SetActive(true);
        myHouse.transform.Find("RightWindowLight").gameObject.SetActive(true);
        FactoryScript.pollution -= math;
        readyToUseUpgrades.Add("Auto Lights");
        EnergyCoins.playerECGain += 0.3f;
    }

    public void DestroySunGenerators()
    {
        Destroy(sunGeneratorsUpgrade);
        GameObject myHouse = GameObject.Find("MyHouse");
        myHouse.transform.Find("GeneratorRight").gameObject.SetActive(true);
        myHouse.transform.Find("GeneratorLeft").gameObject.SetActive(true);
        FactoryScript.pollution -= math;
        readyToUseUpgrades.Add("Sun Generators");
        EnergyCoins.playerECGain += 0.3f;
    }

        public void SelectUpgrades()
    {
        if (EventSystem.current.currentSelectedGameObject.name == autoLightsSelect.name && readyToUseUpgrades.Contains("Auto Lights"))
        {
            autoLightsSelect.gameObject.SetActive(true);
            EnergyCoins.chosenUpgrades.Add("Auto Lights");
            autoLightsSelect.interactable = false;

        }
        if (EventSystem.current.currentSelectedGameObject.name == sunGeneratorsSelect.name && readyToUseUpgrades.Contains("Sun Generators"))
        {
            sunGeneratorsSelect.gameObject.SetActive(true);
            EnergyCoins.chosenUpgrades.Add("Sun Generators");
            sunGeneratorsSelect.interactable = false;
        }
    }

        public void ApplyUpgrades()
        {
            if (EnergyCoins.chosenUpgrades.Count > 0)
            {
                appliedUpgrades = new List<string>(EnergyCoins.chosenUpgrades);
                EnergyCoins.chosenUpgrades.Clear();
                autoLightsSelect.interactable = true;
                sunGeneratorsSelect.interactable = true;
                
            }
        }
}
