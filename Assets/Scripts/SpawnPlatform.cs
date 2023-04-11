using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject[] _platformPrefabs;
    [SerializeField] private float _yOffset;

    private float? _lastPosY = null;

    private void Start()
    {
        //Spawn();
    }

    public void Spawn()
    {
        Transform randomPointSpawn = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

        float spawnPosY = _lastPosY == null ? randomPointSpawn.position.y : (float)_lastPosY + _yOffset; // если _lastPosY == null, то равно randomPointSpawn.position.y, иначе равно (float)_lastPosY + _yOffset

        randomPointSpawn.position = new Vector3(randomPointSpawn.position.x, spawnPosY, randomPointSpawn.position.z);
        _lastPosY = spawnPosY;

        GameObject randomPlatformPrefab = _platformPrefabs[Random.Range(0, _platformPrefabs.Length)];
        Instantiate(randomPlatformPrefab, randomPointSpawn.position, Quaternion.identity);
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Spawn();
        };
    }
}
