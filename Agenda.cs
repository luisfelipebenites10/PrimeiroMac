using System;
using SQLite;

namespace PrimeiroMac
{
	public class Agenda
	{
		[PrimaryKey, AutoIncrement]
		public int ID {
			get;
			set;
		}
		public string Nome {
			get;
			set;
		}
		public string Endereco {
			get;
			set;
		}
		public string Telefone {
			get;
			set;
		}
		public DateTime Datanascimento {
			get;
			set;
		}
	
		#region Constructors
		public Agenda ()
		{
		}

		public Agenda ( string nome, string endereco, string telefone, DateTime datanascimento)
		{
			//this.ID = id;
			this.Nome = nome;
			this.Endereco = endereco;
			this.Telefone = telefone;
			this.Datanascimento = datanascimento;
		}

		#endregion

		public override string ToString()
		{
			return string.Format("[Agenda: ID={0}, Nome={1}, Endereco={2}, Telefone={3}, DataNascimento={4}]", ID, Nome, Endereco, Telefone, Datanascimento);
		}


	}
}

