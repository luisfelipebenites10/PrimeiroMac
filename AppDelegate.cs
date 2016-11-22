using AppKit;
using Foundation;

namespace PrimeiroMac
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;

		NovaJanelaWIndowControllerController novaJanelaController;

		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}

		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
		partial void MostraSegundaJanela (NSObject sender)
		{
			novaJanelaController = new NovaJanelaWIndowControllerController();
			novaJanelaController.Window.Title = "Segunda Janela";
			novaJanelaController.ShowWindow(this);
		}
	}
}
