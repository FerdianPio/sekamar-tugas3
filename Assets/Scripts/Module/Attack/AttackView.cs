using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Attack
{
    public class AttackView : BaseView
    {
        [SerializeField] private GameObject bullet;
        Vector2 spawnLoc = new Vector2 (3,3);

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Debug.Log("Attack");
            //    Instantiate(bullet);
            //}
        }

        public void SpawnBullet()
        {
            Debug.Log("Attack");
            Instantiate(bullet, spawnLoc, Quaternion.identity);
        }
    }
}