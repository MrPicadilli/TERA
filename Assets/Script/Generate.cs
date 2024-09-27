using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    private float delay = 3.0f;
    private float timeCurrent = 0.0f;
    public GameObject mur;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCurrent + delay < Time.fixedTime)
        {
            var temp = Instantiate(mur, new Vector3(Random.Range(0, 15), 2, -40.0f), transform.rotation);
            temp.transform.localScale = new Vector3(Random.Range(3, 12), 5, 1);
            Destroy(temp, 6);
            timeCurrent = Time.fixedTime;
        }

    }
}
