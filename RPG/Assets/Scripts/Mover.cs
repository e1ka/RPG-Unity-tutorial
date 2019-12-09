using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MoveToCursor();
        //GetComponent<NavMeshAgent>().destination = target.position;
    }

    private void MoveToCursor()
    {
        Ray lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        bool hasHit = Physics.Raycast(lastRay, out hitInfo);
        if (hasHit)
            GetComponent<NavMeshAgent>().destination = hitInfo.point;
    }
}
