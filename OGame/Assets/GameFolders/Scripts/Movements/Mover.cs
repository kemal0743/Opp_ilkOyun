using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OGame.Movements 
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 1f;
        Rigidbody2D _rigidbody2D;


        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>(); 
        }
        private void Start()
        {
            //_rigidbody2D.velocity = Vector3.left * _moveSpeed;
        }
        private void Update()
        {
            _rigidbody2D.velocity = Vector3.left * _moveSpeed;
        }
    }
    
}

