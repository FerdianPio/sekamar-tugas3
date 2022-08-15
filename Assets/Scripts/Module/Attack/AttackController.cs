using Agate.MVC.Base;
using Sekamar.SpaceShooter.Module.InputControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Attack
{
    public class AttackController : ObjectController<AttackController, AttackView>
    {
        [SerializeField] private InputController inputController;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    OnAttack(_view);
            //}
        }

        public override void SetView(AttackView view)
        {
            base.SetView(view);
            Debug.Log("Tes");
            view.SpawnBullet();
            Debug.Log("Done");
        }

        //public void OnAttack(AttackView view)
        //{
        //    view.SpawnBullet();
        //    Debug.Log("Done");
        //}
    }
}