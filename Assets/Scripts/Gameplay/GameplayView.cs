using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public InputController InputController;
    }
}