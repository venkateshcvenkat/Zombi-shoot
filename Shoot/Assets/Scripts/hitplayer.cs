using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitplayer : MonoBehaviour
{
    public float playerhealth = 30f;
    public GameObject gameover;
    public float currenthealth;
    
    public Image healthbar;
    private void Start()
    {
        gameover.SetActive(false);
        currenthealth = playerhealth;
        
    }
    private void Update()
    {
        updatehealthbar();
    }
    public void attack(float amount)
    {
        playerhealth -= amount;
        if (playerhealth <= 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }
    public void updatehealthbar()
    {
        healthbar.fillAmount = playerhealth/currenthealth;
    }
}
