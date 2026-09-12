using UnityEngine;

namespace Assignment.StudentSolution
{
    public class MeleeEnemy : Enemy
    {
        public int strength;

        public override void Attack(Entity target)
        {
            Debug.Log(name + " performs a melee attack on " + target.name);
        }
    }
}