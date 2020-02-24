﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_StageCameraWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.StageCamera), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("ApplyModifiedProperties", ApplyModifiedProperties);
		L.RegFunction("CheckMainCamera", CheckMainCamera);
		L.RegFunction("CheckCaptureCamera", CheckCaptureCamera);
		L.RegFunction("CreateCamera", CreateCamera);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("constantSize", get_constantSize, set_constantSize);
		L.RegVar("cachedTransform", get_cachedTransform, set_cachedTransform);
		L.RegVar("cachedCamera", get_cachedCamera, set_cachedCamera);
		L.RegVar("main", get_main, set_main);
		L.RegVar("screenSizeVer", get_screenSizeVer, set_screenSizeVer);
		L.RegVar("Name", get_Name, null);
		L.RegVar("LayerName", get_LayerName, null);
		L.RegVar("DefaultCameraSize", get_DefaultCameraSize, set_DefaultCameraSize);
		L.RegVar("UnitsPerPixel", get_UnitsPerPixel, set_UnitsPerPixel);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyModifiedProperties(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)ToLua.CheckObject<FairyGUI.StageCamera>(L, 1);
			obj.ApplyModifiedProperties();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckMainCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			FairyGUI.StageCamera.CheckMainCamera();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckCaptureCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			FairyGUI.StageCamera.CheckCaptureCamera();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Camera o = FairyGUI.StageCamera.CreateCamera(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_constantSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			bool ret = obj.constantSize;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constantSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			UnityEngine.Transform ret = obj.cachedTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			UnityEngine.Camera ret = obj.cachedCamera;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_main(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, FairyGUI.StageCamera.main);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_screenSizeVer(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, FairyGUI.StageCamera.screenSizeVer);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.StageCamera.Name);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LayerName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.StageCamera.LayerName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DefaultCameraSize(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, FairyGUI.StageCamera.DefaultCameraSize);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UnitsPerPixel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, FairyGUI.StageCamera.UnitsPerPixel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_constantSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.constantSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constantSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cachedTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.cachedTransform = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cachedCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageCamera obj = (FairyGUI.StageCamera)o;
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			obj.cachedCamera = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_main(IntPtr L)
	{
		try
		{
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			FairyGUI.StageCamera.main = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_screenSizeVer(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.StageCamera.screenSizeVer = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DefaultCameraSize(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.StageCamera.DefaultCameraSize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UnitsPerPixel(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.StageCamera.UnitsPerPixel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
