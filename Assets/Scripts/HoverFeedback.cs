using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverFeedback : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        if(!EventSystem.current.IsPointerOverGameObject())
        {
            transform.parent.gameObject.GetComponent<Animator>().SetBool("Over", true);
        }
        else
        transform.parent.gameObject.GetComponent<Animator>().SetBool("Over", false);
    }

    void OnMouseExit()
    {
            transform.parent.gameObject.GetComponent<Animator>().SetBool("Over", false);
    }
}
