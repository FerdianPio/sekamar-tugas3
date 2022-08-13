using Agate.MVC.Base;
using Agate.MVC.Core;
using Sekamar.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}