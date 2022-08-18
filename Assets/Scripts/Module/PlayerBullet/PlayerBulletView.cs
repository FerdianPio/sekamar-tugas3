using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerBullet
{
    public class PlayerBulletView : BaseView
    {
        public System.Action onPlayerBulletFlying;

        //Update is called once per frame
        void Update()
        {
            onPlayerBulletFlying?.Invoke();
        }
    }
}