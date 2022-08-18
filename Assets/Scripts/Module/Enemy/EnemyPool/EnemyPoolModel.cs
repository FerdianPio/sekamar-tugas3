using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.EnemyPool
{
    public class EnemyPoolModel : BaseModel, IEnemyPoolModel
    {
        public bool IsPlaying { get; private set; } = false;

        public int PoolSize { get; private set; } = 55;

        public Vector3 SpawnPoint { get; private set; } = new Vector3();

        public float SpawnGap { get; private set; } = 4f;

        public Vector3 Position { get; private set; } = new Vector3(1.5f, 0.5f, 10f);

        public int Width {get; private set;}

        public int Height {get; private set;}

        public Vector3 DespawnPosition { get; private set; } = new Vector3(-.2f, -0.5f, 10f);

        public Queue<GameObject> EnemyPool = new Queue<GameObject>();

        public Dictionary<Vector2, GameObject> _tiles = new Dictionary<Vector2, GameObject>();

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
            SetDataAsDirty();
        }

        public void SetWidth(int width)
        {
            Width = width;
            SetDataAsDirty();
        }

        public void SetHeight(int height)
        {
            Height = height;
            SetDataAsDirty();
        }

        public void SetDespawnPosition(Vector3 despawnPosition)
        {
            DespawnPosition = despawnPosition;
            SetDataAsDirty();
        }

        public void MoveSpawnPoint()
        {
            SpawnPoint += Vector3.right * SpawnGap;
            SetDataAsDirty();
        }

        public void EnqueueEnemy(GameObject enemy)
        {
            EnemyPool.Enqueue(enemy);
            SetDataAsDirty();
        }

        public GameObject DequeueEnemy()
        {
            return EnemyPool.Dequeue();
        }

        public GameObject GetObstacleInFront()
        {
            return EnemyPool.Peek();
        }
    }
}