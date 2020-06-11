using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplikasi_Karantina.Models;
using Kendo.DynamicLinq;

namespace Aplikasi_Karantina.Controllers
{
    public class HomeController : Controller
    {
        public lts_abbsiteDataContextDataContext iObjContext_apps;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult TampilDataKarantina(int take, int skip,
        IEnumerable<Kendo.DynamicLinq.Sort> sort, Kendo.DynamicLinq.Filter filter)
        {
            cls_data_master i_cls_master_karantina = new cls_data_master();
            return Json(i_cls_master_karantina.MenampilkanDataKarantina().ToDataSourceResult(take, skip, sort, filter));
        }

        public ActionResult TambahDataKarantina(List<tbl_m_data_karantina> datamodel)
        {
            tbl_m_data_karantina i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenambahkanDataKarantina(i_list_item);
            return Json("Berhasil Ditambahkan");
        }

        public ActionResult EditDataKarantina(List<tbl_m_data_karantina> datamodel)
        {
            tbl_m_data_karantina i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MengeditDataKarantina(i_list_item);
            return Json("Berhasil Diubah");
        }

        public ActionResult HapusDataKarantina(List<tbl_m_data_karantina> datamodel)
        {
            tbl_m_data_karantina i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenghapusDataKarantina(i_list_item);
            return Json("Berhasil Dihapus");
        }

        public ActionResult TambahMasterKarantina(tbl_m_data_karantina s_cls_data_karantina)
        {
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenambahkanMasterKarantina(s_cls_data_karantina);
            return Json("Berhasil Ditambahkan");
        }

        public ActionResult DropdownListMess()
        {
            cls_data_master i_cls_perusahaan = new cls_data_master();
            return Json(i_cls_perusahaan.MenampilkanMasterMess(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DropdownListKamar(string nama_mess, DateTime tanggal_mulai)
        {
            cls_data_master i_cls_perusahaan = new cls_data_master();
            return Json(i_cls_perusahaan.MenampilkanDropdownKamar(nama_mess, tanggal_mulai), JsonRequestBehavior.AllowGet);
        }

        public ActionResult DropdownListTanggal(string nama_mess, string no_kamar, DateTime tanggal_hari_ini)
        {
            cls_data_master i_cls_perusahaan = new cls_data_master();
            return Json(i_cls_perusahaan.MenampilkanDropdownListTanggal(nama_mess, no_kamar, tanggal_hari_ini), JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateStatusKamar()
        {
            cls_data_master i_cls_master = new cls_data_master();
            i_cls_master.MengupdateStatusKamar();
            return Json("Data Ditambahkan");
        }
    }
}