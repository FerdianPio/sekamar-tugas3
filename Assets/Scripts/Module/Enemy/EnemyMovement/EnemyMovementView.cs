using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyMovementView : BaseView
    {
        public float _speed;

        public void Move(int _direction)
        {
            transform.Translate(_direction * _speed * Time.deltaTime, 0f, 0);
        }
        
        
    }

}
