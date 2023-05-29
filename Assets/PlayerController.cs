using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;

    private CharacterController myCharacterController;

    private void Awake()
    {
        myCharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myCharacterController.Move(transform.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myCharacterController.Move(-transform.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }


    }
}
