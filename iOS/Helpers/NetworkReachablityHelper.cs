using System;
using Connectivity.Plugin;
using XamarinFormsDemo.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkReachablityHelper))]
namespace XamarinFormsDemo.iOS
{
	public class NetworkReachablityHelper: INetworkReachability
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
