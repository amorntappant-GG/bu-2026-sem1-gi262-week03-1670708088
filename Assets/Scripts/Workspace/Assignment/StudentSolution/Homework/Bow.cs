using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;

        public void Shoot()
        {
            Debug.Log(name + " shoots an arrow!");
        }

        public override void Equip(Player player)
        {
            Debug.Log(player.name + " equipped bow " + name);
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log(name + " shot " + target.name +
                      " for " + attackPower + " damage");
        }
    }
}