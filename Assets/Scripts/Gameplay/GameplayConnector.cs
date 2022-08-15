using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Message;
using Sekamar.SpaceShooter.Module.PlayerAttack;
using Sekamar.SpaceShooter.Module.EnemyAttack;

namespace Sekamar.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private InputController _inputController;
        private MovementController _movementController;
        private PlayerAttackController _playerAttackController;
        private EnemyAttackController _enemyAttackController;

        public void OnMessageReceived(InputMessage message)
        {
            _movementController.SetDirection(message._inputValue);
        }
        public void OnPlayerAttacked(InputMessage message)
        {
            _playerAttackController.VerifySpawn(message._inputValue);
        }
        public void OnEnemyAttacked(InputMessage message)
        {
            _enemyAttackController.VerifySpawn(message._inputValue);
        }
        protected override void Connect()
        {
            Subscribe<InputMessage>(OnMessageReceived);
            Subscribe<InputMessage>(OnPlayerAttacked);
            Subscribe<InputMessage>(OnEnemyAttacked);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMessage>(OnMessageReceived);
            Unsubscribe<InputMessage>(OnPlayerAttacked);
            Unsubscribe<InputMessage>(OnEnemyAttacked);
        }
    }

}
