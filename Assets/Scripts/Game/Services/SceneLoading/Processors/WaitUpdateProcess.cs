using System;
using PdUtils.SceneLoadingProcessor;
using PdUtils.SceneLoadingProcessor.Impls;
using UniRx;

namespace Game.Services.SceneLoading.Processors
{
	public class WaitUpdateProcess : Process, IProgressable
	{
		private readonly int _count;
		private readonly FrameCountType _type;

		private int _current;
		private IDisposable _disposable;

		public WaitUpdateProcess(int count, FrameCountType type = FrameCountType.Update)
		{
			_count = count;
			_type = type;
		}

		#region IProgressable Members

		public float Progress => _current / (float)_count;

		#endregion

		public override void Do(Action onComplete)
		{
			_disposable = EveryUpdateOfType(_type).Subscribe(_ =>
			{
				_current++;
				if (_current <= _count)
					return;

				_disposable.Dispose();
				onComplete();
			});
		}

		private static IObservable<long> EveryUpdateOfType(FrameCountType type)
		{
			switch (type)
			{
				case FrameCountType.Update:
					return Observable.EveryUpdate();
				case FrameCountType.FixedUpdate:
					return Observable.EveryFixedUpdate();
				case FrameCountType.EndOfFrame:
					return Observable.EveryEndOfFrame();
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}
	}
}