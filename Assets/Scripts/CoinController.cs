using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [Range(0f, 100f)]
    public float speed = 100f;
    Vector3 rotation;

    void Update()
    {
        rotation = new Vector3(0, 0, speed);
        transform.Rotate(rotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.FindAnyObjectByType<GameManager>().AddPoints();
            Destroy(gameObject);
        }
    }
}
