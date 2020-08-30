using UnityEngine;


namespace Assets.Scripts
{
    /// <summary>
    /// Base class for all elements in this application.
    /// </summary>
    public class BounceElement : MonoBehaviour
    {
        /// <summary>
        /// // Gives access to the application and all instances.
        /// </summary>
        public BounceApplication Application { get { return Object.FindObjectOfType<BounceApplication>(); } }
    }
}