﻿using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Support.V17.Leanback.Widget
{
    public partial class BaseCardView
    {
        public override bool Selected {
            get { return base.Selected; }
            set { SetSelected (value); }
        }

        static Delegate cb_setSelected_Z;
#pragma warning disable 0169
        static Delegate GetSetSelected_ZHandler ()
        {
            if (cb_setSelected_Z == null)
                cb_setSelected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>)n_SetSelected_Z);
            return cb_setSelected_Z;
        }

        static void n_SetSelected_Z (IntPtr jnienv, IntPtr native__this, bool selected)
        {
            global::Android.Support.V17.Leanback.Widget.BaseCardView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V17.Leanback.Widget.BaseCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetSelected (selected);
        }
#pragma warning restore 0169

        static IntPtr id_setSelected_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='android.support.v17.leanback.widget']/class[@name='BaseCardView']/method[@name='setSelected' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register ("setSelected", "(Z)V", "GetSetSelected_ZHandler")]
        public unsafe void SetSelected (bool selected)
        {
            if (id_setSelected_Z == IntPtr.Zero)
                id_setSelected_Z = JNIEnv.GetMethodID (class_ref, "setSelected", "(Z)V");
            try {
                JValue* __args = stackalloc JValue [1];
                __args [0] = new JValue (selected);

                if (GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object)this).Handle, id_setSelected_Z, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelected", "(Z)V"), __args);
            } finally {
            }
        }


        public bool Activate {
            get { return base.Activated; }
            set { SetActivated (value); }
        }

        static Delegate cb_setActivated_Z;
#pragma warning disable 0169
        static Delegate GetSetActivated_ZHandler ()
        {
            if (cb_setActivated_Z == null)
                cb_setActivated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>)n_SetActivated_Z);
            return cb_setActivated_Z;
        }

        static void n_SetActivated_Z (IntPtr jnienv, IntPtr native__this, bool activated)
        {
            global::Android.Support.V17.Leanback.Widget.BaseCardView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V17.Leanback.Widget.BaseCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetActivated (activated);
        }
#pragma warning restore 0169

        static IntPtr id_setActivated_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='android.support.v17.leanback.widget']/class[@name='BaseCardView']/method[@name='setActivated' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register ("setActivated", "(Z)V", "GetSetActivated_ZHandler")]
        public unsafe void SetActivated (bool activated)
        {
            if (id_setActivated_Z == IntPtr.Zero)
                id_setActivated_Z = JNIEnv.GetMethodID (class_ref, "setActivated", "(Z)V");
            try {
                JValue* __args = stackalloc JValue [1];
                __args [0] = new JValue (activated);

                if (GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object)this).Handle, id_setActivated_Z, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivated", "(Z)V"), __args);
            } finally {
            }
        }
    }


    public partial class MediaNowPlayingView
    {
        public override Views.ViewStates Visibility {
            get { return base.Visibility; }
            set { SetVisibility (value); }
        }

        static Delegate cb_setVisibility_I;
#pragma warning disable 0169
        static Delegate GetSetVisibility_IHandler ()
        {
            if (cb_setVisibility_I == null)
                cb_setVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>)n_SetVisibility_I);
            return cb_setVisibility_I;
        }

        static void n_SetVisibility_I (IntPtr jnienv, IntPtr native__this, int native_visibility)
        {
            global::Android.Support.V17.Leanback.Widget.MediaNowPlayingView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V17.Leanback.Widget.MediaNowPlayingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.ViewStates visibility = (global::Android.Views.ViewStates)native_visibility;
            __this.SetVisibility (visibility);
        }
