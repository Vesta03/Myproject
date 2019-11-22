using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clsnentr : MonoBehaviour
{
    public time Customer;
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.transform.name == "Plate")
        {
            Destroy(Customer);
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
