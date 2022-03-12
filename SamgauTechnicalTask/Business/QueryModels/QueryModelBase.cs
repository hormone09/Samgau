using Business.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.QueryModels
{
	public abstract class QueryModelBase
	{
		public SortingType SortingType { get; set; }
		public List<long> IDs { get; set; }
	}
}
