using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Aplikasi_Karantina.Models
{
    public class cls_data_master
    {
        lts_abbsiteDataContextDataContext i_ctx_db = new lts_abbsiteDataContextDataContext();

        public IQueryable<tbl_m_data_karantina> MenampilkanDataKarantina()
        {
            return i_ctx_db.tbl_m_data_karantinas.OrderBy(o => o.no_kamar).OrderBy(o => o.nama_mess).OrderBy(o => o.tanggal_akhir);
        }

        public void MenambahkanDataKarantina(tbl_m_data_karantina s_cls_dept)
        {
            i_ctx_db.InputDataKarantina(Guid.NewGuid().ToString(), s_cls_dept.nama, s_cls_dept.tanggal_mulai, s_cls_dept.tanggal_akhir, s_cls_dept.nama_mess, s_cls_dept.no_kamar);
            i_ctx_db.SubmitChanges();
        }

        public void MengeditDataKarantina(tbl_m_data_karantina s_cls_dept)
        {
            i_ctx_db.EditDataKarantina(s_cls_dept.id_data_karantina, s_cls_dept.nama, s_cls_dept.tanggal_mulai, s_cls_dept.tanggal_akhir, s_cls_dept.nama_mess, s_cls_dept.no_kamar);
            i_ctx_db.SubmitChanges();
        }

        public void MenghapusDataKarantina(tbl_m_data_karantina s_cls_dept)
        {
            i_ctx_db.HapusDataKarantina(s_cls_dept.id_data_karantina, s_cls_dept.tanggal_akhir, s_cls_dept.nama_mess, s_cls_dept.no_kamar);
            i_ctx_db.SubmitChanges();
        }

        public void MenambahkanMasterKarantina(tbl_m_data_karantina s_cls_data_karantina)
        {
            i_ctx_db.InputDataKarantina(Guid.NewGuid().ToString(), s_cls_data_karantina.nama, s_cls_data_karantina.tanggal_mulai, s_cls_data_karantina.tanggal_akhir, s_cls_data_karantina.nama_mess, s_cls_data_karantina.no_kamar);
            i_ctx_db.SubmitChanges();
        }

        public IQueryable<tbl_m_mess> MenampilkanMasterMess()
        {
            return i_ctx_db.tbl_m_messes;
        }

        public IQueryable<vw_mess_kamar> MenampilkanDropdownKamar(string nama_mess, DateTime tanggal_mulai)
        {
            return i_ctx_db.vw_mess_kamars.Where(
                o => (o.nama_mess.Equals(nama_mess) && o.status.Equals("Kosong")) || (o.nama_mess.Equals(nama_mess) && o.status.Equals("Terisi") && o.tgl_terakhir_dipakai <= tanggal_mulai)
            ).OrderBy(o => o.no_kamar);
        }

        public IQueryable<tbl_m_data_karantina> MenampilkanDropdownListTanggal(string nama_mess, string no_kamar, DateTime tanggal_hari_ini)
        {
            return i_ctx_db.tbl_m_data_karantinas.Where(o => o.nama_mess.Equals(nama_mess) && o.no_kamar.Equals(no_kamar) && o.tanggal_akhir > tanggal_hari_ini)
                .OrderBy(o => o.tanggal_akhir);
        }

        public void MenambahkanMasterMess(tbl_m_mess s_cls_mess)
        {
            i_ctx_db.InputMasterMess(Guid.NewGuid().ToString(), s_cls_mess.nama_mess);
            i_ctx_db.SubmitChanges();
        }

        public void MengeditMasterMess(tbl_m_mess s_cls_mess)
        {
            i_ctx_db.EditMasterMess(s_cls_mess.id_master_mess, s_cls_mess.nama_mess);
            i_ctx_db.SubmitChanges();
        }

        public void MenghapusMasterMess(tbl_m_mess s_cls_mess)
        {
            i_ctx_db.HapusMasterMess(s_cls_mess.id_master_mess);
            i_ctx_db.SubmitChanges();
        }

        public IQueryable<vw_mess_kamar> MenampilkanMasterKamar()
        {
            return i_ctx_db.vw_mess_kamars.OrderBy(o => o.no_kamar).OrderBy(o => o.nama_mess);
        }

        public void MenambahkanMasterKamar(vw_mess_kamar s_cls_kamar)
        {
            i_ctx_db.InputMasterKamar(s_cls_kamar.id_master_kamar, s_cls_kamar.id_master_mess, s_cls_kamar.no_kamar, s_cls_kamar.tgl_terakhir_dipakai, s_cls_kamar.status);
            i_ctx_db.SubmitChanges();
        }

        public void MengeditMasterKamar(vw_mess_kamar s_cls_kamar)
        {
            i_ctx_db.EditMasterKamar(s_cls_kamar.id_master_kamar, s_cls_kamar.nama_mess, s_cls_kamar.no_kamar, s_cls_kamar.tgl_terakhir_dipakai, s_cls_kamar.status);
            i_ctx_db.SubmitChanges();
        }

        public void MenghapusMasterKamar(vw_mess_kamar s_cls_kamar)
        {
            i_ctx_db.HapusMasterKamar(s_cls_kamar.id_master_kamar);
            i_ctx_db.SubmitChanges();
        }

        public void MenambahkanMasterKarantina(tbl_m_kamar s_cls_kamar)
        {
            i_ctx_db.InputMasterKamar(Guid.NewGuid().ToString(), s_cls_kamar.id_master_mess, s_cls_kamar.no_kamar, s_cls_kamar.tgl_terakhir_dipakai, s_cls_kamar.status);
            i_ctx_db.SubmitChanges();
        }

        public void MengupdateStatusKamar()
        {
            i_ctx_db.UpdateStatusKamar();
        }
    }
}