using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NAWMSHEcontrol : MonoBehaviour
{
    
    public NavMeshSurface surefase;
    public  static NAWMSHEcontrol instante;
    // Start is called before the first frame update
    void Start()
    {
      instante = this;  
      Invoke("Updatesurfase",1);
    }

    // Update is called once per frame
     public void Updatesurfase()
    {
      surefase.BuildNavMesh();
    }
}
