using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMySql
{
	public class Collect
	{
		public int id { get; set; }
		public DateTime collect_date { get; set; }
		public DateTime end_collect_date { get; set; }
		public string chit_no { get; set; }
		public double uco_in_kg { get; set; }
		public double requested_uco_in_kg { get; set; }
		public double uco_before { get; set; }
		public double uco_before_magnet { get; set; }
		public string uco_before_image { get; set; }
		public double uco_after { get; set; }
		public double uco_after_magnet { get; set; }
		public string uco_after_image { get; set; }
		public string status { get; set; }
		public string tag { get; set; }
		public int trips_id { get; set; }
		public string manager_name { get; set; }
		public string signature { get; set; }
		public int outlets_id { get; set; }
		public string remarks { get; set; }
		public int approve_by_admin_id { get; set; }
		public DateTime create_date { get; set; }
		public int is_deleted { get; set; }
		public int manual_request { get; set; }
		public string request_by { get; set; }
		public DateTime last_update { get; set; }
		public int coc { get; set; }
		public double coc_payment { get; set; }
		public DateTime email_chit { get; set; }
		public int line_no { get; set; }
		public double created_lat { get; set; }
		public double created_lng { get; set; }

		public Collect() { }

		public Collect(int id_, DateTime collect_date_, DateTime end_collect_date_, string chit_no_, double uco_in_kg_, double requested_uco_in_kg_, double uco_before_, double uco_before_magnet_, string uco_before_image_, double uco_after_, double uco_after_magnet_, string uco_after_image_, string status_, string tag_, int trips_id_, string manager_name_, string signature_, int outlets_id_, string remarks_, int approve_by_admin_id_, DateTime create_date_, int is_deleted_, int manual_request_, string request_by_, DateTime last_update_, int coc_, double coc_payment_, DateTime email_chit_, int line_no_, double created_lat_, double created_lng_)
		{
			this.id = id_;
			this.collect_date = collect_date_;
			this.end_collect_date = end_collect_date_;
			this.chit_no = chit_no_;
			this.uco_in_kg = uco_in_kg_;
			this.requested_uco_in_kg = requested_uco_in_kg_;
			this.uco_before = uco_before_;
			this.uco_before_magnet = uco_before_magnet_;
			this.uco_before_image = uco_before_image_;
			this.uco_after = uco_after_;
			this.uco_after_magnet = uco_after_magnet_;
			this.uco_after_image = uco_after_image_;
			this.status = status_;
			this.tag = tag_;
			this.trips_id = trips_id_;
			this.manager_name = manager_name_;
			this.signature = signature_;
			this.outlets_id = outlets_id_;
			this.remarks = remarks_;
			this.approve_by_admin_id = approve_by_admin_id_;
			this.create_date = create_date_;
			this.is_deleted = is_deleted_;
			this.manual_request = manual_request_;
			this.request_by = request_by_;
			this.last_update = last_update_;
			this.coc = coc_;
			this.coc_payment = coc_payment_;
			this.email_chit = email_chit_;
			this.line_no = line_no_;
			this.created_lat = created_lat_;
			this.created_lng = created_lng_;
		}
	}
}
