using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int score_valeur = 0;
    Text score_text; 

    // Start is called before the first frame update
    void Start()
    {
        score_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score : " + score_valeur;
    }
}
