using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Character
{
    public class MovementComponent : MonoBehaviour
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public UI_Script playerStats;
        private GameObject Lever;
        public LeverFunctionality lever;
        bool leverInRange = false;

        [SerializeField] private float WalkSpeed;
        [SerializeField] private float RunSpeed;
        [SerializeField] private float JumpForce;

        private Vector2 InputVector = Vector2.zero;
        private Vector3 MoveDirection = Vector3.zero;

        //Comp
        private Animator PlayerAnimator;
        private PlayerController PlayerController;
        private Rigidbody PlayerRigidbody;


        //Reference 
        private Transform PlayerTransform;


        //Animator Hashes
        private readonly int MovementXHash = Animator.StringToHash("MovementX");
        private readonly int MovementZHash = Animator.StringToHash("MovementZ");
        private readonly int IsRunningHash = Animator.StringToHash("IsRunning");
        private readonly int IsJumpingHash = Animator.StringToHash("IsJumping");

        private void Start()
        {
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            playerStats.SetMaxHealth(MaxHealth);
        }

        private void Awake()
        {
            PlayerController = GetComponent<PlayerController>();
            PlayerAnimator = GetComponent<Animator>();
            PlayerRigidbody = GetComponent<Rigidbody>();

            PlayerTransform = transform;
        }

        private void Update()
        {
            if (PlayerController.IsJumping) return;

            if (!(InputVector.magnitude > 0)) MoveDirection = Vector3.zero;

            MoveDirection = PlayerTransform.forward * InputVector.y + PlayerTransform.right * InputVector.x;

            float currentSpeed = PlayerController.IsRunning ? RunSpeed : WalkSpeed;

            Vector3 movementDirection = MoveDirection * (currentSpeed * Time.deltaTime);

            PlayerTransform.position += movementDirection;
        }

        public void OnMovement(InputValue value)
        {
            InputVector = value.Get<Vector2>();

            PlayerAnimator.SetFloat(MovementXHash, InputVector.x);
            PlayerAnimator.SetFloat(MovementZHash, InputVector.y);
        }

        public void OnRun(InputValue button)
        {
            PlayerController.IsRunning = button.isPressed;
            PlayerAnimator.SetBool(IsRunningHash, button.isPressed);
        }

        public void OnJump(InputValue button)
        {
            if (!PlayerController.IsJumping)
            {
                PlayerController.IsJumping = true;
                PlayerAnimator.SetBool(IsJumpingHash, true);

                PlayerRigidbody.AddForce((transform.up + MoveDirection) * JumpForce, ForceMode.Impulse);
            }
        }
        public void OnGainHealth(InputValue button)
        {
            Debug.Log("Gain Health");

            playerStats.SetHealth(20);
            playerStats.setMoney(20);
            lever.isLeverUp = false;

        }

        public void OnTakeDamage(InputValue button)
        {
            Debug.Log("Taking Damage");

            playerStats.SetHealth(-20);
            playerStats.setMoney(-20);
            lever.isLeverUp = true;

        }

        public void OnAction(InputValue button)
        {
            float distance = Vector3.Distance(lever.transform.position, transform.position);
            if(distance <= 2)
            {
                if (lever.isLeverUp == false)
                    lever.isLeverUp = true;
                else
                    lever.isLeverUp = false;
            }
        }

        public void OnPause(InputValue button)
        {
            if (!GameManager.Instance.CursorActive)
            {
                AppEvents.Invoke_OnMouseCursorEnable(true);
            }
            SceneManager.LoadScene("MainMenu");

        }


        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Ground") && !PlayerController.IsJumping) return;

            PlayerController.IsJumping = false;
            PlayerAnimator.SetBool(IsJumpingHash, false);

            //if (other.gameObject.CompareTag("Lever"))
            //{
            //    leverInRange = true;
            //    Lever = other.gameObject;
            //    Debug.Log(Lever);
            //}
            //else leverInRange = false;
        }
    }
}
