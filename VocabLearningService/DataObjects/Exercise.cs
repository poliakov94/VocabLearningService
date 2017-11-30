using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VocabLearningService.DataObjects
{
	public class Exercise : EntityData
	{
		public string Word { get; set; }
		public string Definition { get; set; }
		public string Phrase { get; set; }
		public string TranslatedWord { get; set; }
		public string TranslatedPhrase { get; set; }
		public string ImageURI { get; set; }

		[ForeignKey("Assignment_Id")]
		public Assignment Assignment { get; set; }
		public string Assignment_Id { get; set; }
	}
}