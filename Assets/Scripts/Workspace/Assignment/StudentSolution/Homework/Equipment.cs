using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Equipment : Item
    {
        public virtual void Equip(Player player)
        {
            Debug.Log(player.name + " equipped " + name);
        }
    }
}