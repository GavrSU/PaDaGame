using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menulevels;
    public GameObject menusetings;
    public void playbutonup()
    {
        menulevels.SetActive(true);
    }
    public void eixtbutonup()
    {
        menulevels.SetActive(false); 
    }
    public void nastroykibutonup()
    {
        menusetings.SetActive(true); 
    }
    public void nastroykibutonexit()
    {
        menusetings.SetActive(false); 
    }

    public void level1butonup()
    {
        SceneManager.LoadScene("lvl1");
    }
        public void level2butonup()
    {
        SceneManager.LoadScene("lvl2");
    }
        public void level3butonup()
    {
        SceneManager.LoadScene("lvl3");
    }
} 

