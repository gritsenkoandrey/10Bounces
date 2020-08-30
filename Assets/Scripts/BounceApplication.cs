using Assets.Scripts;
using UnityEngine;


/// <summary>
/// 10 Bounces Entry Point.
/// </summary>
public class BounceApplication : MonoBehaviour
{
    // Reference to the root instances of the MVC.
    public BounceModel model;
    public BounceView view;
    public BounceController controller;

    /// <summary>
    /// Init things here
    /// </summary>
    private void Start()
    {
    }
}