using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Sekamar.SpaceShooter.Module.EnemyAttack
{
    public class EnemyAttackView : BaseView
    {
        // Akan dihapus ketika sudah ganti spawn jadi publish message object dari pool
        [SerializeField] private GameObject _enemyBullet;

        //public event System.Action onEnemyShoot;
        public System.Action onPreparingToShoot;

        private void Start()
        {
            onPreparingToShoot?.Invoke();
        }

        private void Update()
        {
            onPreparingToShoot?.Invoke();
        }

        public void SpawnEnemyBullet()
        {
            // Akan diganti Publish message untuk object dari pool
            Instantiate(_enemyBullet, transform.position, Quaternion.identity);   
        }
    }
}