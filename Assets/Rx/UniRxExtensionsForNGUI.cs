﻿using UnityEngine;
using System;

namespace UniRx.Triggers
{
	public static class UniRxExtensionsForNGUI
	{
		public static IObservable<Unit> OnSubmitAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnSubmitAsObservable();
		}

		public static IObservable<Unit> OnClickAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnClickAsObservable();
		}

		public static IObservable<Unit> OnDoubleClickAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDoubleClickAsObservable();
		}

		public static IObservable<bool> OnHoverAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnHoverAsObservable();
		}

		//public static IObservable<bool> OnPressAsObservable(this GameObject gameObject)
		//{
		//	if (gameObject == null) return Observable.Empty<bool>();
		//	return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnPressAsObservable();
		//}

		public static IObservable<Unit> OnPressAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnPressAsObservable();
		}

		public static IObservable<Unit> OnPressingAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			ObservableNGUIEventTrigger observableNGUIEventTrigger = GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject);

			return observableNGUIEventTrigger.OnPressAsObservable()
			.SelectMany(_ => observableNGUIEventTrigger.UpdateAsObservable())
			.TakeUntil(observableNGUIEventTrigger.OnReleaseAsObservable())
			.RepeatUntilDestroy(observableNGUIEventTrigger);
		}

		public static IObservable<Unit> OnReleaseAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnReleaseAsObservable();
		}

		public static IObservable<bool> OnSelectAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnSelectAsObservable();
		}

		public static IObservable<float> OnScrollAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<float>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnScrollAsObservable();
		}

		public static IObservable<Unit> OnDragStartAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDragStartAsObservable();
		}

		public static IObservable<Vector2> OnDragAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Vector2>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDragAsObservable();
		}

		public static IObservable<Unit> OnDragOverAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDragOverAsObservable();
		}

		public static IObservable<Unit> OnDragOutAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDragOutAsObservable();
		}

		public static IObservable<Unit> OnDragEndAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDragEndAsObservable();
		}

		public static IObservable<GameObject> OnDropAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<GameObject>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnDropAsObservable();
		}

		public static IObservable<KeyCode> OnKeyAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<KeyCode>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnKeyAsObservable();
		}

		public static IObservable<bool> OnTooltipAsObservable(this GameObject gameObject)
		{
			if (gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(gameObject).OnTooltipAsObservable();
		}

		public static IObservable<Unit> OnSubmitAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnSubmitAsObservable();
		}

		public static IObservable<Unit> OnClickAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnClickAsObservable();
		}

		public static IObservable<Unit> OnDoubleClickAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDoubleClickAsObservable();
		}

		public static IObservable<bool> OnHoverAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnHoverAsObservable();
		}

		//public static IObservable<bool> OnPressAsObservable(this Component component)
		//{
		//	if (component == null || component.gameObject == null) return Observable.Empty<bool>();
		//	return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnPressAsObservable();
		//}

		public static IObservable<Unit> OnPressAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnPressAsObservable();
		}

		public static IObservable<Unit> OnPressingAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			ObservableNGUIEventTrigger observableNGUIEventTrigger = GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject);

			return observableNGUIEventTrigger.OnPressAsObservable()
			.SelectMany(_ => observableNGUIEventTrigger.UpdateAsObservable())
			.TakeUntil(observableNGUIEventTrigger.OnReleaseAsObservable())
			.RepeatUntilDestroy(observableNGUIEventTrigger);
		}

		public static IObservable<Unit> OnReleaseAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnReleaseAsObservable();
		}

		public static IObservable<bool> OnSelectAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnSelectAsObservable();
		}

		public static IObservable<float> OnScrollAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<float>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnScrollAsObservable();
		}

		public static IObservable<Unit> OnDragStartAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDragStartAsObservable();
		}

		public static IObservable<Vector2> OnDragAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Vector2>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDragAsObservable();
		}

		public static IObservable<Unit> OnDragOverAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDragOverAsObservable();
		}

		public static IObservable<Unit> OnDragOutAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDragOutAsObservable();
		}

		public static IObservable<Unit> OnDragEndAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<Unit>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDragEndAsObservable();
		}

		public static IObservable<GameObject> OnDropAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<GameObject>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnDropAsObservable();
		}

		public static IObservable<KeyCode> OnKeyAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<KeyCode>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnKeyAsObservable();
		}

		public static IObservable<bool> OnTooltipAsObservable(this Component component)
		{
			if (component == null || component.gameObject == null) return Observable.Empty<bool>();
			return GetOrAddComponent<ObservableNGUIEventTrigger>(component.gameObject).OnTooltipAsObservable();
		}

		static T GetOrAddComponent<T>(GameObject gameObject)
			where T : Component
		{
			var component = gameObject.GetComponent<T>();
			if (component == null)
			{
				component = gameObject.AddComponent<T>();
			}

			return component;
		}
	}
}