using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerBullet
{
    public class PlayerBulletController : ObjectController<PlayerBulletController, PlayerBulletModel, PlayerBulletView>
    {
        public void Init()
        {
            _model.SetSpeed(2);
            _view.onPlayerBulletFlying += OnPlayerBulletFlying;
        }

        public override void SetView(PlayerBulletView view)
        {
            base.SetView(view);
            Init();
        }

        void OnPlayerBulletFlying()
        {
            _view.transform.Translate(_model.Speed * Time.deltaTime * Vector3.up);
        }
    }
}