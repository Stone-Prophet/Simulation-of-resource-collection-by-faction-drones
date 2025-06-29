//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity
{
	public VelocityListenerComponent VelocityListener { get { return (VelocityListenerComponent)GetComponent(GameComponentsLookup.VelocityListener); } }
	public bool HasVelocityListener { get { return HasComponent(GameComponentsLookup.VelocityListener); } }

	public void AddVelocityListener()
	{
		var index = GameComponentsLookup.VelocityListener;
		var component = (VelocityListenerComponent)CreateComponent(index, typeof(VelocityListenerComponent));
		AddComponent(index, component);
	}

	public void ReplaceVelocityListener()
	{
		ReplaceComponent(GameComponentsLookup.VelocityListener, VelocityListener);
	}

	public void RemoveVelocityListener()
	{
		RemoveComponent(GameComponentsLookup.VelocityListener);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherVelocityListener;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> VelocityListener
	{
		get
		{
			if (_matcherVelocityListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.VelocityListener);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherVelocityListener = matcher;
			}

			return _matcherVelocityListener;
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity
{
	public System.IDisposable SubscribeVelocity(OnGameVelocity value, bool invokeOnSubscribe = true)
	{
		var componentListener = HasVelocityListener
			? VelocityListener
			: (VelocityListenerComponent)CreateComponent(GameComponentsLookup.VelocityListener, typeof(VelocityListenerComponent));
		componentListener.Delegate += value;
		ReplaceComponent(GameComponentsLookup.VelocityListener, componentListener);
		if(invokeOnSubscribe && HasComponent(GameComponentsLookup.Velocity))
		{
			var component = Velocity;
			value(this, component.Value);
		}

		return new JCMG.EntitasRedux.Events.EventDisposable<OnGameVelocity>(CreationIndex, value, UnsubscribeVelocity);
	}

	private void UnsubscribeVelocity(int creationIndex, OnGameVelocity value)
	{
		if(!IsEnabled || CreationIndex != creationIndex)
			return;

		var index = GameComponentsLookup.VelocityListener;
		var component = VelocityListener;
		component.Delegate -= value;
		if (VelocityListener.IsEmpty)
		{
			RemoveComponent(index);
		}
		else
		{
			ReplaceComponent(index, component);
		}
	}
}
