using UnityEngine;


namespace Assets.Scripts
{
    /// <summary>
    /// Controls the app workflow.
    /// </summary>
    public class BounceController : BounceElement
    {
        /// <summary>
        /// Handles the ball hit event.
        /// </summary>
        //public void OnBallGroundHit()
        //{
        //    Application.model.bounces++;
        //    Debug.Log($"Bounces {Application.model.bounces}");
        //    if (Application.model.bounces >= Application.model.winCondition)
        //    {
        //        Application.view.ball.enabled = false;
        //        // stops the ball
        //        Application.view.ball.GetComponent<Rigidbody>().isKinematic = true;
        //        OnGameComplete();
        //    }
        //}

        //private void OnGameComplete()
        //{
        //    Debug.Log("Victory!");
        //}

        /// <summary>
        /// Handles the ball hit event
        /// </summary>
        public void OnNotification(string pEventPath, Object pTarget, params object[] pData)
        {
            if (pEventPath == BounceNotification.BallHitGround)
            {
                Application.model.bounces++;
                Debug.Log($"Bounce {Application.model.bounces}");
                if (Application.model.bounces >= Application.model.winCondition)
                {
                    Application.view.ball.enabled = false;
                    // stops the ball
                    Application.view.ball.GetComponent<Rigidbody>().isKinematic = true;
                    // Notify itself and other controllers possibly interested in the event
                    Application.Nitify(BounceNotification.GameComplete, this);
                }
            }
            else if (pEventPath == BounceNotification.GameComplete)
            {
                Debug.Log("Victory");
            }
        }
    }
}