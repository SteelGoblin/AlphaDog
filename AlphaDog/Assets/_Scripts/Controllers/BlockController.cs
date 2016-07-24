using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {

    GameObject[,,] BlockList;

    World world
    {
        get { return WorldController.Instance.world; }
    }


   

    public void Add(GameObject go,int x,int y, int z)
    {
        BlockList[x, y, z] = go; 
    }

    public void StartWorld()
    {
        for (int x = 0; x < world.WorldLength; x++)
            for (int y = 0; y < world.WorldHeight; y++)
            {
                for (int z = 0; z < world.WorldWidth ; z++)
                {
                    Vector3 vec = new Vector3(x, y, z);
                    if (BlockList[x, y, z] != null)
                    {
                        Instantiate(BlockList[x, y, z], vec, Quaternion.identity);
                        //BlockList[x, y, z].transform.SetParent(this.transform, true);
                    }
                }                
            }
    }


	// Use this for initialization
	void Start () {
        BlockList = new GameObject[world.WorldLength,world.WorldHeight, world.WorldWidth];
        for (int x = 0; x < world.WorldLength; x++)
        {
            for (int y = 0; y < world.WorldHeight; y++)
            {
                for (int z = 0; z < world.WorldWidth ; z++)
                {
                    if (world.BlockList[x, y, z] != null)
                    {
                        BlockList[x, y, z] = world.BlockList[x, y, z].BlockTile;
                    }
                } 
                 

            }
        }

        StartWorld();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    
}
