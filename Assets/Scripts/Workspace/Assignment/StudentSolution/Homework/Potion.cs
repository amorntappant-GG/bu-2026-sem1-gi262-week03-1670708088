using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount;

        public override void Use(Player player)
        {
            Debug.Log(player.name + " used " + name +
                      " and healed " + healingAmount + " HP");
        }
    }
}