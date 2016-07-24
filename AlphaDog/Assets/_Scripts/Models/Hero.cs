using UnityEngine;
using System.Collections;

public class Hero {

    public Vector3 targetCoord {get;set;}

    public string Name { get; set; }
    int Health = 100;


    public Hero(string s)
    {
        Name = s;
    }

	
}
