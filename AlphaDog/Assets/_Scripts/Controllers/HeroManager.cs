using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class HeroManager : MonoBehaviour {

    Dictionary<Hero, GameObject> characterMap;

    // Use this for initialization
    void Start()
    {
        characterMap = new Dictionary<Hero, GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddChar(Hero c, GameObject go)
    {
        Hero char1 = new Hero("Tom" + Random.Range(1f, 50f));
        characterMap.Add(char1, go);
     //   go.GetComponent<HeroController>().heroName.text  = "Tom" + Random.Range(1f, 50f);



        GameObject goH = new GameObject();
        goH = Instantiate(go, go.transform.position, Quaternion.identity) as GameObject;

       
    }

    public void Clicked(RaycastHit hitInfo)
    {
        Debug.Log("double clicky");
    }

    public bool WasClicked(RaycastHit hitInfo)
    {
        foreach (KeyValuePair<Hero, GameObject> pair in characterMap)
        {
            if (pair.Value.transform.position == hitInfo.point)
            {
                Debug.Log("FOund a hit");
                return true;
            }
        }

        return false;
    }

   
}
