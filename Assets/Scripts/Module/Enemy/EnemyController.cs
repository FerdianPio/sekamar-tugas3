using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sekamar.SpaceShooter.Module.Movement;
using System;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyView>
    {
        MovementController movement;
        
        public void Init()
        {
            _view.OnGameUpdate += OnGameUpdate;            
            Debug.Log("Nothing "+_view.name);
        }

        private void OnGameUpdate()
        {
            movement.SetDirection(1);
        }

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            Init();
        }
    }

}
