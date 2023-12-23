using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject sphere;

    public void ButtonPressed()
    {
        if (sphere.active == false)
        {
            sphere.SetActive(true);
        }
        else sphere.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
}
