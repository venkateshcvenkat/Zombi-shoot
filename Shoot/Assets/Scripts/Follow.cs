using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    
    public NavMeshAgent agent;
    public GameObject target;
    public Transform spawnpoint;
    public float range=5f;
    public float hitted = 1;
    public AudioSource aliengunsound;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
       
    }

    
    void Update()
    {
       
        agent.SetDestination(target.transform.position);
        transform.LookAt(target.transform.position);
        Debug.DrawRay(spawnpoint.transform.position, spawnpoint.transform.forward * range, Color.red);
        
        RaycastHit hit;
        if (Physics.Raycast(spawnpoint.transform.position, spawnpoint.transform.forward, out hit, range))
        {
            
            if (hit.transform.CompareTag("Player"))
            {
                aliengunsound.Play();
                Debug.Log("killed");
                hit.transform.gameObject.GetComponent<hitplayer>().attack(hitted);
            }
           
        }
    }

   
   
}
