using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{


    public int collisionCounter = 100;
    // Start is called before the first frame update

    public void OnCollisionEnter()
    {
        collisionCounter--;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
