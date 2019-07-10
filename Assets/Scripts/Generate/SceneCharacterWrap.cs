﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SceneCharacterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SceneCharacter), typeof(System.Object));
		L.RegFunction("CreateSceneCharacterInf", CreateSceneCharacterInf);
		L.RegFunction("CreateSceneCharacter", CreateSceneCharacter);
		L.RegFunction("PlayAnimation", PlayAnimation);
		L.RegFunction("StopPlay", StopPlay);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("gameObject", get_gameObject, set_gameObject);
		L.RegVar("transform", get_transform, set_transform);
		L.RegVar("Position", get_Position, set_Position);
		L.RegVar("Rotation", get_Rotation, set_Rotation);
		L.RegVar("Direction", get_Direction, set_Direction);
		L.RegVar("Visible", get_Visible, set_Visible);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateSceneCharacterInf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			AnimCtrlEnum arg1 = (AnimCtrlEnum)ToLua.CheckObject(L, 2, typeof(AnimCtrlEnum));
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			ISceneCharacter o = SceneCharacter.CreateSceneCharacterInf(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateSceneCharacter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			AnimCtrlEnum arg1 = (AnimCtrlEnum)ToLua.CheckObject(L, 2, typeof(AnimCtrlEnum));
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			SceneCharacter o = SceneCharacter.CreateSceneCharacter(arg0, arg1, arg2);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayAnimation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				SceneCharacter obj = (SceneCharacter)ToLua.CheckObject<SceneCharacter>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.PlayAnimation(arg0);
				return 0;
			}
			else if (count == 3)
			{
				SceneCharacter obj = (SceneCharacter)ToLua.CheckObject<SceneCharacter>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action<bool> arg1 = (System.Action<bool>)ToLua.CheckDelegate<System.Action<bool>>(L, 3);
				obj.PlayAnimation(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: SceneCharacter.PlayAnimation");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopPlay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SceneCharacter obj = (SceneCharacter)ToLua.CheckObject<SceneCharacter>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.StopPlay(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.GameObject ret = obj.gameObject;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index gameObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Transform ret = obj.transform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 ret = obj.Position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 ret = obj.Rotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Direction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 ret = obj.Direction;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Direction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Visible(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			bool ret = obj.Visible;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Visible on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.gameObject = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index gameObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.transform = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Rotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Direction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Direction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Direction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Visible(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SceneCharacter obj = (SceneCharacter)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Visible = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Visible on a nil value");
		}
	}
}

