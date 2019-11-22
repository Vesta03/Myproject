using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    // Start is called before the first frame update

    public float timer;
    public GameObject Customer;
         

    void Start()
    {
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Destroy(Customer);
        }
    }
}
