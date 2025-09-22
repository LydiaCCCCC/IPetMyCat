using UnityEngine;
using UnityEngine.SceneManagement;

public class HandMove : MonoBehaviour
{
    private Transform handTransform;
    private float moveSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        handTransform = GetComponent<Transform>();

    }
    void HandInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            handTransform.Translate(translation: Vector3.right * moveSpeed * Time.deltaTime);
        }
            if (Input.GetKey(KeyCode.A))
            {
                handTransform.Translate(translation: Vector3.left * moveSpeed * Time.deltaTime);
            }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "wiki")
        {
            if (SceneManager.GetActiveScene().name == "Home")
            {
                SceneManager.LoadScene("Nuclear");
            }

            if (SceneManager.GetActiveScene().name == "Nuclear")
            {
                SceneManager.LoadScene("Inferno");
            }

            if (SceneManager.GetActiveScene().name == "Post")
            {
                SceneManager.LoadScene("Inferno");
            }

            if (SceneManager.GetActiveScene().name == "Inferno")
            {
                SceneManager.LoadScene("Heaven");
            }

            if (SceneManager.GetActiveScene().name == "Heaven")
            {
                SceneManager.LoadScene("Home2");
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        HandInput();
    }
}
