using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 


public class MouseController: MonoBehaviour
{
    public GameObject hoverObject;
    public GameObject selectObject;
    public Vector3 currentTileCoord;
    Vector3 preTileCoord;

    public Transform selectionCube;
    public HeroManager hm;

    GameObject prevSelectObject;

    Text statusText;

    void Start()
    {
        hm = GameObject.FindObjectOfType<HeroManager>();        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            int x = Mathf.FloorToInt(hitInfo.point.x / 1);
            int y = Mathf.FloorToInt(hitInfo.point.y / 1);
            int z = Mathf.FloorToInt(hitInfo.point.z / 1);

            if (currentTileCoord != preTileCoord)
            {                              
                preTileCoord = currentTileCoord;
            }

            GameObject hitObject = hitInfo.transform.root.gameObject;
            if (prevSelectObject == null)
                prevSelectObject = hitObject;
            

            SelectObject(hitObject);


            currentTileCoord.x = x;
            currentTileCoord.y = y;
            currentTileCoord.z = z;

           // selectionCube.transform.position = currentTileCoord;
        }
        else {
           // ClearSelection();
        }

        if (Input.GetMouseButtonDown(0))
        {
     /*       if (hm.WasClicked(hitInfo))
            {
                Debug.Log("Char was clicked");
            }*/

            if ((prevSelectObject) && hitInfo.transform.gameObject != prevSelectObject )
            {
                prevSelectObject.SendMessage("UnClicked", hitInfo.point, SendMessageOptions.DontRequireReceiver);
                hitInfo.transform.gameObject.SendMessage("Clicked", hitInfo.point, SendMessageOptions.DontRequireReceiver);                
                prevSelectObject = hitInfo.transform.root.gameObject;
                selectObject = prevSelectObject;
            }
            

        }
    }


    void SelectObject(GameObject obj)
    {
        if (hoverObject != null)
        {
            if (obj == hoverObject)
                return;

            ClearSelection();
        }

        hoverObject = obj;

     /*   Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            Material m = r.material;
            m.color = Color.green;
            r.material = m;
        }*/
    }

    void ClearSelection()
    {
        if (hoverObject == null)
            return;

        /*Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            Material m = r.material;
            m.color = Color.white;
            r.material = m;
        }*/


        hoverObject = null;
    }
}
