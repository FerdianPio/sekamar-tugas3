using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace Sekamar.SpaceShooter.Module.Input
{
    public class InputController : ObjectController<InputController, InputView>
    {
        [SerializeField]
        private KeyCode _left, _right, _shoot;
    }
}
