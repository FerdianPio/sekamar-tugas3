using Agate.MVC.Base;
using Agate.MVC.Core;
using Sekamar.Boot;
using Sekamar.SpaceShooter.Module.Attack;
using Sekamar.SpaceShooter.Module.Enemy;
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
        private AttackController _attackController;
        private MovementController _movementController;
        private EnemyController _enemyController;
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
                new AttackController(),
                new EnemyController()};
        }

        protected override IEnumerator InitSceneObject()
        {
            _inputController.SetView(_view.inputView);
            _movementController.SetView(_view.movementView);
            _attackController.SetView(_view.attackView);
            _enemyController.SetView(_view.enemyView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}