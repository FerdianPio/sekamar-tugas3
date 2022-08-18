using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyMovementView : BaseView
    {
        public event System.Action OnGamePlay;
        public float _speed;

        private void Update()
        {
            OnGamePlay?.Invoke();
        }
        public void Move(Vector2 _direction)
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
        
        
    }

}
