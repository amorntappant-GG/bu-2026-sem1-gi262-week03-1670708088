using UnityEngine;

namespace Assignment.StudentSolution
{
    public class RangeEnemy : Enemy
    {
        public int range;

        public override void Attack(Entity target)
        {
            Debug.Log(name + " performs a ranged attack on " + target.name);
        }
    }
}