using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bille : MonoBehaviour {
    public GameObject sol;
    public GameObject spawn;

    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
		
        if (transform.position.y < sol.transform.position.y - 10)
        {
            transform.position = spawn.transform.position;
            score.score_valeur += 1;
        }

        }
}
