using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour {
    public static WorldController Instance { get; protected set; }

    // The world and tile data
    public World world { get; protected set; }
    public GameObject DefaultBlock;
    public GameObject GrassBlock;
    public GameObject MountainBlock;
    public GameObject CharPrefab;

    static bool loadWorld = false;

    // Use this for initialization
    void OnEnable()
    {
        if (Instance != null)
        {
            Debug.LogError("There should never be two world controllers.");
        }
        Instance = this;

        if (loadWorld)
        {
            loadWorld = false;
   //         CreateWorldFromSaveFile();
        }
        else {
            world = new World();
       
            world.DefaultBlock = DefaultBlock;
            world.GrassBlock = GrassBlock;
            world.MountainBlock = MountainBlock;
            world.MakeWorld();
            loadWorld = false;
            Debug.Log("made the world");

            // Add some Characters
          //  GameObject[] gos = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[];           

        }

    }


    public void MakeChar()
    {
        
        Debug.Log(CharPrefab.name);
        Hero char1 = new Hero("Tom" + Random.Range(1f,50f)); 

        CharPrefab.transform.position = new Vector3(Random.Range(5f, 70f), 1f, Random.Range(5f, 70f));
        HeroManager hm = GameObject.FindObjectOfType<HeroManager>();
       
        hm.AddChar(char1, CharPrefab);      
    }



    void Update()
    {
        // TODO: Add pause/unpause, speed controls, etc...
      //  world.Update(Time.deltaTime);

    }
}
