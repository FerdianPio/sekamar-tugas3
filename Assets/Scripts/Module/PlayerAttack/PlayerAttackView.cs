using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
    public class PlayerAttackView : BaseView
    {
        [SerializeField] private Transform _player;
        [SerializeField] private GameObject _playerBullet;

        public void SpawnPlayerBullet(int trigger)
        {
            if (trigger == 0)
            {
                Debug.Log("Attack");
                Instantiate(_playerBullet, new Vector3(_player.transform.position.x, _player.transform.position.y + 2, _player.transform.position.z), Quaternion.identity);
            }
        }
    }
}