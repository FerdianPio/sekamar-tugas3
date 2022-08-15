using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Sekamar.SpaceShooter.Module.Movement
{
    public class MovementModel : BaseModel
    {
        public float _speed { get; private set; }

        public void SetSpeed(float speed)
        {
            _speed = speed;
            SetDataAsDirty();
        }
    }

}
