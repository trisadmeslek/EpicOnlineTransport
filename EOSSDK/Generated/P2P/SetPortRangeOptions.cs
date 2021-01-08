// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about new port range settings.
	/// </summary>
	public class SetPortRangeOptions
	{
		/// <summary>
		/// The ideal port to use for P2P traffic. The default value is 7777. If set to 0, the OS will choose a port. If set to 0, MaxAdditionalPortsToTry must be set to 0.
		/// </summary>
		public ushort Port { get; set; }

		/// <summary>
		/// The maximum amount of additional ports to try if Port is unavailable. Ports will be tried from Port to Port + MaxAdditionalPortsToTry
		/// inclusive, until one is available or we run out of ports. If no ports are available, P2P connections will fail. The default value is 99.
		/// </summary>
		public ushort MaxAdditionalPortsToTry { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetPortRangeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private ushort m_Port;
		private ushort m_MaxAdditionalPortsToTry;

		public ushort Port
		{
			set
			{
				m_Port = value;
			}
		}

		public ushort MaxAdditionalPortsToTry
		{
			set
			{
				m_MaxAdditionalPortsToTry = value;
			}
		}

		public void Set(SetPortRangeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = P2PInterface.SetportrangeApiLatest;
				Port = other.Port;
				MaxAdditionalPortsToTry = other.MaxAdditionalPortsToTry;
			}
		}

		public void Set(object other)
		{
			Set(other as SetPortRangeOptions);
		}

		public void Dispose()
		{
		}
	}
}