using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Item
    {
        public string name;
        public int value;

        public virtual void Use(Player player)
        {
            Debug.Log(player.name + " used " + name);
        }
    }
}