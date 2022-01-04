using Manager;
using UnityEngine;

namespace Units
{
    public class Pellet : MonoBehaviour
    {
        public int points = 10;

        protected virtual void Eat()
        {
            FindObjectOfType<GameManager>().PelletEaten(this);
        }

        private void OnTriggerEnter2D(Collider2D unit)
        {
            if (unit.gameObject.layer == LayerMask.NameToLayer("Pacman"))
                Eat();
        }
    }
}