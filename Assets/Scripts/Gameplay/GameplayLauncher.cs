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

namespace Sekamar.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private InputController _inputController;
        private PlayerAttackController _playerAttackController;
        private EnemyAttackController _enemyAttackController;
        private MovementController _movementController;
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
                new PlayerAttackController(),
                new EnemyAttackController()};
        }

        protected override IEnumerator InitSceneObject()
        {
            _inputController.SetView(_view.inputView);
            _movementController.SetView(_view.movementView);
            _playerAttackController.SetView(_view.playerAttackView);
            _enemyAttackController.SetView(_view.enemyAttackView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}