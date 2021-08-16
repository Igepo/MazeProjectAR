using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour
{
    public GameObject objectRotate;
    public float rotateSpeed = 50f;
    bool rotateStatus = false;
    
    public void ScaleOn(){
        objectRotate.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Rotasi(){
        if (rotateStatus == false){
            rotateStatus = true;
        }
        else{
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true){
            objectRotate.transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        }
    }
}
