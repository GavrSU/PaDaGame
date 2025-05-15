using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NAWMSHEcontrol : MonoBehaviour
{
    public NavMeshSurface surefase;
    // Start is called before the first frame update
    void Start()
    {
      Invoke("Updatesurfase",1);
    }

    // Update is called once per frame
    void Updatesurfase()
    {
      surefase.BuildNavMesh();
    }
}
