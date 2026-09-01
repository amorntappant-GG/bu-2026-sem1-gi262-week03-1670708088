using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Move");
        }
        public void Trun()
        {
            Debug.Log("Trun");
        }

            
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...

            Car car1 = new Car();
            car1.Name = "Benz AMG";
            car1.Speed = 100.0f;

            Car car2 = new Car();
            car2.Name = "BM";

            car1.Move();
            car1.Trun ();


            // Student code ends HERE 
        }
    }
}
