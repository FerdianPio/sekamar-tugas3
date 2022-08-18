using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Message;
using Sekamar.SpaceShooter.Module.Enemy;
using Sekamar.SpaceShooter.Module.GridSystem;

namespace Sekamar.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private InputController _inputController;
        private MovementController _movementController;
        private GridSystemController _gridSystemController;
        private EnemyMovementController _enemyMovementController;

        public void OnMessageReceived(InputMessage message)
        {
            _movementController.SetDirection(message._inputValue);
        }

        public void OnMessageReceived(EnemyMessage message)
        {
            _enemyMovementController.SwitchOnEdge(message._leftDown, message._rightUp);
            Debug.Log("message._MessageUpdate");
        }
        protected override void Connect()
        {
            Subscribe<InputMessage>(OnMessageReceived);
            Subscribe<EnemyMessage>(OnMessageReceived);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMessage>(OnMessageReceived);
            Unsubscribe<EnemyMessage>(OnMessageReceived);
        }
    }

}
