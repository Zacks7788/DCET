﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Shared_CanonicalDisposableClassWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Shared.CanonicalDisposableClass), typeof(System.Object));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("SomeMethod", SomeMethod);
		L.RegFunction("New", _CreateMongoDB_Shared_CanonicalDisposableClass);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Shared_CanonicalDisposableClass(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.IDisposable arg0 = (System.IDisposable)ToLua.CheckObject<System.IDisposable>(L, 1);
				MongoDB.Shared.CanonicalDisposableClass obj = new MongoDB.Shared.CanonicalDisposableClass(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Shared.CanonicalDisposableClass.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Shared.CanonicalDisposableClass obj = (MongoDB.Shared.CanonicalDisposableClass)ToLua.CheckObject<MongoDB.Shared.CanonicalDisposableClass>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SomeMethod(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Shared.CanonicalDisposableClass obj = (MongoDB.Shared.CanonicalDisposableClass)ToLua.CheckObject<MongoDB.Shared.CanonicalDisposableClass>(L, 1);
			obj.SomeMethod();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
