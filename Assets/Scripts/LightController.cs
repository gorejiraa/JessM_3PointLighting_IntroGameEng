using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{    
    public Light keyLight;
    public Light fillLight;
    public Light backLight;

    private Image KeyLightImage;
    private Image FillLightImage;
    private Image BackLightImage;


    private bool keyLightBool = true;
    private bool fillLightBool = true;
    private bool backLightBool = true;

    // Start is called before the first frame update
    void Start()
    {
        GameObject KeyLightImageObj = GameObject.Find("KeyLightImage");
        KeyLightImage = KeyLightImageObj.GetComponent<Image>();

        GameObject FillLightImageObj = GameObject.Find("FillLightImage");
        FillLightImage = FillLightImageObj.GetComponent<Image>();

        GameObject BackLightImageObj = GameObject.Find("BackLightImage");
        BackLightImage = BackLightImageObj.GetComponent<Image>();    
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle for Keylight
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!keyLightBool)      { keyLight.enabled = true;  keyLightBool = true; KeyLightImage.color = Color.green; }
            else if (keyLightBool)  { keyLight.enabled = false; keyLightBool = false; KeyLightImage.color = Color.red;  }           
        }

        // Toggle for FillLight
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!fillLightBool)     { fillLight.enabled = true; fillLightBool = true; FillLightImage.color = Color.green; }
            else if (fillLightBool) { fillLight.enabled = false; fillLightBool = false; FillLightImage.color = Color.red; }
        }

        // Toggle for BackLight;
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!backLightBool)      { backLight.enabled = true; backLightBool = true; BackLightImage.color = Color.green; }
            else if (backLightBool)  { backLight.enabled = false; backLightBool = false; BackLightImage.color = Color.red; }
        }

    }
}
