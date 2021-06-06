using UnityEngine;
using UnityEngine.InputSystem;

namespace Controller {
    public class PlayerController : MonoBehaviour {
        private Vector2 _direction = Vector2.zero;
        private float _speed = 2.0f;

        private void Update() {
            transform.Translate(_direction * (_speed * Time.deltaTime));
        }

        public void OnMovement(InputValue value) {
            _direction = value.Get<Vector2>();
        }
    }
}