using UnityEngine;

namespace UnitManager
{
    public class Passage : MonoBehaviour
    {
        public Transform connection;

        private void OnTriggerEnter2D(Collider2D unit)
        {
            Vector3 position = unit.transform.position;
            position.x = this.connection.position.x;
            position.y = this.connection.position.y;
            unit.transform.position = position;
        }
    }
}