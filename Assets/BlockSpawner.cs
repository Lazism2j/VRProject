using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject _block;
    [SerializeField] Transform _spawnPosition;
    [SerializeField] float _rotateSpeed;

    public void BlockSpawn()
    {
        _block.transform.position = _spawnPosition.position;
        Instantiate(_block);
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(Vector3.up, _rotateSpeed, Space.World);
    }
}
