using UnityEngine;

namespace RPG.Combat
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
        }
        public bool IsDead()
        {
            return isDead;
        }
    }
}
