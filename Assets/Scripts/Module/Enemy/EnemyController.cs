using Agate.MVC.Base;
using Sekamar.SpaceShooter.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, EnemyView>
    {
        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
            _view.OnShot += Onshot;
            _model.SetPoint(100);
        }

        private void Onshot()
        {
            _view.gameObject.SetActive(false);
            Debug.Log(_model._point);
            //publish dapet score
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model._point));
        }
        // public override void SetView(EnemyView view)
        // {
        //     base.SetView(view);
        //     _view.OnShot += Onshot;
        // }
    }

}
