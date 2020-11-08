using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public static PlayerMovement Instance;

    private Robot robot;

    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        robot = GetComponentInParent<Robot>();
    }

    private void FixedUpdate()
    {
        if (robot.dead)
            return;

        else
            MovePlayer();
    }

    private void MovePlayer()
    {
        transform.position = transform.position + Vector3.forward * speed;
    }

 
    public float getDistance()
    {
        var animatedRb = gameObject.transform.GetChild(0).GetComponent<Rigidbody>();

        return animatedRb.worldCenterOfMass.y - 1f;
    }
}
