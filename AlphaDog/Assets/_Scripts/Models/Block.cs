using UnityEngine;
using System.Collections;

public class Block  {
    public GameObject BlockTile { get; set; }

    public Block(GameObject go)
    {
        BlockTile = go;
    }

    public void Init(GameObject go)
    {
        BlockTile = go;
    }

   
}
