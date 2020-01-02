using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowify : MonoBehaviour
{
    public Material grass;
    public Material snow;
    public bool startSnowify = true;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnergyCoins.snowStormOnGoing && startSnowify)
        {
            if (anim != null)
            {
                anim.SetBool("Snowify", true);
                anim.SetBool("Unsnowify", false);
                startSnowify = false;
            }      
        }
        if (!EnergyCoins.snowStormOnGoing && !startSnowify)
        {  
            if (anim != null)
            {
                anim.SetBool("Snowify", false);
                anim.SetBool("Unsnowify", true);
                startSnowify = true;
            }
        }
        
    }
}
