using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.PlayerBullet
{
    public class PlayerBulletModel : BaseModel
    {
        public float Speed { get; private set; } = 2f;

        public void SetSpeed(float speed)
        {
            Speed = speed;
            SetDataAsDirty();
        }
    }
}