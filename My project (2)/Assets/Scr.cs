using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr : MonoBehaviour
{

   public int k = 10;
    public void OnCollisionEnter()
    {
        Debug.Log("1");
        k -= 1;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
