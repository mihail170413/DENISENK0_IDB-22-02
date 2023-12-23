using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCounterScript : MonoBehaviour
{


    public CollisionScript SphereCollider;
    public Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Счетчик столкновений: " + SphereCollider.collisionCounter;
    }
}
