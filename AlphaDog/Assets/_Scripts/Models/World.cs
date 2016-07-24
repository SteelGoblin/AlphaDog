using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.IO;

public class World : IXmlSerializable 
{

    public int WorldLength = 100;
    public int WorldWidth = 100;
    public int WorldHeight = 3;

    public Block[,,] BlockList { get; set; }

    public GameObject DefaultBlock
    {
        get; set;
    }

    public GameObject GrassBlock
    {
        get; set;
    }

    public GameObject MountainBlock
    {
        get; set;
    }

    public World()
    {

        BlockList = new Block[WorldLength, WorldHeight, WorldWidth];
    }


    public void MakeWorld()
    {
        GameObject go;

        // Set Base
        for (int x = 0; x < WorldLength; x++)
            for (int z = 0; z < WorldWidth; z++)
            {
                if (x < 50 && z > 50)
                    go = DefaultBlock;
                else
                    go = GrassBlock;

                Block b = new Block(go);
                BlockList[x, 0, z] = b;
            }

        // Create Mountains

        go = MountainBlock;

        for (int i = 0; i < 20; i++)
        {
            Block b = new Block(go);
            BlockList[ i, 1, 0] = b;
            BlockList[i, 1, 1] = b;

            BlockList[17, 2, 0] = b;
            BlockList[18, 2, 1] = b;
            BlockList[19, 2, 2] = b;

        }





    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public XmlSchema GetSchema()
    {
        return null;
    }

    public void WriteXml(XmlWriter writer)
    {
        return;
    }

    public void ReadXml(XmlReader reader)
    {
        return;
    }
}
