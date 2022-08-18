using Agate.MVC.Base;
using Agate.MVC.Core;
using Sekamar.Boot;
using Sekamar.SpaceShooter.Module.EnemyAttack;
using Sekamar.SpaceShooter.Module.PlayerAttack;
using Sekamar.SpaceShooter.Module.InputControl;
using Sekamar.SpaceShooter.Module.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sekamar.SpaceShooter.Module.Player;
using Sekamar.SpaceShooter.Module.Enemy;
using Sekamar.SpaceShooter.Module.Score;

namespace Sekamar.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private InputController _inputController;
        private PlayerController _playerController;
        private BulletContainerController _bulletContainerController;
        private MovementController _movementController;
        private EnemyController _enemyController;
        private ScoreController _scoreController;
        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] { 
                new GameplayConnector()};
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] { 
                new InputController(),
                new MovementController(),
                new BulletContainerController(),
                new PlayerController(),
                new EnemyController(),
                //new EnemyAttackController(),
                new ScoreController(),
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _playerController.SetView(_view.playerView);
            _inputController.SetView(_view.inputView);
            _movementController.SetView(_view.movementView);
            _bulletContainerController.SetView(_view.bulletContainer);
            _enemyController.SetView(_view.enemyView);
            //_enemyAttackController.SetView(_view.enemyAttackView);
            _scoreController.SetView(_view.scoreView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}