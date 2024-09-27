using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mur : MonoBehaviour
{
    public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //var otherPosn = transform.position;
        //transform.position = new Vector3(Random.Range(-15, 15), 2, -40.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
