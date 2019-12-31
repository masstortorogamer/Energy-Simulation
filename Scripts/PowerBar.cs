using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public static float powerSaving = 0f;
    public float powerSavingLimit = 100f;
    public float powerConsumption = 100f;
    public float powerConsumptionLimit = 100f;

    public Image powerSavingBarForeground;
    public Image powerConsumptionBarForeground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        powerSavingBarForeground.transform.localScale = new Vector3(1, (powerSaving / powerSavingLimit), 1);
        powerConsumptionBarForeground.transform.localScale = new Vector3(1, powerConsumption / powerConsumptionLimit, 1);
    }

    public void UpgradeSaving()
    {
        powerSaving += 25;
        powerConsumption -= 25;

    }
}
