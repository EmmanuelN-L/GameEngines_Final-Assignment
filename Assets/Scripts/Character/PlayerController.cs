using UnityEngine;

namespace Character
{
    public class PlayerController : MonoBehaviour
    {
        public CrosshairScript CrossHair => CrosshairComponent;
        [SerializeField] private CrosshairScript CrosshairComponent;

        public bool IsFiring = false;
        public bool IsReloading;
        public bool IsJumping;
        public bool IsRunning;
    }
}
