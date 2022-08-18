using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Sekamar.SpaceShooter.Module.PlayerAttack
{
    public class BulletContainerController : ObjectController<BulletContainerController, BulletContainerView>
    {
		public void CreateInstanceObject()
		{
			BulletModel instanceModel = new BulletModel();
			GameObject instanceObject = GameObject.Instantiate(_view._bulletPrefab, _view.transform.position, Quaternion.identity);
			BulletView instanceView = instanceObject.GetComponent<BulletView>();
			BulletController instance = new BulletController();
			InjectDependencies(instance);
			instance.Init(instanceModel, instanceView);
		}

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();

			/*BulletContainerView prefab = Resources.Load<BulletContainerView>(@"Prefabs/Bullet");
			BulletContainerView bullet = GameObject.Instantiate<BulletContainerView>(prefab);
			SetView(bullet);*/
        }
    }

}
