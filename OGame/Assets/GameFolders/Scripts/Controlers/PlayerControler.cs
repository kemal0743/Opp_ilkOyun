using OGame.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OGame.Controlers 
{
    public class Player : MonoBehaviour
    {
        
        Rigidbody2D _rigidboydy2D;
        bool _isLeftMouseClick;
        Jump _jump;
        PcinputControler _input;
        void Start()
        {

            _jump = GetComponent<Jump>();
            _rigidboydy2D = GetComponent<Rigidbody2D>();
            _input = new PcinputControler();
        }

        // Update is called once per frame
        void Update()
        {
            if (_input.LeftMouseClickDown) 
            {
               _isLeftMouseClick = true;
            

            }
        }
        private void FixedUpdate()
        {
            if(_isLeftMouseClick) 
            {
                _jump.JumpAction(_rigidboydy2D);
                _isLeftMouseClick = false;

            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
           GameManeger.instance.RestartGame();
        }
    }




}

