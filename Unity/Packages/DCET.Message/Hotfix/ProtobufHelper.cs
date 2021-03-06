﻿#if !__CSharpLua__
using ProtoBuf.Meta;
#endif
using System.IO;

namespace DCET
{
	public static class ProtobufHelper
	{
		static ProtobufHelper()
		{
#if __CSharpLua__
			/*
			[[
				local pb = require "pb"
				pb.loadfile("Assets/Res/Lua/pbc/AutoGeneratedCode/OuterMessage.pb")
			]]
			*/
#endif
		}

		public static void ToStream(object message, MemoryStream memoryStream)
		{
#if !__CSharpLua__
			RuntimeTypeModel.Default.Serialize(memoryStream, message);
#else
			byte[] bytes = null;

			/*
			[[
			 bytes = encodeProtobuf(message)
			]]
			*/

			PacketParser.WriteBytes(memoryStream, bytes);
#endif
		}

		public static object FromStream(object message, MemoryStream memoryStream)
		{
			if(message != null)
			{
#if !__CSharpLua__
				return RuntimeTypeModel.Default.Deserialize(memoryStream, null, message.GetType());
#else
				byte[] bytes = PacketParser.ReadBytes(memoryStream);

				if(bytes != null)
				{
					/*
					[[
					return decodeProtobuf(bytes, message)
					]]
					*/
				}
#endif
			}

			return null;
		}
	}
}