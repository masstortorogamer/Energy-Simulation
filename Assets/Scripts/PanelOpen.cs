using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PanelOpen : MonoBehaviour
{
    public Button overviewButton;
    public Button overviewCloseButton;
    public GameObject overviewPanel;
    public Button upgradesButton;
    public GameObject upgradesPanel;
    public Button closeCafeButton;
    public GameObject cafePanel;
    public Button closeFactoryButton;
    public GameObject factoryPanel;
    public Button closeShortageButton;
    public Button doneWithShortageButton;
    public GameObject shortagePanel;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenOverviewPanel()
    {

        overviewButton.gameObject.SetActive(false);
        overviewCloseButton.gameObject.SetActive(true);
        overviewPanel.SetActive(true);
    }

    public void OpenUpgradesPanel()
    {
        upgradesButton.interactable = false;
        upgradesPanel.SetActive(true);
    }

    public void CloseOverviewPanel()
    {
        overviewCloseButton.gameObject.SetActive(false);
        overviewButton.gameObject.SetActive(true);
        overviewPanel.SetActive(false);
    }

    public void CloseCafePanel()
    {
        closeCafeButton.gameObject.SetActive(false);
        cafePanel.gameObject.SetActive(false);
    }

    public void CloseFactoryPanel()
    {
        closeFactoryButton.gameObject.SetActive(false);
        factoryPanel.gameObject.SetActive(false);
    }

    public void CloseShortagePanel()
    {
        if (EventSystem.current.currentSelectedGameObject.name == closeShortageButton.name)
        {
            shortagePanel.SetActive(false);
            EnergyCoins.chosenUpgrades.Clear();
        }
        if (EventSystem.current.currentSelectedGameObject.name == doneWithShortageButton.name && EnergyCoins.chosenUpgrades.Count > 0)
        {
            shortagePanel.SetActive(false);
        }
        
    }


}
