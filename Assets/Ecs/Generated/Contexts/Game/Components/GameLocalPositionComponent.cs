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
	public Ecs.Game.Components.GlobalComponents.LocalPositionComponent LocalPosition { get { return (Ecs.Game.Components.GlobalComponents.LocalPositionComponent)GetComponent(GameComponentsLookup.LocalPosition); } }
	public bool HasLocalPosition { get { return HasComponent(GameComponentsLookup.LocalPosition); } }

	public void AddLocalPosition(UnityEngine.Vector3 newValue)
	{
		var index = GameComponentsLookup.LocalPosition;
		var component = (Ecs.Game.Components.GlobalComponents.LocalPositionComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.LocalPositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceLocalPosition(UnityEngine.Vector3 newValue)
	{
		var index = GameComponentsLookup.LocalPosition;
		var component = (Ecs.Game.Components.GlobalComponents.LocalPositionComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.LocalPositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyLocalPositionTo(Ecs.Game.Components.GlobalComponents.LocalPositionComponent copyComponent)
	{
		var index = GameComponentsLookup.LocalPosition;
		var component = (Ecs.Game.Components.GlobalComponents.LocalPositionComponent)CreateComponent(index, typeof(Ecs.Game.Components.GlobalComponents.LocalPositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveLocalPosition()
	{
		RemoveComponent(GameComponentsLookup.LocalPosition);
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
public partial class GameEntity : ILocalPositionEntity { }

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
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherLocalPosition;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> LocalPosition
	{
		get
		{
			if (_matcherLocalPosition == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.LocalPosition);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherLocalPosition = matcher;
			}

			return _matcherLocalPosition;
		}
	}
}