#pragma warning restore 0169

        static IntPtr id_setVisibility_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='android.support.v17.leanback.widget']/class[@name='MediaNowPlayingView']/method[@name='setVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register ("setVisibility", "(I)V", "GetSetVisibility_IHandler")]
        public unsafe void SetVisibility ([global::Android.Runtime.GeneratedEnum] global::Android.Views.ViewStates visibility)
        {
            if (id_setVisibility_I == IntPtr.Zero)
                id_setVisibility_I = JNIEnv.GetMethodID (class_ref, "setVisibility", "(I)V");
            try {
                JValue* __args = stackalloc JValue [1];
                __args [0] = new JValue ((int)visibility);

                if (GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object)this).Handle, id_setVisibility_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisibility", "(I)V"), __args);
            } finally {
            }
        }
    }

    public partial class SearchBar
    {
        public override int NextFocusDownId {
            get { return base.NextFocusDownId; }
            set { SetNextFocusDownId (value); }
        }

        static Delegate cb_setNextFocusDownId_I;
#pragma warning disable 0169
        static Delegate GetSetNextFocusDownId_IHandler ()
        {
            if (cb_setNextFocusDownId_I == null)
                cb_setNextFocusDownId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>)n_SetNextFocusDownId_I);
            return cb_setNextFocusDownId_I;
        }

        static void n_SetNextFocusDownId_I (IntPtr jnienv, IntPtr native__this, int viewId)
        {
            global::Android.Support.V17.Leanback.Widget.SearchBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V17.Leanback.Widget.SearchBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetNextFocusDownId (viewId);
        }
#pragma warning restore 0169

        static IntPtr id_setNextFocusDownId_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='android.support.v17.leanback.widget']/class[@name='SearchBar']/method[@name='setNextFocusDownId' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register ("setNextFocusDownId", "(I)V", "GetSetNextFocusDownId_IHandler")]
        public unsafe void SetNextFocusDownId (int viewId)
        {
            if (id_setNextFocusDownId_I == IntPtr.Zero)
                id_setNextFocusDownId_I = JNIEnv.GetMethodID (class_ref, "setNextFocusDownId", "(I)V");
            try {
                JValue* __args = stackalloc JValue [1];
                __args [0] = new JValue (viewId);

                if (GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object)this).Handle, id_setNextFocusDownId_I, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextFocusDownId", "(I)V"), __args);
            } finally {
            }
        }
    }
}

namespace Android.Support.V17.Leanback.App
{
    
}

namespace Android.Support.V17.Leanback.Widget.Picker
{
    public partial class Picker
    {
        public override bool Activated {
            get { return base.Activated; }
            set { SetActivated (value); }
        }
        static Delegate cb_setActivated_Z;
#pragma warning disable 0169
        static Delegate GetSetActivated_ZHandler ()
        {
            if (cb_setActivated_Z == null)
                cb_setActivated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>)n_SetActivated_Z);
            return cb_setActivated_Z;
        }

        static void n_SetActivated_Z (IntPtr jnienv, IntPtr native__this, bool activated)
        {
            global::Android.Support.V17.Leanback.Widget.Picker.Picker __this = global::Java.Lang.Object.GetObject<global::Android.Support.V17.Leanback.Widget.Picker.Picker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.SetActivated (activated);
        }
#pragma warning restore 0169

        static IntPtr id_setActivated_Z;
        // Metadata.xml XPath method reference: path="/api/package[@name='android.support.v17.leanback.widget.picker']/class[@name='Picker']/method[@name='setActivated' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register ("setActivated", "(Z)V", "GetSetActivated_ZHandler")]
        public unsafe void SetActivated (bool activated)
        {
            if (id_setActivated_Z == IntPtr.Zero)
                id_setActivated_Z = JNIEnv.GetMethodID (class_ref, "setActivated", "(Z)V");
            try {
                JValue* __args = stackalloc JValue [1];
                __args [0] = new JValue (activated);

                if (GetType () == ThresholdType)
                    JNIEnv.CallVoidMethod (((global::Java.Lang.Object)this).Handle, id_setActivated_Z, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivated", "(Z)V"), __args);
            } finally {
            }
        }
    }
}
