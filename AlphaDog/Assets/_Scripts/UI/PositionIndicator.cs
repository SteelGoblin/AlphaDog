using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PositionIndicator : MonoBehaviour
{
    MouseController mm;
    Text statusText;

    // Use this for initialization
    void Start ()
    {
        mm = GameObject.FindObjectOfType<MouseController>();
        statusText = GameObject.Find("BlockStatus").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update ()
    {
        statusText.text = "Tile: " + mm.currentTileCoord.x + ", " + mm.currentTileCoord.y + ", " + mm.currentTileCoord.z;
    }
}
