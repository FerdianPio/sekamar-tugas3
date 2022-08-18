using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
    public class BulletView : BaseView
    {
        public event System.Action OnBulletSpawn;

        void Update()
        {
            OnBulletSpawn?.Invoke();
        }
    }

}
