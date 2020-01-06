using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBuildHouse : MonoBehaviour
{
    public float buildTime = 10f;
//-------------------------------------Private
    private float waitTime;

    private List<string> upgrades = new List<string>(){"AutoLights", "SunGenerators"};
    private string selectedUpgrade;

    public static float ecGain = 0f;

    private int index;
    private float math;

    private bool beginConstruction = false;
    private bool constructed = false;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = Random.Range(1f,10f);
        math = (100 / GameObject.FindGameObjectsWithTag("HouseSpawn").Length) / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (!beginConstruction)
        {
            StartCoroutine("Build");
            gameObject.transform.name = "AIHouse";
            beginConstruction = true;
        }
    }

    IEnumerator Build()
    {
        while (!constructed && buildTime > 0)
        {
            yield return new WaitForSeconds(waitTime);
            waitTime = 0f;
            gameObject.transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
            buildTime -= 1 * Time.deltaTime;
            yield return null;
        }

        StartCoroutine("Upgrade");
        
    }

    IEnumerator Upgrade()
    {
        while(true)
        {
            yield return new WaitForSeconds(10);
            if (upgrades.Count != 0)
            {
                index = Random.Range(0, upgrades.Count);
                selectedUpgrade = upgrades[index];
            }
            if (selectedUpgrade == "AutoLights")
            {
                transform.Find("LeftWindowLight").gameObject.SetActive(true);
                transform.Find("RightWindowLight").gameObject.SetActive(true);
                upgrades.Remove(selectedUpgrade);
                selectedUpgrade = "";
                ecGain += 0.3f;
                if (FactoryScript.pollution > 10f)
                {
                    FactoryScript.pollution -= math;
                }

                

            yield return null;
            }
            if (selectedUpgrade == "SunGenerators")
            {
                transform.Find("GeneratorLeft").gameObject.SetActive(true);
                transform.Find("GeneratorRight").gameObject.SetActive(true);
                upgrades.Remove(selectedUpgrade);
                selectedUpgrade = "";
                FactoryScript.pollution -= math;
                ecGain += 0.3f;
                    if (FactoryScript.pollution > 10f)
                    {
                    FactoryScript.pollution -= math;
                    }
            }
            
            yield return null;
        }
    }
}
