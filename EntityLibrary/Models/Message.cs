using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary.Models
{
	[Serializable]
	[Table("Messages")]
	public class Message
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[Column(TypeName = "bit")]
		public bool HasRead { get; set; }

		[Required]
		[Column(TypeName = "datetime")]
		public DateTime TimeStamp { get; set; }

		[Required]
		[StringLength(250)]
		public string Content { get; set; }

		public int FromAccountId { get; set; }
		public virtual Account FromAccount { get; set; }

		public int ToAccountId { get; set; }
		public virtual Account ToAccount { get; set; }

		public Message() 
		{
		}
	}
}
