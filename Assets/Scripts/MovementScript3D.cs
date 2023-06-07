using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript3D : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    private Camera mainCamera;
    private Animator playerAnimator;

    [SerializeField] private float turnSmoothTime;
    [SerializeField] private AudioSource walkAudioSource;
    public float MoveSpeed = 2f;
    private float targetAngle;
    private float angle;
    private float turnSmoothVelocity;
    private bool walkSoundPlays;
    
    private void Awake()
    {
        mainCamera = Camera.main;
        MyRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();

        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        Vector2 movementInput;

        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        /*
        playerAnimator.SetFloat("BlendX", movementInput.x);
        playerAnimator.SetFloat("BlendY", movementInput.y);
        */
        if (movementInput.magnitude == 0)
        {
            return;
        }
        SetRotation(movementInput);

        if (!walkAudioSource.isPlaying)
        {
            walkAudioSource.Play();
        }

        Move(movementInput);
    }

    private void SetRotation(Vector2 direction)
    {
        targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;
        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }

    private void Move(Vector2 movementInput)
    {
        Vector3 newVelocity = MyRigidbody.velocity;
        newVelocity = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        newVelocity *= MoveSpeed;
        newVelocity.y = MyRigidbody.velocity.y;
        MyRigidbody.velocity = newVelocity;
        /*
        newVelocity = CalculateHorizontalMovement(newVelocity, movementInput);
        
        newVelocity.y = MyRigidbody.velocity.y;

        MyRigidbody.velocity = newVelocity;

        if (newVelocity.magnitude > 0)
        {
            transform.forward = GetCameraForward();
        
        }
    }

    private Vector3 CalculateHorizontalMovement(Vector3 newVelocity, Vector2 movementInput)
    {
        //Berechnung
        Vector3 forwardDirection = movementInput.y * GetCameraForward();
        Vector3 sidewardDirection = movementInput.x * GetCameraSideward();

        Vector3 generalDirection = forwardDirection + sidewardDirection;
        generalDirection = generalDirection.normalized;

        newVelocity = generalDirection * MoveSpeed;

        return newVelocity;
    }

    public Vector3 GetCameraForward()
    {
        Vector3 cameraForward = mainCamera.transform.forward;
        return cameraForward;
    }

    public Vector3 GetCameraSideward()
    {
        Vector3 cameraSidewards = mainCamera.transform.right;
        return cameraSidewards;
    }

    private Vector3 GetPlaneDirection(Vector3 vector)
    {
        vector.y = 0f;
        vector = vector.normalized;
        return vector;
        */
    }
}
