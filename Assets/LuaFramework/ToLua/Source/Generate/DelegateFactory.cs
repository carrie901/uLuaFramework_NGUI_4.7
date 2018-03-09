﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using System.Collections.Generic;
using LuaInterface;

public class DelegateFactory
{
	public delegate Delegate DelegateCreate(LuaFunction func, LuaTable self, bool flag);
	public static Dictionary<Type, DelegateCreate> dict = new Dictionary<Type, DelegateCreate>();
	static DelegateFactory factory = new DelegateFactory();

	public static void Init()
	{
		Register();
	}

	public static void Register()
	{
		dict.Clear();
		dict.Add(typeof(System.Action), factory.System_Action);
		dict.Add(typeof(UnityEngine.Events.UnityAction), factory.UnityEngine_Events_UnityAction);
		dict.Add(typeof(System.Predicate<int>), factory.System_Predicate_int);
		dict.Add(typeof(System.Action<int>), factory.System_Action_int);
		dict.Add(typeof(System.Comparison<int>), factory.System_Comparison_int);
		dict.Add(typeof(System.Func<int,int>), factory.System_Func_int_int);
		dict.Add(typeof(UnityEngine.Application.LogCallback), factory.UnityEngine_Application_LogCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMReaderCallback), factory.UnityEngine_AudioClip_PCMReaderCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), factory.UnityEngine_AudioClip_PCMSetPositionCallback);
		dict.Add(typeof(UIPanel.OnGeometryUpdated), factory.UIPanel_OnGeometryUpdated);
		dict.Add(typeof(UIPanel.OnClippingMoved), factory.UIPanel_OnClippingMoved);
		dict.Add(typeof(UIWidget.OnDimensionsChanged), factory.UIWidget_OnDimensionsChanged);
		dict.Add(typeof(UIWidget.OnPostFillCallback), factory.UIWidget_OnPostFillCallback);
		dict.Add(typeof(UIDrawCall.OnRenderCallback), factory.UIDrawCall_OnRenderCallback);
		dict.Add(typeof(UIWidget.HitCheck), factory.UIWidget_HitCheck);
		dict.Add(typeof(UIGrid.OnReposition), factory.UIGrid_OnReposition);
		dict.Add(typeof(System.Comparison<UnityEngine.Transform>), factory.System_Comparison_UnityEngine_Transform);
		dict.Add(typeof(UIProgressBar.OnDragFinished), factory.UIProgressBar_OnDragFinished);
		dict.Add(typeof(UIScrollView.OnDragNotification), factory.UIScrollView_OnDragNotification);
		dict.Add(typeof(System.Action<NotiData>), factory.System_Action_NotiData);

		DelegateTraits<System.Action>.Init(factory.System_Action);
		DelegateTraits<UnityEngine.Events.UnityAction>.Init(factory.UnityEngine_Events_UnityAction);
		DelegateTraits<System.Predicate<int>>.Init(factory.System_Predicate_int);
		DelegateTraits<System.Action<int>>.Init(factory.System_Action_int);
		DelegateTraits<System.Comparison<int>>.Init(factory.System_Comparison_int);
		DelegateTraits<System.Func<int,int>>.Init(factory.System_Func_int_int);
		DelegateTraits<UnityEngine.Application.LogCallback>.Init(factory.UnityEngine_Application_LogCallback);
		DelegateTraits<UnityEngine.AudioClip.PCMReaderCallback>.Init(factory.UnityEngine_AudioClip_PCMReaderCallback);
		DelegateTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Init(factory.UnityEngine_AudioClip_PCMSetPositionCallback);
		DelegateTraits<UIPanel.OnGeometryUpdated>.Init(factory.UIPanel_OnGeometryUpdated);
		DelegateTraits<UIPanel.OnClippingMoved>.Init(factory.UIPanel_OnClippingMoved);
		DelegateTraits<UIWidget.OnDimensionsChanged>.Init(factory.UIWidget_OnDimensionsChanged);
		DelegateTraits<UIWidget.OnPostFillCallback>.Init(factory.UIWidget_OnPostFillCallback);
		DelegateTraits<UIDrawCall.OnRenderCallback>.Init(factory.UIDrawCall_OnRenderCallback);
		DelegateTraits<UIWidget.HitCheck>.Init(factory.UIWidget_HitCheck);
		DelegateTraits<UIGrid.OnReposition>.Init(factory.UIGrid_OnReposition);
		DelegateTraits<System.Comparison<UnityEngine.Transform>>.Init(factory.System_Comparison_UnityEngine_Transform);
		DelegateTraits<UIProgressBar.OnDragFinished>.Init(factory.UIProgressBar_OnDragFinished);
		DelegateTraits<UIScrollView.OnDragNotification>.Init(factory.UIScrollView_OnDragNotification);
		DelegateTraits<System.Action<NotiData>>.Init(factory.System_Action_NotiData);

		TypeTraits<System.Action>.Init(factory.Check_System_Action);
		TypeTraits<UnityEngine.Events.UnityAction>.Init(factory.Check_UnityEngine_Events_UnityAction);
		TypeTraits<System.Predicate<int>>.Init(factory.Check_System_Predicate_int);
		TypeTraits<System.Action<int>>.Init(factory.Check_System_Action_int);
		TypeTraits<System.Comparison<int>>.Init(factory.Check_System_Comparison_int);
		TypeTraits<System.Func<int,int>>.Init(factory.Check_System_Func_int_int);
		TypeTraits<UnityEngine.Application.LogCallback>.Init(factory.Check_UnityEngine_Application_LogCallback);
		TypeTraits<UnityEngine.AudioClip.PCMReaderCallback>.Init(factory.Check_UnityEngine_AudioClip_PCMReaderCallback);
		TypeTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Init(factory.Check_UnityEngine_AudioClip_PCMSetPositionCallback);
		TypeTraits<UIPanel.OnGeometryUpdated>.Init(factory.Check_UIPanel_OnGeometryUpdated);
		TypeTraits<UIPanel.OnClippingMoved>.Init(factory.Check_UIPanel_OnClippingMoved);
		TypeTraits<UIWidget.OnDimensionsChanged>.Init(factory.Check_UIWidget_OnDimensionsChanged);
		TypeTraits<UIWidget.OnPostFillCallback>.Init(factory.Check_UIWidget_OnPostFillCallback);
		TypeTraits<UIDrawCall.OnRenderCallback>.Init(factory.Check_UIDrawCall_OnRenderCallback);
		TypeTraits<UIWidget.HitCheck>.Init(factory.Check_UIWidget_HitCheck);
		TypeTraits<UIGrid.OnReposition>.Init(factory.Check_UIGrid_OnReposition);
		TypeTraits<System.Comparison<UnityEngine.Transform>>.Init(factory.Check_System_Comparison_UnityEngine_Transform);
		TypeTraits<UIProgressBar.OnDragFinished>.Init(factory.Check_UIProgressBar_OnDragFinished);
		TypeTraits<UIScrollView.OnDragNotification>.Init(factory.Check_UIScrollView_OnDragNotification);
		TypeTraits<System.Action<NotiData>>.Init(factory.Check_System_Action_NotiData);

		StackTraits<System.Action>.Push = factory.Push_System_Action;
		StackTraits<UnityEngine.Events.UnityAction>.Push = factory.Push_UnityEngine_Events_UnityAction;
		StackTraits<System.Predicate<int>>.Push = factory.Push_System_Predicate_int;
		StackTraits<System.Action<int>>.Push = factory.Push_System_Action_int;
		StackTraits<System.Comparison<int>>.Push = factory.Push_System_Comparison_int;
		StackTraits<System.Func<int,int>>.Push = factory.Push_System_Func_int_int;
		StackTraits<UnityEngine.Application.LogCallback>.Push = factory.Push_UnityEngine_Application_LogCallback;
		StackTraits<UnityEngine.AudioClip.PCMReaderCallback>.Push = factory.Push_UnityEngine_AudioClip_PCMReaderCallback;
		StackTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Push = factory.Push_UnityEngine_AudioClip_PCMSetPositionCallback;
		StackTraits<UIPanel.OnGeometryUpdated>.Push = factory.Push_UIPanel_OnGeometryUpdated;
		StackTraits<UIPanel.OnClippingMoved>.Push = factory.Push_UIPanel_OnClippingMoved;
		StackTraits<UIWidget.OnDimensionsChanged>.Push = factory.Push_UIWidget_OnDimensionsChanged;
		StackTraits<UIWidget.OnPostFillCallback>.Push = factory.Push_UIWidget_OnPostFillCallback;
		StackTraits<UIDrawCall.OnRenderCallback>.Push = factory.Push_UIDrawCall_OnRenderCallback;
		StackTraits<UIWidget.HitCheck>.Push = factory.Push_UIWidget_HitCheck;
		StackTraits<UIGrid.OnReposition>.Push = factory.Push_UIGrid_OnReposition;
		StackTraits<System.Comparison<UnityEngine.Transform>>.Push = factory.Push_System_Comparison_UnityEngine_Transform;
		StackTraits<UIProgressBar.OnDragFinished>.Push = factory.Push_UIProgressBar_OnDragFinished;
		StackTraits<UIScrollView.OnDragNotification>.Push = factory.Push_UIScrollView_OnDragNotification;
		StackTraits<System.Action<NotiData>>.Push = factory.Push_System_Action_NotiData;
	}
    
    public static Delegate CreateDelegate(Type t, LuaFunction func = null)
    {
        DelegateCreate Create = null;

        if (!dict.TryGetValue(t, out Create))
        {
            throw new LuaException(string.Format("Delegate {0} not register", LuaMisc.GetTypeName(t)));            
        }

        if (func != null)
        {
            LuaState state = func.GetLuaState();
            LuaDelegate target = state.GetLuaDelegate(func);
            
            if (target != null)
            {
                return Delegate.CreateDelegate(t, target, target.method);
            }  
            else
            {
                Delegate d = Create(func, null, false);
                target = d.Target as LuaDelegate;
                state.AddLuaDelegate(target, func);
                return d;
            }       
        }

        return Create(null, null, false);        
    }
    
    public static Delegate CreateDelegate(Type t, LuaFunction func, LuaTable self)
    {
        DelegateCreate Create = null;

        if (!dict.TryGetValue(t, out Create))
        {
            throw new LuaException(string.Format("Delegate {0} not register", LuaMisc.GetTypeName(t)));
        }

        if (func != null)
        {
            LuaState state = func.GetLuaState();
            LuaDelegate target = state.GetLuaDelegate(func, self);

            if (target != null)
            {
                return Delegate.CreateDelegate(t, target, target.method);
            }
            else
            {
                Delegate d = Create(func, self, true);
                target = d.Target as LuaDelegate;
                state.AddLuaDelegate(target, func, self);
                return d;
            }
        }

        return Create(null, null, true);
    }
    
    public static Delegate RemoveDelegate(Delegate obj, LuaFunction func)
    {
        LuaState state = func.GetLuaState();
        Delegate[] ds = obj.GetInvocationList();

        for (int i = 0; i < ds.Length; i++)
        {
            LuaDelegate ld = ds[i].Target as LuaDelegate;

            if (ld != null && ld.func == func)
            {
                obj = Delegate.Remove(obj, ds[i]);
                state.DelayDispose(ld.func);
                break;
            }
        }

        return obj;
    }
    
    public static Delegate RemoveDelegate(Delegate obj, Delegate dg)
    {
        LuaDelegate remove = dg.Target as LuaDelegate;

        if (remove == null)
        {
            obj = Delegate.Remove(obj, dg);
            return obj;
        }

        LuaState state = remove.func.GetLuaState();
        Delegate[] ds = obj.GetInvocationList();        

        for (int i = 0; i < ds.Length; i++)
        {
            LuaDelegate ld = ds[i].Target as LuaDelegate;

            if (ld != null && ld == remove)
            {
                obj = Delegate.Remove(obj, ds[i]);
                state.DelayDispose(ld.func);
                state.DelayDispose(ld.self);
                break;
            }
        }

        return obj;
    }

	class System_Action_Event : LuaDelegate
	{
		public System_Action_Event(LuaFunction func) : base(func) { }
		public System_Action_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public System.Action System_Action(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Action fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			System_Action_Event target = new System_Action_Event(func);
			System.Action d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Action_Event target = new System_Action_Event(func, self);
			System.Action d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Action(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Action), L, pos);
	}

	void Push_System_Action(IntPtr L, System.Action o)
	{
		ToLua.Push(L, o);
	}

	class UnityEngine_Events_UnityAction_Event : LuaDelegate
	{
		public UnityEngine_Events_UnityAction_Event(LuaFunction func) : base(func) { }
		public UnityEngine_Events_UnityAction_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UnityEngine.Events.UnityAction UnityEngine_Events_UnityAction(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UnityEngine.Events.UnityAction fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UnityEngine_Events_UnityAction_Event target = new UnityEngine_Events_UnityAction_Event(func);
			UnityEngine.Events.UnityAction d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UnityEngine_Events_UnityAction_Event target = new UnityEngine_Events_UnityAction_Event(func, self);
			UnityEngine.Events.UnityAction d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UnityEngine_Events_UnityAction(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UnityEngine.Events.UnityAction), L, pos);
	}

	void Push_UnityEngine_Events_UnityAction(IntPtr L, UnityEngine.Events.UnityAction o)
	{
		ToLua.Push(L, o);
	}

	class System_Predicate_int_Event : LuaDelegate
	{
		public System_Predicate_int_Event(LuaFunction func) : base(func) { }
		public System_Predicate_int_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public bool Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			bool ret = func.CheckBoolean();
			func.EndPCall();
			return ret;
		}

		public bool CallWithSelf(int param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			bool ret = func.CheckBoolean();
			func.EndPCall();
			return ret;
		}
	}

	public System.Predicate<int> System_Predicate_int(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Predicate<int> fn = delegate(int param0) { return false; };
			return fn;
		}

		if(!flag)
		{
			System_Predicate_int_Event target = new System_Predicate_int_Event(func);
			System.Predicate<int> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Predicate_int_Event target = new System_Predicate_int_Event(func, self);
			System.Predicate<int> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Predicate_int(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Predicate<int>), L, pos);
	}

	void Push_System_Predicate_int(IntPtr L, System.Predicate<int> o)
	{
		ToLua.Push(L, o);
	}

	class System_Action_int_Event : LuaDelegate
	{
		public System_Action_int_Event(LuaFunction func) : base(func) { }
		public System_Action_int_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(int param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public System.Action<int> System_Action_int(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Action<int> fn = delegate(int param0) { };
			return fn;
		}

		if(!flag)
		{
			System_Action_int_Event target = new System_Action_int_Event(func);
			System.Action<int> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Action_int_Event target = new System_Action_int_Event(func, self);
			System.Action<int> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Action_int(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Action<int>), L, pos);
	}

	void Push_System_Action_int(IntPtr L, System.Action<int> o)
	{
		ToLua.Push(L, o);
	}

	class System_Comparison_int_Event : LuaDelegate
	{
		public System_Comparison_int_Event(LuaFunction func) : base(func) { }
		public System_Comparison_int_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public int Call(int param0, int param1)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}

		public int CallWithSelf(int param0, int param1)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}
	}

	public System.Comparison<int> System_Comparison_int(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Comparison<int> fn = delegate(int param0, int param1) { return 0; };
			return fn;
		}

		if(!flag)
		{
			System_Comparison_int_Event target = new System_Comparison_int_Event(func);
			System.Comparison<int> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Comparison_int_Event target = new System_Comparison_int_Event(func, self);
			System.Comparison<int> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Comparison_int(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Comparison<int>), L, pos);
	}

	void Push_System_Comparison_int(IntPtr L, System.Comparison<int> o)
	{
		ToLua.Push(L, o);
	}

	class System_Func_int_int_Event : LuaDelegate
	{
		public System_Func_int_int_Event(LuaFunction func) : base(func) { }
		public System_Func_int_int_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public int Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}

		public int CallWithSelf(int param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}
	}

	public System.Func<int,int> System_Func_int_int(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Func<int,int> fn = delegate(int param0) { return 0; };
			return fn;
		}

		if(!flag)
		{
			System_Func_int_int_Event target = new System_Func_int_int_Event(func);
			System.Func<int,int> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Func_int_int_Event target = new System_Func_int_int_Event(func, self);
			System.Func<int,int> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Func_int_int(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Func<int,int>), L, pos);
	}

	void Push_System_Func_int_int(IntPtr L, System.Func<int,int> o)
	{
		ToLua.Push(L, o);
	}

	class UnityEngine_Application_LogCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LogCallback_Event(LuaFunction func) : base(func) { }
		public UnityEngine_Application_LogCallback_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(string param0, string param1, UnityEngine.LogType param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(string param0, string param1, UnityEngine.LogType param2)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public UnityEngine.Application.LogCallback UnityEngine_Application_LogCallback(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UnityEngine.Application.LogCallback fn = delegate(string param0, string param1, UnityEngine.LogType param2) { };
			return fn;
		}

		if(!flag)
		{
			UnityEngine_Application_LogCallback_Event target = new UnityEngine_Application_LogCallback_Event(func);
			UnityEngine.Application.LogCallback d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UnityEngine_Application_LogCallback_Event target = new UnityEngine_Application_LogCallback_Event(func, self);
			UnityEngine.Application.LogCallback d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UnityEngine_Application_LogCallback(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UnityEngine.Application.LogCallback), L, pos);
	}

	void Push_UnityEngine_Application_LogCallback(IntPtr L, UnityEngine.Application.LogCallback o)
	{
		ToLua.Push(L, o);
	}

	class UnityEngine_AudioClip_PCMReaderCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func) : base(func) { }
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(float[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(float[] param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public UnityEngine.AudioClip.PCMReaderCallback UnityEngine_AudioClip_PCMReaderCallback(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMReaderCallback fn = delegate(float[] param0) { };
			return fn;
		}

		if(!flag)
		{
			UnityEngine_AudioClip_PCMReaderCallback_Event target = new UnityEngine_AudioClip_PCMReaderCallback_Event(func);
			UnityEngine.AudioClip.PCMReaderCallback d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UnityEngine_AudioClip_PCMReaderCallback_Event target = new UnityEngine_AudioClip_PCMReaderCallback_Event(func, self);
			UnityEngine.AudioClip.PCMReaderCallback d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UnityEngine_AudioClip_PCMReaderCallback(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UnityEngine.AudioClip.PCMReaderCallback), L, pos);
	}

	void Push_UnityEngine_AudioClip_PCMReaderCallback(IntPtr L, UnityEngine.AudioClip.PCMReaderCallback o)
	{
		ToLua.Push(L, o);
	}

	class UnityEngine_AudioClip_PCMSetPositionCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func) : base(func) { }
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(int param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public UnityEngine.AudioClip.PCMSetPositionCallback UnityEngine_AudioClip_PCMSetPositionCallback(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMSetPositionCallback fn = delegate(int param0) { };
			return fn;
		}

		if(!flag)
		{
			UnityEngine_AudioClip_PCMSetPositionCallback_Event target = new UnityEngine_AudioClip_PCMSetPositionCallback_Event(func);
			UnityEngine.AudioClip.PCMSetPositionCallback d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UnityEngine_AudioClip_PCMSetPositionCallback_Event target = new UnityEngine_AudioClip_PCMSetPositionCallback_Event(func, self);
			UnityEngine.AudioClip.PCMSetPositionCallback d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), L, pos);
	}

	void Push_UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L, UnityEngine.AudioClip.PCMSetPositionCallback o)
	{
		ToLua.Push(L, o);
	}

	class UIPanel_OnGeometryUpdated_Event : LuaDelegate
	{
		public UIPanel_OnGeometryUpdated_Event(LuaFunction func) : base(func) { }
		public UIPanel_OnGeometryUpdated_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIPanel.OnGeometryUpdated UIPanel_OnGeometryUpdated(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIPanel.OnGeometryUpdated fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UIPanel_OnGeometryUpdated_Event target = new UIPanel_OnGeometryUpdated_Event(func);
			UIPanel.OnGeometryUpdated d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIPanel_OnGeometryUpdated_Event target = new UIPanel_OnGeometryUpdated_Event(func, self);
			UIPanel.OnGeometryUpdated d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIPanel_OnGeometryUpdated(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIPanel.OnGeometryUpdated), L, pos);
	}

	void Push_UIPanel_OnGeometryUpdated(IntPtr L, UIPanel.OnGeometryUpdated o)
	{
		ToLua.Push(L, o);
	}

	class UIPanel_OnClippingMoved_Event : LuaDelegate
	{
		public UIPanel_OnClippingMoved_Event(LuaFunction func) : base(func) { }
		public UIPanel_OnClippingMoved_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(UIPanel param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(UIPanel param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIPanel.OnClippingMoved UIPanel_OnClippingMoved(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIPanel.OnClippingMoved fn = delegate(UIPanel param0) { };
			return fn;
		}

		if(!flag)
		{
			UIPanel_OnClippingMoved_Event target = new UIPanel_OnClippingMoved_Event(func);
			UIPanel.OnClippingMoved d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIPanel_OnClippingMoved_Event target = new UIPanel_OnClippingMoved_Event(func, self);
			UIPanel.OnClippingMoved d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIPanel_OnClippingMoved(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIPanel.OnClippingMoved), L, pos);
	}

	void Push_UIPanel_OnClippingMoved(IntPtr L, UIPanel.OnClippingMoved o)
	{
		ToLua.Push(L, o);
	}

	class UIWidget_OnDimensionsChanged_Event : LuaDelegate
	{
		public UIWidget_OnDimensionsChanged_Event(LuaFunction func) : base(func) { }
		public UIWidget_OnDimensionsChanged_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIWidget.OnDimensionsChanged UIWidget_OnDimensionsChanged(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIWidget.OnDimensionsChanged fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UIWidget_OnDimensionsChanged_Event target = new UIWidget_OnDimensionsChanged_Event(func);
			UIWidget.OnDimensionsChanged d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIWidget_OnDimensionsChanged_Event target = new UIWidget_OnDimensionsChanged_Event(func, self);
			UIWidget.OnDimensionsChanged d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIWidget_OnDimensionsChanged(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIWidget.OnDimensionsChanged), L, pos);
	}

	void Push_UIWidget_OnDimensionsChanged(IntPtr L, UIWidget.OnDimensionsChanged o)
	{
		ToLua.Push(L, o);
	}

	class UIWidget_OnPostFillCallback_Event : LuaDelegate
	{
		public UIWidget_OnPostFillCallback_Event(LuaFunction func) : base(func) { }
		public UIWidget_OnPostFillCallback_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(UIWidget param0, int param1, BetterList<UnityEngine.Vector3> param2, BetterList<UnityEngine.Vector2> param3, BetterList<UnityEngine.Color32> param4)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PushObject(param2);
			func.PushObject(param3);
			func.PushObject(param4);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(UIWidget param0, int param1, BetterList<UnityEngine.Vector3> param2, BetterList<UnityEngine.Vector2> param3, BetterList<UnityEngine.Color32> param4)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.Push(param1);
			func.PushObject(param2);
			func.PushObject(param3);
			func.PushObject(param4);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIWidget.OnPostFillCallback UIWidget_OnPostFillCallback(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIWidget.OnPostFillCallback fn = delegate(UIWidget param0, int param1, BetterList<UnityEngine.Vector3> param2, BetterList<UnityEngine.Vector2> param3, BetterList<UnityEngine.Color32> param4) { };
			return fn;
		}

		if(!flag)
		{
			UIWidget_OnPostFillCallback_Event target = new UIWidget_OnPostFillCallback_Event(func);
			UIWidget.OnPostFillCallback d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIWidget_OnPostFillCallback_Event target = new UIWidget_OnPostFillCallback_Event(func, self);
			UIWidget.OnPostFillCallback d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIWidget_OnPostFillCallback(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIWidget.OnPostFillCallback), L, pos);
	}

	void Push_UIWidget_OnPostFillCallback(IntPtr L, UIWidget.OnPostFillCallback o)
	{
		ToLua.Push(L, o);
	}

	class UIDrawCall_OnRenderCallback_Event : LuaDelegate
	{
		public UIDrawCall_OnRenderCallback_Event(LuaFunction func) : base(func) { }
		public UIDrawCall_OnRenderCallback_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(UnityEngine.Material param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(UnityEngine.Material param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIDrawCall.OnRenderCallback UIDrawCall_OnRenderCallback(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIDrawCall.OnRenderCallback fn = delegate(UnityEngine.Material param0) { };
			return fn;
		}

		if(!flag)
		{
			UIDrawCall_OnRenderCallback_Event target = new UIDrawCall_OnRenderCallback_Event(func);
			UIDrawCall.OnRenderCallback d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIDrawCall_OnRenderCallback_Event target = new UIDrawCall_OnRenderCallback_Event(func, self);
			UIDrawCall.OnRenderCallback d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIDrawCall_OnRenderCallback(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIDrawCall.OnRenderCallback), L, pos);
	}

	void Push_UIDrawCall_OnRenderCallback(IntPtr L, UIDrawCall.OnRenderCallback o)
	{
		ToLua.Push(L, o);
	}

	class UIWidget_HitCheck_Event : LuaDelegate
	{
		public UIWidget_HitCheck_Event(LuaFunction func) : base(func) { }
		public UIWidget_HitCheck_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public bool Call(UnityEngine.Vector3 param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			bool ret = func.CheckBoolean();
			func.EndPCall();
			return ret;
		}

		public bool CallWithSelf(UnityEngine.Vector3 param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.PCall();
			bool ret = func.CheckBoolean();
			func.EndPCall();
			return ret;
		}
	}

	public UIWidget.HitCheck UIWidget_HitCheck(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIWidget.HitCheck fn = delegate(UnityEngine.Vector3 param0) { return false; };
			return fn;
		}

		if(!flag)
		{
			UIWidget_HitCheck_Event target = new UIWidget_HitCheck_Event(func);
			UIWidget.HitCheck d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIWidget_HitCheck_Event target = new UIWidget_HitCheck_Event(func, self);
			UIWidget.HitCheck d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIWidget_HitCheck(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIWidget.HitCheck), L, pos);
	}

	void Push_UIWidget_HitCheck(IntPtr L, UIWidget.HitCheck o)
	{
		ToLua.Push(L, o);
	}

	class UIGrid_OnReposition_Event : LuaDelegate
	{
		public UIGrid_OnReposition_Event(LuaFunction func) : base(func) { }
		public UIGrid_OnReposition_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIGrid.OnReposition UIGrid_OnReposition(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIGrid.OnReposition fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UIGrid_OnReposition_Event target = new UIGrid_OnReposition_Event(func);
			UIGrid.OnReposition d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIGrid_OnReposition_Event target = new UIGrid_OnReposition_Event(func, self);
			UIGrid.OnReposition d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIGrid_OnReposition(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIGrid.OnReposition), L, pos);
	}

	void Push_UIGrid_OnReposition(IntPtr L, UIGrid.OnReposition o)
	{
		ToLua.Push(L, o);
	}

	class System_Comparison_UnityEngine_Transform_Event : LuaDelegate
	{
		public System_Comparison_UnityEngine_Transform_Event(LuaFunction func) : base(func) { }
		public System_Comparison_UnityEngine_Transform_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public int Call(UnityEngine.Transform param0, UnityEngine.Transform param1)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}

		public int CallWithSelf(UnityEngine.Transform param0, UnityEngine.Transform param1)
		{
			func.BeginPCall();
			func.Push(self);
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}
	}

	public System.Comparison<UnityEngine.Transform> System_Comparison_UnityEngine_Transform(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Comparison<UnityEngine.Transform> fn = delegate(UnityEngine.Transform param0, UnityEngine.Transform param1) { return 0; };
			return fn;
		}

		if(!flag)
		{
			System_Comparison_UnityEngine_Transform_Event target = new System_Comparison_UnityEngine_Transform_Event(func);
			System.Comparison<UnityEngine.Transform> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Comparison_UnityEngine_Transform_Event target = new System_Comparison_UnityEngine_Transform_Event(func, self);
			System.Comparison<UnityEngine.Transform> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Comparison_UnityEngine_Transform(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Comparison<UnityEngine.Transform>), L, pos);
	}

	void Push_System_Comparison_UnityEngine_Transform(IntPtr L, System.Comparison<UnityEngine.Transform> o)
	{
		ToLua.Push(L, o);
	}

	class UIProgressBar_OnDragFinished_Event : LuaDelegate
	{
		public UIProgressBar_OnDragFinished_Event(LuaFunction func) : base(func) { }
		public UIProgressBar_OnDragFinished_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIProgressBar.OnDragFinished UIProgressBar_OnDragFinished(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIProgressBar.OnDragFinished fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UIProgressBar_OnDragFinished_Event target = new UIProgressBar_OnDragFinished_Event(func);
			UIProgressBar.OnDragFinished d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIProgressBar_OnDragFinished_Event target = new UIProgressBar_OnDragFinished_Event(func, self);
			UIProgressBar.OnDragFinished d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIProgressBar_OnDragFinished(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIProgressBar.OnDragFinished), L, pos);
	}

	void Push_UIProgressBar_OnDragFinished(IntPtr L, UIProgressBar.OnDragFinished o)
	{
		ToLua.Push(L, o);
	}

	class UIScrollView_OnDragNotification_Event : LuaDelegate
	{
		public UIScrollView_OnDragNotification_Event(LuaFunction func) : base(func) { }
		public UIScrollView_OnDragNotification_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call()
		{
			func.Call();
		}

		public void CallWithSelf()
		{
			func.BeginPCall();
			func.Push(self);
			func.PCall();
			func.EndPCall();
		}
	}

	public UIScrollView.OnDragNotification UIScrollView_OnDragNotification(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			UIScrollView.OnDragNotification fn = delegate() { };
			return fn;
		}

		if(!flag)
		{
			UIScrollView_OnDragNotification_Event target = new UIScrollView_OnDragNotification_Event(func);
			UIScrollView.OnDragNotification d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			UIScrollView_OnDragNotification_Event target = new UIScrollView_OnDragNotification_Event(func, self);
			UIScrollView.OnDragNotification d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_UIScrollView_OnDragNotification(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(UIScrollView.OnDragNotification), L, pos);
	}

	void Push_UIScrollView_OnDragNotification(IntPtr L, UIScrollView.OnDragNotification o)
	{
		ToLua.Push(L, o);
	}

	class System_Action_NotiData_Event : LuaDelegate
	{
		public System_Action_NotiData_Event(LuaFunction func) : base(func) { }
		public System_Action_NotiData_Event(LuaFunction func, LuaTable self) : base(func, self) { }

		public void Call(NotiData param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}

		public void CallWithSelf(NotiData param0)
		{
			func.BeginPCall();
			func.Push(self);
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public System.Action<NotiData> System_Action_NotiData(LuaFunction func, LuaTable self, bool flag)
	{
		if (func == null)
		{
			System.Action<NotiData> fn = delegate(NotiData param0) { };
			return fn;
		}

		if(!flag)
		{
			System_Action_NotiData_Event target = new System_Action_NotiData_Event(func);
			System.Action<NotiData> d = target.Call;
			target.method = d.Method;
			return d;
		}
		else
		{
			System_Action_NotiData_Event target = new System_Action_NotiData_Event(func, self);
			System.Action<NotiData> d = target.CallWithSelf;
			target.method = d.Method;
			return d;
		}
	}

	bool Check_System_Action_NotiData(IntPtr L, int pos)
	{
		return TypeChecker.CheckDelegateType(typeof(System.Action<NotiData>), L, pos);
	}

	void Push_System_Action_NotiData(IntPtr L, System.Action<NotiData> o)
	{
		ToLua.Push(L, o);
	}

}

