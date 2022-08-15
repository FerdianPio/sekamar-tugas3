using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Message;

namespace Sekamar.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private InputController _inputController;
        private MovementController _movementController;

        public void OnMessageReceived(InputMessage message)
        {
            _movementController.SetDirection(message._inputValue);
        }
        protected override void Connect()
        {
            Subscribe<InputMessage>(OnMessageReceived);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMessage>(OnMessageReceived);
        }
    }

}
