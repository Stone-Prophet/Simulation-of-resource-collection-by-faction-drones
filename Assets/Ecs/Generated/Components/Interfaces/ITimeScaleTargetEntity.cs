//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface ITimeScaleTargetEntity
{
	Ecs.Scheduler.Components.TimeScaleTargetComponent TimeScaleTarget { get; }
	bool HasTimeScaleTarget { get; }

	void AddTimeScaleTarget(Ecs.Managers.Uid newValue);
	void ReplaceTimeScaleTarget(Ecs.Managers.Uid newValue);
	void RemoveTimeScaleTarget();
}
