using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OGame.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 50f;
        public void JumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}
