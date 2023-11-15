using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float Damage = 10f;
    public float range = 500f;
    public Camera Fpscamera;
    public AudioSource audiosource;
    public GameObject blood;
    public ParticleSystem effect;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        Debug.DrawRay(Fpscamera.transform.position, Fpscamera.transform.forward * range, Color.red);
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(Fpscamera.transform.position, Fpscamera.transform.forward, out hit, range))
        {
            Debug.Log("hit");
           
            if (hit.transform.CompareTag("Enemy"))
            {
                Debug.Log("enemy");
                hit.transform.gameObject.GetComponent<enemy>().Takedamage(Damage);
                Instantiate(blood, hit.point, Quaternion.identity);
            }

        }
        audiosource.Play();
        effect.Play();
    }
}
