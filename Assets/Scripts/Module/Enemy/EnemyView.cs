using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyView : BaseView
    {
        public event System.Action OnShot;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnShot?.Invoke();
        }
    }

}
