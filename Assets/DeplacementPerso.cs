using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPerso : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pas = 0.01f;
        if(Input.GetKey("g")) {
            transform.position += new Vector3(0,0,-pas);
        }
        if(Input.GetKey("b")) {
            transform.position += new Vector3(0,0,pas);
        }
        if(Input.GetKey("v")) {
            transform.position += new Vector3(pas,0,0);
        }
        if(Input.GetKey("n")) {
            transform.position += new Vector3(-pas,0,0);
        }
    }
}
