using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
	public class EnemyPoolContainerController : ObjectController<EnemyPoolContainerController, EnemyPoolContainerView>
	{
		public void CreateInstanceObject()
		{
			EnemyPoolModel instanceModel = new EnemyPoolModel();
			GameObject instanceObject = GameObject.Instantiate(Resources.Load<GameObject>(@"Prefabs/Bullet"), Vector3.zero, Quaternion.identity);
			EnemyPoolView instanceView = instanceObject.GetComponent<EnemyPoolView>();
			EnemyPoolController instance = new EnemyPoolController();
			InjectDependencies(instance);
			instance.Init(instanceModel, instanceView);
		}
	}
}