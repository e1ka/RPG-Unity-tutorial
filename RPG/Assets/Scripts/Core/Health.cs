using UnityEngine;

namespace RPG.Core
{
    class Health : MonoBehaviour 
    {
        [SerializeField] float health = 100f;

        bool isDead = false;

        public void TakeDamage(float damage)
        {
            if (isDead) return;
            health = Mathf.Max(health - damage, 0);
            print(health);
            if (health == 0)
            {
                isDead = true;
                Die(); 
            }
        }
        public void Die()
        {
            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
        }
        public bool IsDead()
        {
            return isDead;
        }
    }
}
