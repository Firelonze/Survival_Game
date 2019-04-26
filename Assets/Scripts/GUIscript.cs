using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour
{
    public Texture heart;
    public int amountOfHearts; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            amountOfHearts++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            amountOfHearts--;
        }
    }
    void OnGUI()
    {
        if(heart)
        {
            Debug.LogError("Please Enter a Texture of the Heart");
            return;
        }
        GUI.DrawTexture(new Rect(10 +(80 * amountOfHearts), 10, 80, 100), heart, ScaleMode.ScaleToFit, true);
    }
}
