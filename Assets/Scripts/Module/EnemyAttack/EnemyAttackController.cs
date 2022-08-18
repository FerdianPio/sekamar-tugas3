using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyAttack
{
    public class EnemyAttackController : ObjectController<EnemyAttackController, EnemyAttackModel, EnemyAttackView>
    {
        public void Init()
        {
            _view.onPreparingToShoot += OnPreparingToShoot;
            _model.SetInterval(2);
        }

        public void OnPreparingToShoot()
        {
            _model.SetRunTime(Time.deltaTime);
            Debug.Log(_model.RunTime);
            if (_model.RunTime >= _model.Interval)
            {
                _view.SpawnEnemyBullet();
                _model.SetRunTimeToZero();
            }
        }

        public override void SetView(EnemyAttackView view)
        {
            base.SetView(view);
            Init();
        }
    }
}