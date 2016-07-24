using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeroHover : MonoBehaviour
{
    MouseController mm;
    HeroController hc;
    Text statusText;

    // Use this for initialization
    void Start ()
    {
        mm = GameObject.FindObjectOfType<MouseController>();
        statusText = GameObject.Find("PlayerStatus").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (mm.hoverObject != null)
        {
            // check if it's a  hero vs. something else
            hc = mm.hoverObject.GetComponent<HeroController>();
            if (hc)
            {
                statusText.text = hc.heroName;
            }
        }
    }
}
