﻿using System;
using System.Collections.Generic;
using Android.Runtime;

namespace AndroidX.ConstraintLayout.Motion.Widget
{
	public partial class MotionLayout
	{
        public virtual void OnNestedScrollAccepted (Android.Views.View child, Android.Views.View target, int axes, int @type)
        {
            Android.Views.ScrollAxis scroll_axes = (Android.Views.ScrollAxis) axes;

            OnNestedScrollAccepted (child, target, scroll_axes, @type);

            return;
        }

		public void OnNestedScrollAccepted(Android.Views.View child, Android.Views.View target, int axes)
		{
			Android.Views.ScrollAxis scroll_axes = (Android.Views.ScrollAxis) axes;

			OnStartNestedScroll(child, target, scroll_axes);

			return;
		}

        public virtual bool OnStartNestedScroll (Android.Views.View child, Android.Views.View target, int axes, int @type)
        {
            Android.Views.ScrollAxis scroll_axes = (Android.Views.ScrollAxis) axes;

            return OnStartNestedScroll (child, target, scroll_axes, @type);
        }

		public virtual bool OnStartNestedScroll (Android.Views.View child, Android.Views.View target, int axes)
		{
			Android.Views.ScrollAxis scroll_axes = (Android.Views.ScrollAxis) axes;

			return OnStartNestedScroll(child, target, scroll_axes);
		}
	}
}
