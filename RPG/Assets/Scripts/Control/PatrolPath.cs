using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {
        const float gizmosRadius = .2f;
        private void OnDrawGizmos()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                int j = GetNextIndex(i);
                Gizmos.DrawSphere(GetWayPoint(i), gizmosRadius);
                Gizmos.DrawLine(GetWayPoint(i), GetWayPoint(j));
            }
        }

        public  int GetNextIndex(int i)
        {
            //if(i < transform.childCount - 1)
            //{
            //    return i + 1;
            //}
            //else
            //{
            //    return 0;
            //}
            if (i + 1 == transform.childCount)
            {
                return 0;
            }
            else
            {
                return i + 1; 
            }
        }

        public Vector3 GetWayPoint(int i)
        {
            return transform.GetChild(i).position;
        }
    }
}
