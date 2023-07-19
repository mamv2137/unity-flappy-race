using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    public float leftEdge;

    private void Start() {
        // leftEdge = -Camera.main.orthographicSize * Camera.main.aspect - 1f;
        // leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 1f;
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update() {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
