using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject _normalYellow;
    [SerializeField] GameObject _dualYellow;
    [SerializeField] GameObject _unitYellow;
    [SerializeField] GameObject _fourYellow;
    [SerializeField] GameObject _normalBlue;
    [SerializeField] GameObject _dualBlue;
    [SerializeField] GameObject _unitBlue;
    [SerializeField] GameObject _fourBlue;
    [SerializeField] GameObject _normalRed;
    [SerializeField] GameObject _dualRed;
    [SerializeField] GameObject _unitRed;
    [SerializeField] GameObject _fourRed;
    [SerializeField] GameObject _normalGreen;
    [SerializeField] GameObject _dualGreen;
    [SerializeField] GameObject _unitGreen;
    [SerializeField] GameObject _fourGreen;
    [SerializeField] Transform _spawnPosition;
    [SerializeField] float _rotateSpeed;
    private List<GameObject> _blocks = new List<GameObject>();

    private void Awake()
    {
        _blocks.Add(_normalYellow);
        _blocks.Add(_dualYellow);
        _blocks.Add(_unitYellow);
        _blocks.Add(_fourYellow);
        _blocks.Add(_normalRed);
        _blocks.Add(_dualRed);
        _blocks.Add(_unitRed);
        _blocks.Add(_fourRed);
        _blocks.Add(_normalBlue);
        _blocks.Add(_dualBlue);
        _blocks.Add(_unitBlue);
        _blocks.Add(_fourBlue);
        _blocks.Add(_normalGreen);
        _blocks.Add(_dualGreen);
        _blocks.Add(_unitGreen);
        _blocks.Add(_fourGreen);
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
