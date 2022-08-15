using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.Movement;
using System;
using Sekamar.SpaceShooter.Message;

namespace Sekamar.SpaceShooter.Module.InputControl
{
    public class InputController : ObjectController<InputController, InputView>
    {
        public void Init()
        {
            _view.OnLeftPressed += OnLeftPressed;
            _view.OnRightPressed += OnRightPressed;
        }

        private void OnLeftPressed()
        {
            Publish<InputMessage>(new InputMessage(-1));
            Debug.Log("a;slkdfhyiopsdyg");
        }
        private void OnRightPressed()
        {
            Publish<InputMessage>(new InputMessage(1));
        }

        public override void SetView(InputView view)
        {
            base.SetView(view);
            Init();
        }

    }
}
