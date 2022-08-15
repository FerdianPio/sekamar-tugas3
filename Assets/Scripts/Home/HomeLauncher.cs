using Agate.MVC.Base;
using Agate.MVC.Core;
using Sekamar.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.Home
{
    public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
    {
        public override string SceneName => "Home";

        //protected override ILoad GetLoader()
        //{
        //    throw new System.NotImplementedException();
        //}

        //protected override IMain GetMain()
        //{
        //    throw new System.NotImplementedException();
        //}

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        //protected override ISplash GetSplash()
        //{
        //    throw new System.NotImplementedException();
        //}

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickPlayButton, OnClickLeaderboardButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }

        private void OnClickLeaderboardButton()
        {
            SceneLoader.Instance.LoadScene("Leaderboard");
        }
    }
}