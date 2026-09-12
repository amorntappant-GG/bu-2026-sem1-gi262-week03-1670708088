using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items;

        public void CollectItem(Item item)
        {
            Debug.Log(name + " collected " + item.name);
        }

        private void LevelUp()
        {
            Debug.Log(name + " Level Up!");
        }
    }
}