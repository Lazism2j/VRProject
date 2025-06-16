using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject _block;
    [SerializeField] Transform _spawnPosition;

    public void BlockSpawn()
    {
        _block.transform.position = _spawnPosition.position;
        Instantiate(_block);
    }

}
