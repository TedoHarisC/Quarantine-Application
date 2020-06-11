using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplikasi_Karantina.Models;
using Kendo.DynamicLinq;

namespace Aplikasi_Karantina.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TampilMasterMess(int take, int skip,
        IEnumerable<Kendo.DynamicLinq.Sort> sort, Kendo.DynamicLinq.Filter filter)
        {
            cls_data_master i_cls_master_karantina = new cls_data_master();
            return Json(i_cls_master_karantina.MenampilkanMasterMess().ToDataSourceResult(take, skip, sort, filter));
        }

        public ActionResult TambahMasterMess(List<tbl_m_mess> datamodel)
        {
            tbl_m_mess i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenambahkanMasterMess(i_list_item);
            return Json("Berhasil Ditambahkan");
        }

        public ActionResult EditMasterMess(List<tbl_m_mess> datamodel)
        {
            tbl_m_mess i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MengeditMasterMess(i_list_item);
            return Json("Berhasil Diubah");
        }

        public ActionResult HapusMasterMess(List<tbl_m_mess> datamodel)
        {
            tbl_m_mess i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenghapusMasterMess(i_list_item);
            return Json("Berhasil Dihapus");
        }

        [HttpPost]
        public ActionResult TampilMasterKamar(int take, int skip,
        IEnumerable<Kendo.DynamicLinq.Sort> sort, Kendo.DynamicLinq.Filter filter)
        {
            cls_data_master i_cls_master_karantina = new cls_data_master();
            return Json(i_cls_master_karantina.MenampilkanMasterKamar().ToDataSourceResult(take, skip, sort, filter));
        }

        public ActionResult TambahMasterKamar(List<vw_mess_kamar> datamodel)
        {
            vw_mess_kamar i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenambahkanMasterKamar(i_list_item);
            return Json("Berhasil Ditambahkan");
        }

        public ActionResult EditMasterKamar(List<vw_mess_kamar> datamodel)
        {
            vw_mess_kamar i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MengeditMasterKamar(i_list_item);
            return Json("Berhasil Diubah");
        }

        public ActionResult HapusMasterKamar(List<vw_mess_kamar> datamodel)
        {
            vw_mess_kamar i_list_item = datamodel.FirstOrDefault();
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenghapusMasterKamar(i_list_item);
            return Json("Berhasil Dihapus");
        }

        public ActionResult TambahDataKamar(tbl_m_kamar s_cls_kamar)
        {
            cls_data_master i_cls_data = new cls_data_master();
            i_cls_data.MenambahkanMasterKarantina(s_cls_kamar);
            return Json("Berhasil Ditambahkan");
        }



    }
}