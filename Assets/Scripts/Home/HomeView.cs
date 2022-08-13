using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sekamar.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _leaderboardButton;

        public void SetCallbacks(UnityAction onClickPlayButton, UnityAction onClickLeaderboardButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _leaderboardButton.onClick.RemoveAllListeners();

            _playButton.onClick.AddListener(onClickPlayButton);
            _leaderboardButton.onClick.AddListener(onClickLeaderboardButton);
        }

        
    }
}