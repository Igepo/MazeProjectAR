using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class message_fin : MonoBehaviour
{
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {   
        if (score.score_valeur >= 3)
        {
            winText.text = "Win !";
            Time.timeScale = 0;
        }

        if (timer.TempsInt <= 0 )
        {
            winText.text = "Lose !";
            Time.timeScale = 0;
        }


    }
}