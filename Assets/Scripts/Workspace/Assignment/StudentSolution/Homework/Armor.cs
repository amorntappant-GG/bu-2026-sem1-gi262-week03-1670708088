using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Armor : Equipment
    {
        public int defense;

        public override void Equip(Player player)
        {
            Debug.Log(player.name + " equipped " + name +
                      " (Defense: " + defense + ")");
        }
    }
}