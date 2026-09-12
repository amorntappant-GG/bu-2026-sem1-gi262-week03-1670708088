using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack(Entity target)
        {
            Debug.Log(name + " attacks " + target.name);
        }

        protected virtual void Patrol()
        {
            Debug.Log(name + " is patrolling.");
        }
    }
}