// WARNING
//
// This file has been generated automatically by Xamarin Studio Enterprise to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PrimeiroMac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSTableColumn ColunaDataNascimento { get; set; }

		[Outlet]
		AppKit.NSTableColumn ColunaEndereco { get; set; }

		[Outlet]
		AppKit.NSTableColumn ColunaNome { get; set; }

		[Outlet]
		AppKit.NSTableColumn ColunaTelefone { get; set; }

		[Outlet]
		AppKit.NSTextField DataNascimentoTVC { get; set; }

		[Outlet]
		AppKit.NSTextField EnderecoTF { get; set; }

		[Outlet]
		AppKit.NSTextField EnderecoTVC { get; set; }

		[Outlet]
		AppKit.NSTableView MinhaTabelaTV { get; set; }

		[Outlet]
		AppKit.NSTextField NomeTF { get; set; }

		[Outlet]
		AppKit.NSTextField NomeTVC { get; set; }

		[Outlet]
		AppKit.NSTextField NovoValorTB { get; set; }

		[Outlet]
		AppKit.NSTextField RecebeValorLabel { get; set; }

		[Outlet]
		AppKit.NSTextField TelefoneTF { get; set; }

		[Action ("ExecutaCBT:")]
		partial void ExecutaCBT (Foundation.NSObject sender);

		[Action ("ExecutarPerguntaSimples:")]
		partial void ExecutarPerguntaSimples (Foundation.NSObject sender);

		[Action ("InserirNovoRegistroBT:")]
		partial void InserirNovoRegistroBT (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ColunaDataNascimento != null) {
				ColunaDataNascimento.Dispose ();
				ColunaDataNascimento = null;
			}

			if (ColunaEndereco != null) {
				ColunaEndereco.Dispose ();
				ColunaEndereco = null;
			}

			if (ColunaNome != null) {
				ColunaNome.Dispose ();
				ColunaNome = null;
			}

			if (ColunaTelefone != null) {
				ColunaTelefone.Dispose ();
				ColunaTelefone = null;
			}

			if (DataNascimentoTVC != null) {
				DataNascimentoTVC.Dispose ();
				DataNascimentoTVC = null;
			}

			if (EnderecoTF != null) {
				EnderecoTF.Dispose ();
				EnderecoTF = null;
			}

			if (EnderecoTVC != null) {
				EnderecoTVC.Dispose ();
				EnderecoTVC = null;
			}

			if (MinhaTabelaTV != null) {
				MinhaTabelaTV.Dispose ();
				MinhaTabelaTV = null;
			}

			if (NomeTF != null) {
				NomeTF.Dispose ();
				NomeTF = null;
			}

			if (NomeTVC != null) {
				NomeTVC.Dispose ();
				NomeTVC = null;
			}

			if (NovoValorTB != null) {
				NovoValorTB.Dispose ();
				NovoValorTB = null;
			}

			if (RecebeValorLabel != null) {
				RecebeValorLabel.Dispose ();
				RecebeValorLabel = null;
			}

			if (TelefoneTF != null) {
				TelefoneTF.Dispose ();
				TelefoneTF = null;
			}
		}
	}
}
