using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;


namespace PrimeiroMac
{

	public class AgendaTableDelegate: NSTableViewDelegate
	{
		public string Nome {
			get;
			set;
		}

		#region Constants 
		private const string CellIdentifier = "ProdCell";
		#endregion

		#region Private Variables
		private AgendaTableDataSource DataSource;
		#endregion

		#region Constructors

		public AgendaTableDelegate (AgendaTableDataSource datasource)
		{
			this.DataSource = datasource;
		}
		#endregion



		#region Override Methods
		public override bool ShouldSelectRow (NSTableView tableView, nint row)
		{
			Nome = DataSource.Agendas [Convert.ToInt32(row)].Nome;
			return true;
		}
		public string RetornaNome(){
			return Nome;
		}

		public override NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			// This pattern allows you reuse existing views when they are no-longer in use.
			// If the returned view is null, you instance up a new view
			// If a non-null view is returned, you modify it enough to reflect the new data
			NSTextField view = (NSTextField)tableView.MakeView (CellIdentifier, this);
			if (view == null) {
				view = new NSTextField ();
				view.Identifier = CellIdentifier;
				view.BackgroundColor = NSColor.Clear;
				view.Bordered = false;
				view.Selectable = false;
				view.Editable = false;
			}

			// Setup view based on the column selected
			switch (tableColumn.Title) {
			case "Nome":
				view.StringValue = DataSource.Agendas [(int)row].Nome;
				break;
			case "Endereço":
				view.StringValue = DataSource.Agendas [(int)row].Endereco;
				break;
			case "Telefone":
				view.StringValue = DataSource.Agendas [(int)row].Telefone;
				break;
			case "Data Nascimento":
				view.StringValue = Convert.ToString(DataSource.Agendas [(int)row].Datanascimento);
				break;
			}

			return view;
		}
		#endregion
	}
}

