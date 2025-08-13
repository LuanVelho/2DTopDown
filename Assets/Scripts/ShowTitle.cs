using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowTitle : MonoBehaviour
{
    public float velocidade = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0)
        {
            transform.position += new Vector3(0, velocidade * Time.deltaTime, 0);
        }

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
