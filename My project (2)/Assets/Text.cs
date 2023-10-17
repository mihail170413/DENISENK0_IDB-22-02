using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterScript : MonoBehaviour
{
    public Text CounterText;
    public Scr cubescr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CounterText.text = "k: " + cubescr.k;
    }
}
