using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour
{

    #region Variables
    int scoreToGiveAtClick = 1;
    protected GameObject target = null;
    protected SphereSetUp setup;
	protected Rigidbody _rigidbody = null;
	#endregion

	#region Methods

	public void Start()
    {
        setup = this.gameObject.GetComponentInParent<SphereSetUp>();

        target = setup.gameObject;

		_rigidbody = target.GetComponent<Rigidbody>();
	}
    
    protected virtual void OnMouseDown()
    {

		GameManager.Instance.scoreManager.UpdateScoreAccumulator(this.setup, scoreToGiveAtClick);

        Destroy();
    }

    public void Destroy()
    {
        this.target.BroadcastMessage("Explode");
        Destroy(this.target);
    }
    #endregion
}
