using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePorte : MonoBehaviour
{
    private float delay = 3.0f;
    private float timeCurrent = 0.0f;
    public GameObject mur;
    public int largeur = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCurrent + delay < Time.fixedTime)
        {
            int rand = Random.Range(-10, 10);
            var right = Instantiate(mur, new Vector3((rand + largeur), 2, -40.0f), transform.rotation);
            var left = Instantiate(mur, new Vector3((rand - mur.transform.localScale.x), 2, -40.0f), transform.rotation);
            Destroy(right, 6);
            Destroy(left, 6);
            timeCurrent = Time.fixedTime;
        }
    }
}
