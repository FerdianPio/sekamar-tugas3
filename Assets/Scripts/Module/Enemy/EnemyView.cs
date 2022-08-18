using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sekamar.SpaceShooter.Module.Movement;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyView : BaseView
    {
        public event System.Action OnGameUpdate;

        void Update()
        {
            OnGameUpdate?.Invoke();
        }
    }

}
