using System;

using Foundation;
using AppKit;
using System.IO;
using System.Linq;

namespace PrimeiroMac
{

	public partial class MainWindowController : NSWindowController
	{
		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController () : base ("MainWindow")
		{
			this.Window.Title = "Agenda Pessoal";
		}


		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		

			ColunaNome.Title = "Nome";
			ColunaEndereco.Title = "Endereço";
			ColunaTelefone.Title = "Telefone";
			ColunaDataNascimento.Title = "Data Nascimento";
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}

		partial void ExecutarPerguntaSimples (Foundation.NSObject sender){
			
			using (var conn= new SQLite.SQLiteConnection(ConstroiCaminho()))
			{
				var q =from r in conn.Table<Agenda>()
					select r;

				var DataSource = new AgendaTableDataSource ();
				//DataSource.Agendas.Add ( new Agenda("Primeiro","Primeiro","8888888"));

				foreach(Agenda ag in q)
				{
					//Console.WriteLine("Encontrei "+ag.Nome+" no endereço "+ag.Endereco+" ou pelo telefone "+ag.Telefone);
					DataSource.Agendas.Add(new Agenda(ag.Nome,ag.Endereco,ag.Telefone,ag.Datanascimento));
				}
				AgendaTableDelegate agD = new AgendaTableDelegate(DataSource);
				MinhaTabelaTV.DataSource = DataSource;
				MinhaTabelaTV.Delegate = agD;
				//MinhaNovaTabelaAgendaTV.ReloadData ();

			}
		}

		partial void InserirNovoRegistroBT (NSObject sender)
		{
			Agenda ag1 = new Agenda (){
				Nome = NomeTF.StringValue,
				Endereco = EnderecoTF.StringValue,
				Telefone = TelefoneTF.StringValue,
				Datanascimento = Convert.ToDateTime(DataNascimentoTVC.StringValue),
			};

			using (var conn= new SQLite.SQLiteConnection(ConstroiCaminho()))
			{
				conn.CreateTable<Agenda> ();
				conn.Insert (ag1);
				conn.Commit ();
				NovoValorTB.StringValue = "Resultados Gravados!";
				NSAlert alerta = new NSAlert();
				alerta.MessageText  ="Registro Gravado!";
				alerta.RunModal();

			}

		}


		partial void ExecutaCBT (Foundation.NSObject sender) {
			using (var conn= new SQLite.SQLiteConnection(ConstroiCaminho()))
			{
				var q =from r in conn.Table<Agenda>()
					select r;

				var DataSource = new AgendaTableDataSource ();

				var retornoTab = MinhaTabelaTV.SelectedRow;

				var ret = q.ToList();
				NomeTF.StringValue = ret[Convert.ToInt32(retornoTab)].Nome;
				EnderecoTF.StringValue = ret[Convert.ToInt32(retornoTab)].Endereco;

			}
			/*

			NovoValorTB.StringValue = ConstroiCaminho();

*/
			//var recebe = NovoValorTB.StringValue;
			//NovoValorTB.StringValue = String.Format("Foi digitado no campo "+recebe.ToString());
		}
		public string ConstroiCaminho(){
			var sqliteFilename = "Agenda.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "", "MeusDBS"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			return path;
		}
	}
}
