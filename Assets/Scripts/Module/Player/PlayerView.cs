using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Player { 
    public class PlayerView : BaseView
    {
        public event System.Action OnCollideWithDammager;
        
        public int hp;
        void Update()
        {
        
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Collide with " + collision.name);
            OnCollideWithDammager?.Invoke();
        }
    }
}
