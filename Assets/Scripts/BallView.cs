namespace Assets.Scripts
{
    /// <summary>
    /// Describes the Ball view and its features.
    /// </summary>
    public class BallView : BounceElement
    {
        /// <summary>
        /// Only this is necessary. Physics is doing the rest of work.
        /// Callback called upon collision.
        /// </summary>
        private void OnCollisionEnter()
        {
            //Application.controller.OnBallGroundHit();
            Application.Nitify(BounceNotification.BallHitGround, this);
        }
    }
}