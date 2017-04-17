using System;
using Connectivity.Plugin;
using XamarinFormsDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkReachablityHelper))]
namespace XamarinFormsDemo.Droid
{
	public class NetworkReachablityHelper : INetworkReachability
	{
		public NetworkReachablityHelper()
		{
		}

		public bool isInternetAvailable()
		{
			return CrossConnectivity.Current.IsConnected;
		}
	}
}
