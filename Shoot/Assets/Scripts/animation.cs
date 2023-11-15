using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation : MonoBehaviour
{
    public Animator anim;
    public bool grounded = false;
    public GameObject DieAfter;
    public GameObject Rawimage;
    public GameObject image; 
    public GameObject alert;
    public GameObject hint;

    void Start()
    {
    
        //anim.enabled = false;
        DieAfter.SetActive(false);
        image.SetActive(false);   
        alert.SetActive(false);
        hint.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            anim.enabled = true;
            grounded = true;
            Debug.Log("Enemy_Entered");
            image.SetActive(true);
            alert.SetActive(true);
            hint.SetActive(true);
            Destroy(alert, 5f);
        }
    }

    public void animstop()
    {
        //anim.enabled = false;
        Rawimage.SetActive(false);
        DieAfter.SetActive(true);
       
    }

    public void anistart()
    {
        anim.enabled = true;
        DieAfter.SetActive(false);
        Rawimage.SetActive(true);
    }
}
