using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildHouse : MonoBehaviour
{
    public float buildTime = 10f;

    private bool beginConstruction = false;
    private bool constructed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!beginConstruction)
        {
            StartCoroutine("Build");
            gameObject.transform.name = "MyHouse";
            beginConstruction = true;
        }
    }

    IEnumerator Build()
    {
        while (!constructed && buildTime > 0)
        {
            gameObject.transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
            buildTime -= 1 * Time.deltaTime;
            yield return null;
        }
        
    }
}
