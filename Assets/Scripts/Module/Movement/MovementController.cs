using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Sekamar.SpaceShooter.Module.Movement
{
    public class MovementController : ObjectController<MovementController, MovementModel, MovementView>
    {
        public int _direction { get; private set; }

        public void SetDirection(int _dir)
        {
            _direction = _dir;
            _view.Move(_direction);
        }
    }

}
