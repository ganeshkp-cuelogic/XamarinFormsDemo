using System;
using Xamarin.Forms;
using XamarinFormsDemo;

namespace TestDemo
{
	public class NetworkReachabilityManager
	{
		public NetworkReachabilityManager()
		{
			
		}
		public static bool isInternetAvailable() {
			return DependencyService.Get<INetworkReachability>().isInternetAvailable();
		}
	}
}
