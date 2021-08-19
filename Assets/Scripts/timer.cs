using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public float temps = 60;
    public Text timertext;
    public static int TempsInt = 60;
    // Start is called before the first frame update
    void Start()  {
        
    }

    // Update is called once per frame
    void Update() {
        TempsInt = Mathf.RoundToInt(temps);
        timertext.text = (TempsInt + " s");
        if (temps <= 60)
        {
            temps -= Time.deltaTime;
        }

    }
}
