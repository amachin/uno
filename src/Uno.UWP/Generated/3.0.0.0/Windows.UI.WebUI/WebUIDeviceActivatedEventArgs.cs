#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUIDeviceActivatedEventArgs : global::Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIDeviceActivatedEventArgs.Kind is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIDeviceActivatedEventArgs.PreviousExecutionState is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIDeviceActivatedEventArgs.SplashScreen is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User WebUIDeviceActivatedEventArgs.User is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CurrentlyShownApplicationViewId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int WebUIDeviceActivatedEventArgs.CurrentlyShownApplicationViewId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceInformationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebUIDeviceActivatedEventArgs.DeviceInformationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Verb
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebUIDeviceActivatedEventArgs.Verb is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIDeviceActivatedEventArgs.ActivatedOperation is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.DeviceInformationId.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.Verb.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.CurrentlyShownApplicationViewId.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.ActivatedOperation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIDeviceActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
