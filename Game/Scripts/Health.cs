using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHp=100;
    public float MaxHp=100;


    public void PlusHp(float PlHp){
        CurrentHp=CurrentHp+PlHp;
        if(CurrentHp>MaxHp){
            CurrentHp=MaxHp;
        }
        UpdateHealthBar();
    }
    public void MinusHp(float MinHp){
        CurrentHp=CurrentHp-MinHp;
        if(CurrentHp<0){
            CurrentHp=0;
        }
        UpdateHealthBar();
    }
    void UpdateHealthBar(){
        if(gameObject.GetComponent<HealthBar>()!=null){
            gameObject.GetComponent<HealthBar>().UpdateHealthBar();
        }
    }
    void Start()
    {
      PlusHp(49);
      MaxHp=110;
      PlusHp(5);
    }
}
