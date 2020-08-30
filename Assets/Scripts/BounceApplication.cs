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

    /// <summary>
    /// Iterates all Controllers and delegates the notification data
    /// This method can easily be found because every class is 
    /// "BounceElement" and has an "app" instance.
    /// </summary>
    public void Nitify(string pEventPath, Object pTarget, params object[] pData)
    {
        controller.OnNotification(pEventPath, pTarget, pData);

        //BounceController[] controllerList = GetAllControllers();
        //foreach (var controller in controllerList)
        //{
        //    controller.OnNotification(pEventPath, pTarget, pData);
        //}
    }

    /// <summary>
    /// Fetches all scene Controllers.
    /// </summary>
    //public BounceController[] GetAllControllers()
    //{
    //    return new BounceController[0];
    //}
}