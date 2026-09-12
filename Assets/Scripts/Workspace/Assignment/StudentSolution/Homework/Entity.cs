using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health;

        public virtual void Update()
        {
            Debug.Log(name + " Update");
        }

        protected virtual void TakeDamage(int damage)
        {
            health -= damage;

            Debug.Log(name + " takes " + damage + " damage. HP = " + health);
        }

        private void Move(Vector3 direction)
        {
            position += direction;

            Debug.Log(name + " moves to " + position);
        }
    }
}