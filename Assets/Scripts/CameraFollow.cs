using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    public float followSpeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the position to go to based on the players position
        Vector3 posToGo = new Vector3(Player.transform.position.x,Player.transform.position.y,transform.position.z);
        //Lerp is used to smooth transition the camera position
        transform.position = Vector3.Lerp(transform.position, posToGo, followSpeed);
    }
}
