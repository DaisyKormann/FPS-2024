using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController; //controla o movimento do jogador
    PlayerGravity playerGravity; // gerencia a gravidade de pulo
    Transform camTransform; //Referência à câmera para controlar a rotação.
    Weapon weapon; // Referência à arma para disparar.
    Vector3 direction; // armazenar as direções de movimento
    Vector2 camDirection; // armazenar rotação de câmera
    const float speed = 5; // velocidade de movimento do jogador
    float verticalRotation; // controle da rotação vertical da câmera
    bool shooting, crouching; // estados do jogador
    GameObject grenade; // prefab da granada
    Transform throwPoint; // ponto de onde a granada sera lançada
    float mouseSensitivity; // sensibilidade do mouse para a rotação da camera

    private void Awake()
    {
        // trava o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;

        // obtém o componente CharacterController anexado ao GameObject
        characterController = GetComponent<CharacterController>();
        // obtém o primeiro filho do GameObject
        camTransform = transform.GetChild(0).GetComponent<Transform>(); 


    }

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal"); 
        direction.z = Input.GetAxis("Vertical");
        camDirection.x = Input.GetAxis("Mouse X");
        camDirection.y = Input.GetAxis("Mouse Y");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ThrowGrenade();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            crouching = !crouching;
            Crouch();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shooting = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            shooting = false;
        }

        Movement();
        Rotation();
        Fire();
    }

    private void Movement()
    {
        float newSpeed = crouching ? speed / 2 : speed;
        Vector3 move = transform.right * direction.x + transform.forward * direction.z;
        characterController.Move(move * newSpeed * Time.deltaTime);
    }

    private void Rotation()
    {
        camDirection *= mouseSensitivity * Time.deltaTime;

        verticalRotation -= camDirection.y;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

        camTransform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        transform.Rotate(Vector3.up * camDirection.x);
    }

    private void Fire()
    {
        if (shooting)
        {
            weapon.Fire(crouching);
        }
    }

    private void Jump()
    {
        playerGravity.Jump();
    }

    private void Crouch()
    {
        if (crouching)
        {
            camTransform.localPosition = Vector3.zero;
        }
        else
        {
            camTransform.localPosition = new Vector3(0, 0.5f, 0);
        }
    }

    private void ThrowGrenade()
    {
        Rigidbody grenadeRb = Instantiate(grenade, throwPoint.position, camTransform.rotation).GetComponent<Rigidbody>();
        Vector3 throwForce = camTransform.forward * 10 + transform.up * 5;
        grenadeRb.AddForce(throwForce, ForceMode.Impulse);
        Destroy(grenadeRb.gameObject, 10);
    }
}

