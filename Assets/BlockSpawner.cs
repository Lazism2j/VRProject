using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject _normal;
    [SerializeField] GameObject _dual;
    [SerializeField] GameObject _unit;
    [SerializeField] GameObject _four;
    [SerializeField] Transform _spawnPosition;
    [SerializeField] float _rotateSpeed;
    private List<GameObject> _blocks = new List<GameObject>();

    private void Awake()
    {
        _blocks.Add(_normal);
        _blocks.Add(_dual);
        _blocks.Add(_unit);
        _blocks.Add(_four);
    }

    public void BlockSpawn()
    {
        int ran = Random.Range(0, _blocks.Count);
        _blocks[ran].transform.position = _spawnPosition.position;
        Instantiate(_blocks[ran]);
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(Vector3.up, _rotateSpeed, Space.World);
    }
}
