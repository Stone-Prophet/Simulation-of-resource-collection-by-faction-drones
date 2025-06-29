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
	public Ecs.Game.Components.GlobalComponents.ScaleComponent Scale { get { return (Ecs.Game.Components.GlobalComponents.ScaleComponent)GetComponent(GameComponentsLookup.Scale); } }
	public bool HasScale { get { return HasComponent(GameComponentsLookup.Scale); } }

	public void AddScale(UnityEngine.Vector3 newValue)
	{
		var index = GameComponentsLookup.Scale;
		var component = (Ecs.Game.Components.GlobalComponents.ScaleComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.ScaleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceScale(UnityEngine.Vector3 newValue)
	{
		var index = GameComponentsLookup.Scale;
		var component = (Ecs.Game.Components.GlobalComponents.ScaleComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.ScaleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyScaleTo(Ecs.Game.Components.GlobalComponents.ScaleComponent copyComponent)
	{
		var index = GameComponentsLookup.Scale;
		var component = (Ecs.Game.Components.GlobalComponents.ScaleComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.ScaleComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveScale()
	{
		RemoveComponent(GameComponentsLookup.Scale);
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
public partial class GameEntity : IScaleEntity { }

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
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherScale;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> Scale
	{
		get
		{
			if (_matcherScale == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.Scale);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherScale = matcher;
			}

			return _matcherScale;
		}
	}
}
