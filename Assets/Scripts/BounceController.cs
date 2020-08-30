using UnityEngine;


namespace Assets.Scripts
{
    /// <summary>
    /// Controls the app workflow.
    /// </summary>
    public sealed class BounceController : BounceElement
    {
        /// <summary>
        /// Handles the ball hit event.
        /// </summary>
        public void OnBallGroundHit()
        {
            Application.model.bounces++;
            Debug.Log($"Bounces {Application.model.bounces}");
            if (Application.model.bounces >= Application.model.winCondition)
            {
                Application.view.ball.enabled = false;
                // stops the ball
                Application.view.ball.GetComponent<Rigidbody>().isKinematic = true;
                OnGameComplete();
            }
        }
        private void OnGameComplete()
        {
            Debug.Log("Victory!");
        }
    }
}