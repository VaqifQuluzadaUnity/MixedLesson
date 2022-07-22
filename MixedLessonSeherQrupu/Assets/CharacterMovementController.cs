using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
  [SerializeField] private Animator playerAnimator;
    void Update()
    {
    float verticalInput = Input.GetAxis("Vertical");

    playerAnimator.SetFloat("Input", verticalInput);
    }
}
