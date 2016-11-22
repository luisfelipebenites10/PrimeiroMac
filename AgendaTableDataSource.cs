using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace PrimeiroMac
{
	public class AgendaTableDataSource : NSTableViewDataSource
	{
		#region Public Variables
		public List<Agenda> Agendas = new List<Agenda>();
		#endregion

		#region Constructors
		public AgendaTableDataSource ()
		{
		}
		#endregion

		#region Override Methods
		public override nint GetRowCount (NSTableView tableView)
		{
			return Agendas.Count;
		}
		#endregion
	}
}

