using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 100;
    private Rigidbody Playerrigidbody;

    private GameObject focalPoint;
    private bool hasPowerUp = false;
    private float powerUpStrength = 5;
    public GameObject powerupIndicator;
    void Start()
    {
        powerupIndicator = GameObject.Find("Powerup Indicator");
        Playerrigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        powerupIndicator.gameObject.SetActive(false);
    }

    void Update()
    {
        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);
        float forwardInput = Input.GetAxis("Vertical");
        Playerrigidbody.AddForce(focalPoint.transform.forward * forwardInput * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            hasPowerUp = true;
            powerupIndicator.gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 NormalOfColision = collision.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(NormalOfColision * powerUpStrength, ForceMode.Impulse);

            StartCoroutine(nameof(PowerupCountdownRoutine));
        }
    }
    private IEnumerator PowerupCountdownRoutine() 
    {
        yield return new WaitForSeconds(5);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
