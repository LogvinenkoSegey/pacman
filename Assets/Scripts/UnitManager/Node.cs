using System.Collections.Generic;
using UnityEngine;

namespace UnitManager
{
    public class Node : MonoBehaviour
    {
        public LayerMask obstacleLayer;
        public List<Vector2> availableDirections { get; private set; }

        private void Start()
        {
            this.availableDirections = new List<Vector2>();

            AddDirectionIfAvailable(Vector2.up);
            AddDirectionIfAvailable(Vector2.down);
            AddDirectionIfAvailable(Vector2.left);
            AddDirectionIfAvailable(Vector2.right);
        }

        private void AddDirectionIfAvailable(Vector2 direction)
        {
            RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.5f, 0.0f, direction, 1f, this.obstacleLayer);

            if (hit.collider == null)
                this.availableDirections.Add(direction);
        }
    }
}
