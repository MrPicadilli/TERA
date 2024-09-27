using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public GameObject ethan;
   // public bool 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float pas = 0.05f;
        if(Input.GetKey("z")) {
            transform.position += new Vector3(0,0,-pas);
        }
        if(Input.GetKey("s")) {
            transform.position += new Vector3(0,0,pas);
        }
        if(Input.GetKey("q")) {
            transform.position += new Vector3(pas,0,0);
        }
        if(Input.GetKey("d")) {
            transform.position += new Vector3(-pas,0,0);
        }
        if(Input.GetKey("r")) {
            Vector3 newRot = new Vector3(0f, 15f, 0f);
            //transform.rotation = Quaternion.Euler(newRot);
        }
        if(Input.GetKey("f")) {
            Vector3 newRot = new Vector3(0f, -15f, 0f);
            //transform.rotation = Quaternion.Euler(newRot);
        }
        if(Input.GetKey("e")) {
            transform.position = ethan.transform.position + new Vector3(0,1.7f,1f);
        }
    }
}

