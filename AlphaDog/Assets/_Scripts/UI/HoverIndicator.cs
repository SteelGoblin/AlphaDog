using UnityEngine;
using System.Collections;

public class HoverIndicator : MonoBehaviour {

	MouseController mm;
    HeroController hc;
    HeroController oldHC;
    bool currSelect = false;


	// Use this for initialization
	void Start () {
		mm = GameObject.FindObjectOfType<MouseController>();
	}

    // Update is called once per frame
    void Update()
    {
        if (mm.hoverObject != null)
        {
            // check if it's a  hero vs. something else
            hc = mm.hoverObject.GetComponent<HeroController>();
            if (hc)
            {
                hc.isHover = true;
                oldHC = hc;
                currSelect = true;
                Bounds bigBounds = mm.hoverObject.GetComponentInChildren<Renderer>().bounds;

                // This "diameter" only works correctly for relatively circular or square objects
                float diameter = bigBounds.size.z;
                diameter *= 1.25f;
                Vector3 v = mm.hoverObject.transform.position;
                v.y = 1f;

                this.transform.position = new Vector3(bigBounds.center.x, bigBounds.center.y, bigBounds.center.z);
                //this.transform.position = v;
                this.transform.localScale = new Vector3(bigBounds.size.x * diameter, bigBounds.size.y, bigBounds.size.z * diameter);
            }
            else if (currSelect)
            {
                // hide out of the way
                transform.position = new Vector3(0, -10, 0);
                currSelect = false;
                if (oldHC)
                    oldHC.isHover = false;
            }
        }

    }
	
}
 