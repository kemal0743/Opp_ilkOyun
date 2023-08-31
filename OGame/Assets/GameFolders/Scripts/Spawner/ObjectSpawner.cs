using OGame.Controlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OGame.Spawner 
{

    public class NewBehaviourScript : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f,1.5f)]
        [SerializeField] float minSpawnTime = 1f;

        [SerializeField] EnamyControlers[] _enamies;

        float _currentSpawnTime;
        float _timeBoundary;

        private void Awake()
        {
            ResetTimes();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            if(_currentSpawnTime > _timeBoundary) 
            {
                Debug.Log("k");
                Spawner();
              
                ResetTimes();
            
            }
        }

        private void Spawner()
        {
           

        }

        private void ResetTimes() 
        {

            _currentSpawnTime = 0;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);

        }
    }

}

