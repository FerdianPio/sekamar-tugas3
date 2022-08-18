using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Player { 
    public class PlayerController : ObjectController<PlayerController,PlayerModel,PlayerView>
    {
        public void Init()
        {
            _model.setHp(_view.hp);
            _view.OnCollideWithDammager += OnCollideWithDammager;
        }

        private void OnCollideWithDammager()
        {
            _model.setHp(_model.hp - 1);
            Debug.Log(_model.hp);
        }
        public override void SetView(PlayerView view)
        {
            base.SetView(view);
            Init();
        }
    }
}
