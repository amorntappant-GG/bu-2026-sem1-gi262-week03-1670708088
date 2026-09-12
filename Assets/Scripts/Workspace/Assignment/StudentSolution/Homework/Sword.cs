using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash()
        {
            Debug.Log(name + " slashes with the sword!");
        }

        public override void Equip(Player player)
        {
            Debug.Log(player.name + " equipped sword " + name);
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log(name + " slashed " + target.name +
                      " for " + attackPower + " damage");
        }
    }
}