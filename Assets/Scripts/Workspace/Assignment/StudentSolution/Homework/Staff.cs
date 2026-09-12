using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public void CastSpell()
        {
            Debug.Log(name + " casts a magic spell!");
        }

        public override void Equip(Player player)
        {
            Debug.Log(player.name + " equipped staff " + name);
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log(name + " casts magic at " + target.name +
                      " for " + attackPower + " damage");
        }
    }
}