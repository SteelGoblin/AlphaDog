using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;

public class HeroController : MonoBehaviour {

    public string heroName;
    public bool isHover { get; set; }
    public bool isSelected { get; set; }
    static int heroNumber = 0;
  
    public Hero hero { get; set; }

    void Start()
    {
        heroName = "Ranger" + heroNumber++;
        isSelected = false;
    }


    void Clicked()
    {
        isSelected = true;
        Debug.Log("clicked " + heroName);
    }

    void UnClicked()
    {
        isSelected = false;
        Debug.Log("unclicked " + heroName);
    }


   }
