using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    public Button informationButton;
    public Button openGraphButton;

    public static bool startGame = false;

    private TextMesh informationText;
    private bool constructed = false;
    public static bool approved = false;

    // Start is called before the first frame update
    void Start()
    {
        informationButton.gameObject.SetActive(true);
        openGraphButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
