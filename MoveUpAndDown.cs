using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 2.0f;

    private float startingY;

    void Start()
    {
        startingY = transform.position.y;
    }

    void Update()
    {
        float newY = startingY + Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
