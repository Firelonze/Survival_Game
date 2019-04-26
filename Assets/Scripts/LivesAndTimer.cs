using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesAndTimer : MonoBehaviour
{
    public Text startText;
    public float timer;
    public int lives;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            startText.text = "You win!";
        }
    }
    private void OnGUI()
    {

    }
}

