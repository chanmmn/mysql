using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMySql
{
	public class Country
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public string Continent { get; set; }
		public string Region { get; set; }
		public decimal SurfaceArea { get; set; }
		public short IndepYear { get; set; }
		public int Population { get; set; }
		public decimal LifeExpectancy { get; set; }
		public decimal GNP { get; set; }
		public decimal GNPOld { get; set; }
		public string LocalName { get; set; }
		public string GovernmentForm { get; set; }
		public string HeadOfState { get; set; }
		public int? Capital { get; set; }
		public string Code2 { get; set; }

		public Country() { }
		public Country(string Code_, string Name_, string Continent_, string Region_, decimal SurfaceArea_, short IndepYear_, int Population_, decimal LifeExpectancy_, decimal GNP_, decimal GNPOld_, string LocalName_, string GovernmentForm_, string HeadOfState_, int Capital_, string Code2_)
		{
			this.Code = Code_;
			this.Name = Name_;
			this.Continent = Continent_;
			this.Region = Region_;
			this.SurfaceArea = SurfaceArea_;
			this.IndepYear = IndepYear_;
			this.Population = Population_;
			this.LifeExpectancy = LifeExpectancy_;
			this.GNP = GNP_;
			this.GNPOld = GNPOld_;
			this.LocalName = LocalName_;
			this.GovernmentForm = GovernmentForm_;
			this.HeadOfState = HeadOfState_;
			this.Capital = Capital_;
			this.Code2 = Code2_;
		}
	}
}
