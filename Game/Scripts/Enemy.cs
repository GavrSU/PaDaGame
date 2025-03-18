using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour


{
    public string TargetTag;
    Transform target;
    NavMeshAgent myNavMesh;
    float x;
    float z;
    void Awake()
    {
        myNavMesh = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag(TargetTag).transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TargetTag);
    }

    // Update is called once per frame
    void Update()
    {
        ApplyTarget(target);
    }
    void ApplyTarget(Transform targetTrans){
        if(targetTrans != null)
        myNavMesh.SetDestination(targetTrans.position);
    }
}
