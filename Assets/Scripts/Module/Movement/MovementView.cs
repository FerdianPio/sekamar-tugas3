using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Sekamar.SpaceShooter.Module.Movement
{
    public class MovementView : BaseView
    {
        public float _speed;

        public void Move(int _direction)
        {
            transform.Translate(_direction * _speed * Time.deltaTime, 0f, 0);
        }
    }

}
