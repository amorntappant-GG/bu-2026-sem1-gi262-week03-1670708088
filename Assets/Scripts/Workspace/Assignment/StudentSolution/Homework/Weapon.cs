using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower;

        public virtual void DealDamage(Entity target)
        {
            Debug.Log(name + " dealt " + attackPower +
                      " damage to " + target.name);
        }
    }
}