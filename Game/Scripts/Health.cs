using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public GameObject explosionEffectPrefab;
    public float CurrentHp = 100;
    public float MaxHp = 100;


    public void PlusHp(float PlHp) {
        CurrentHp = CurrentHp + PlHp;
        if (CurrentHp > MaxHp) {
            CurrentHp = MaxHp;
        }
        UpdateHealthBar();
    }
    public void MinusHp(float MinHp) {
        CurrentHp = CurrentHp - MinHp;
        if (CurrentHp <= 0)
        {
            CurrentHp = 0;
            if (transform.tag == "Enemy")
            {
                Destroy(gameObject);
                if (explosionEffectPrefab != null)
                {
                    Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);
                }
            }
            if (transform.tag == "Player")
            {
                SceneManager.LoadScene("menu");
            }
    
        }
        UpdateHealthBar();
    }
    void UpdateHealthBar(){
        if(gameObject.GetComponent<HealthBar>()!=null){
            gameObject.GetComponent<HealthBar>().UpdateHealthBar();
        }
         if(gameObject.GetComponent<enemyHpBar>()!=null){
            gameObject.GetComponent<enemyHpBar>().UpdateHealthBar();
        }
    }
    void Start()
    {
      PlusHp(49);
      MaxHp=110;
      PlusHp(5);
    }
}
