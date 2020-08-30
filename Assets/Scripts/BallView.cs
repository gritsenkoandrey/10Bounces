namespace Assets.Scripts
{
    public sealed class BallView : BounceElement
    {
        /// <summary>
        /// Only this is necessary. Physics is doing the rest of work.
        /// Callback called upon collision.
        /// </summary>
        private void OnCollisionEnter()
        {
            Application.controller.OnBallGroundHit();
        }
    }
}