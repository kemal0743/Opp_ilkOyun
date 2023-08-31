using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OGame.Controlers 
{
    public class EnamyControlers : MonoBehaviour
    {

       private float maxLifeTime = 7f;
        private float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;
            if(_currentTime > maxLifeTime) 
            {
            
                Destroy(this.gameObject);
            
            }
        }
    }
}

