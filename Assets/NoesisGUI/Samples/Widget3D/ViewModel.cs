using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

public class ViewModel : MonoBehaviour, INotifyPropertyChanged
{
    public Light redLight;
    public Light greenLight;

    public bool RedLightOn
    {
        get { return redLight.enabled; }
        set { redLight.enabled = value; }
    }

    public float RedLightIntensity
    {
        get { return redLight.intensity; }
        set { redLight.intensity = value; }
    }

    public bool GreenLightOn
    {
        get { return greenLight.enabled; }
        set { greenLight.enabled = value;  }
    }

    public float GreenLightIntensity
    {
        get { return greenLight.intensity; }
        set { greenLight.intensity = value; }
    }

    private void Start()
    {
        NoesisView view = GetComponent<NoesisView>();
        view.Content.DataContext = this;
    }

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
	}


	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		GreenLightOn = !greenLight.enabled;
		OnPropertyChanged("GreenLightOn");
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void OnPropertyChanged(string name)
	{
		var handler = PropertyChanged;
		if (handler != null)
		{
			handler(this, new PropertyChangedEventArgs(name));
		}
	}
}
