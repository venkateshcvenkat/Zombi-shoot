using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class multiple : MonoBehaviour
{
    public GameObject[] enemys;
    public GameObject Enemy;
    public int enemycount;
    public animation script;
    public GameObject Rawimage;
    public GameObject DieAfter;
    public GameObject win;
   
    void Start()
    {

         StartCoroutine(SpawnEnemy());
         win.SetActive(false);
       
    }
    private void Update()
    {
       

        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemys.Length==0)
        {
            Debug.Log("null");
            Rawimage.SetActive(false);
            DieAfter.SetActive(true);
            Debug.Log("You Win");
            win.SetActive(true);
        }
    }
    IEnumerator SpawnEnemy()
      {

          while (enemycount < 2)
          {
            
              Instantiate(Enemy,transform.position,transform.rotation);
             
              enemycount += 1;
            yield return new WaitForSeconds(1f);
        }
        

        
    }
   
}
