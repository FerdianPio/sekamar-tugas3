using Agate.MVC.Base;
using Agate.MVC.Core;
using Sekamar.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.Leaderboard
{
    public class LeaderboardLauncher : SceneLauncher<LeaderboardLauncher, LeaderboardView>
    {
        public override string SceneName => "Leaderboard";

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