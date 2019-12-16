using RPG.Combat;
using RPG.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 5f;
        GameObject player;
        Fighter fighter;
        Health health;
        void Start()
        {
            fighter = GetComponent<Fighter>();
            player = GameObject.FindWithTag("Player");
            health = GetComponent<Health>();
        }

        void Update()
        {
            if (health.IsDead()) return;
            if (DistanceToPlayer()<chaseDistance && fighter.CanAttack(player))
            {
                 fighter.Attack(player);
            }
            else
            {
                fighter.Cancel();
            }
        }
        private float DistanceToPlayer()
        {
            return Vector3.Distance(transform.position, player.transform.position);
        }
    }
}