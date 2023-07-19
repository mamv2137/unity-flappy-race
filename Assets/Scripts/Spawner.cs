
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabs;

    public float spawnRate = 1f;

    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable() {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable() {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn() {
        GameObject pipes = Instantiate(prefabs, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        //this.transform.position + new Vector3(0, Random.Range(this.minHeight, this.maxHeight), 0);
    }
}
