using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Sekamar.SpaceShooter.Module.GridSystem
{
    public class GridSystemView : BaseView
    {
        [SerializeField] 
        private int _width, _height;
        [SerializeField] 
        private GameObject _tilePrefab;

        private Dictionary<Vector2, GameObject> _tiles;

        void Start()
        {
            GenerateGrid();
        }

        void GenerateGrid()
        {
            _tiles = new Dictionary<Vector2, GameObject>();
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y, 10), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    
                    _tiles[new Vector2(x, y)] = spawnedTile;
                }
            }

            foreach(GameObject _o in _tiles.Values)
            {
                _o.transform.position -= new Vector3(_width / 2, _height / 4);
                //Debug.Log(_o.transform.position);
            }
        }

       
    }

}
