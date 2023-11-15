using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changegun : MonoBehaviour
{
    public GameObject Shortgun;
    public GameObject Ak47;
   
    void Start()
    {
        Shortgun.SetActive(false);
        Ak47.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Shortgun.SetActive(true);
            Ak47.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Ak47.SetActive(true);
            Shortgun.SetActive(false);
        }
    }
}
