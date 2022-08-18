using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, EnemyView>
    {
        EnemyMovementController movement;
        
        public void Init(EnemyModel enemyModel, EnemyView enemyView)
        {
            _model = enemyModel;
            _view.OnGameUpdate += OnGameUpdate;
            SetView(enemyView);
            Debug.Log("Nothing "+_view.name);
        }

        private void OnGameUpdate()
        {
            Debug.Log("Masuk ongameupdate");
            movement.SetDirection(1);
        }

        // public override void SetView(EnemyView view)
        // {
        //     base.SetView(view);
        //     Init();
        // }
    }

}
