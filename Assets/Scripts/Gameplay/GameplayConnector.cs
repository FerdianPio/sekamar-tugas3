using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using Sekamar.SpaceShooter.Message;
using Sekamar.SpaceShooter.Module.PlayerAttack;
using Sekamar.SpaceShooter.Module.EnemyAttack;
using Sekamar.SpaceShooter.Module.Score;

namespace Sekamar.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        //private InputController _inputController;
        private MovementController _movementController;
        private BulletContainerController _bulletContainerController;
        private ScoreController _scoreController;

        public void OnMessageReceived(InputMessage message)
        {
            if (message._inputValue != 0) _movementController.SetDirection(message._inputValue);
            else _bulletContainerController.CreateInstanceObject();
        }
        /*public void OnPlayerAttacked(InputMessage message)
        {
            _bulletContainerController.CreateInstanceObject();
        }*/
        public void OnScoreUpdated(UpdateScoreMessage message)
        {
            _scoreController.SetScore(message._scoreValue);
        }
        protected override void Connect()
        {
            Subscribe<InputMessage>(OnMessageReceived);
            Subscribe<UpdateScoreMessage>(OnScoreUpdated);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMessage>(OnMessageReceived);
            Unsubscribe<UpdateScoreMessage>(OnScoreUpdated);
        }
    }

}
