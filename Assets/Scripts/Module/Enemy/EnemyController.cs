using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, EnemyView>
    {
        public void Init()
        {
            _view.OnShot += Onshot;
        }

        private void Onshot()
        {
            _view.gameObject.SetActive(false);
            Debug.Log(_model._point);
        }
        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            Init();
        }
    }

}
