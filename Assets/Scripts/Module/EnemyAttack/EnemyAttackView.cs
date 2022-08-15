using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyAttack
{
    public class EnemyAttackView : BaseView
    {
        [SerializeField] private Transform _enemy;
        [SerializeField] private GameObject _enemyBullet;

        public void SpawnEnemyBullet(int trigger)
        {
            if (trigger == 0)
            {
                Debug.Log("Attack");
                Instantiate(_enemyBullet, new Vector3(_enemy.transform.position.x, _enemy.transform.position.y - 2, _enemy.transform.position.z), Quaternion.identity);
            }
        }
    }
}