using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HOD_Inspect
{
    using static Db;
    public static class SQL
    {
        internal static DataTable GetCar(object[] data)
        {
            //@CMD, @CarCode, @CP_MIN, @CP_MAX, @D_MIN, @D_MAX, @R_MIN, @R_MAX

            // 20230915 JHLEE
            //return RETRIEVE("Up_m_Car", PARAMS(new string[] { "@CMD", "@CarCode", "@CP_MIN", "@CP_MAX", "@D_MIN", "@D_MAX", "@R_MIN", "@R_MAX" }, data));
            //return RETRIEVE("Up_m_Car", PARAMS(new string[] { "@CMD", "@CarCode", "@CP_MIN", "@CP_MAX", "@D_MIN", "@D_MAX", "@CP_MIN2", "@CP_MAX2", "@D_MIN2", "@D_MAX2", "@R_MIN", "@R_MAX" }, data));
            
            // 240116 JHLEE IEE, JOYSON
            return RETRIEVE("Up_m_Car", PARAMS(new string[] { "@CMD", "@CarCode", "@CP_MIN", "@CP_MAX", "@D_MIN", "@D_MAX", "@CP_MIN2", "@CP_MAX2", "@D_MIN2", "@D_MAX2", "@R_MIN", "@R_MAX" ,"@Maker"}, data));

            //return RETRIEVE("Up_m_Car", PARAMS(new string[] { "@CMD", "@CarCode" }, data));
        }

        public static DataTable GetAllModel(object[] data)
        {
            return RETRIEVE("Up_m_Model", PARAMS(new string[] { "@CMD", "@CarCode", "@PartNo", "@Spec" }, data));
        }

        public static DataTable GetLotNo()
        {
            return RETRIEVE("Up_F_LOTNO", PARAMS(new string[] { "@DateTime" }, new object[] { DateTime.Now.ToString("yyyyMMdd") }));
        }

        // 20230915 JHLEE
        //internal static void SaveData(string serial,string Spec, string CP_MIN, string CP_MAX, string D_MIN, string D_MAX,string RES ,string judge)

        internal static void SaveData(string serial, string Spec, string CP_MIN, string CP_MAX, string D_MIN, string D_MAX, string CP_MIN2, string CP_MAX2, string D_MIN2, string D_MAX2, string RES, string judge)
        {
            string sql = string.Empty;

            // 20230915 JHLEE
            //sql = $"insert r_History (Serial, [DateTime], Spec, CP_MIN, CP_MAX, D_MIN, D_MAX ,Resistance ,Judge) values ('{serial}','{DateTime.Now.ToString("yyyyMMddHHmmss")}','{Spec}','{CP_MIN}','{CP_MAX}','{D_MIN}','{D_MAX}','{RES}','{judge}')";
            // 20230918 JHLEE 날짜정보에 시간 제외
            //sql = $"insert r_History (Serial, [DateTime], Spec, CP_MIN, CP_MAX, D_MIN, D_MAX , CP_MIN2, CP_MAX2, D_MIN2, D_MAX2 ,Resistance ,Judge) values ('{serial}','{DateTime.Now.ToString("yyyyMMddHHmmss")}','{Spec}','{CP_MIN}','{CP_MAX}','{D_MIN}','{D_MAX}','{CP_MIN2}','{CP_MAX2}','{D_MIN2}','{D_MAX2}','{RES}','{judge}')";
            sql = $"insert r_History (Serial, [DateTime], Spec, CP_MIN, CP_MAX, D_MIN, D_MAX , CP_MIN2, CP_MAX2, D_MIN2, D_MAX2 ,Resistance ,Judge) values ('{serial}','{DateTime.Now.ToString("yyyyMMdd")}','{Spec}','{CP_MIN}','{CP_MAX}','{D_MIN}','{D_MAX}','{CP_MIN2}','{CP_MAX2}','{D_MIN2}','{D_MAX2}','{RES}','{judge}')";

            //
            RETRIEVESQL(sql);   
        }

        internal static DataTable GetModel(string Car , string PartNo)
        {
            string sql = string.Empty;
            sql = $"select * from m_Model where CarCode = '{Car}' and PartNo = '{PartNo}'";
            return RETRIEVESQL(sql);
        }

        internal static DataTable GetSaveData(string StartTime, string EndTime)
        {
            return RETRIEVE("Up_r_History", PARAMS(new string[] { "@StartTime", "@EndTime" }, new object[] { StartTime, EndTime }));
        }

        internal static DataTable GetCarSpec(string CarCode)
        {
            string sql = $"select * from m_Car where CarCode = '{CarCode}'";
            return RETRIEVESQL(sql);
        }

        internal static void SaveDataSecond(string judge, string capacitymin, string capacitymax, string dvalmin, string dvalmax, string capacity2min, string capacity2max, string dval2min, string dval2max, string regist)
        {
            //ProcCode, WorkDateTime, judge, CapacitVal, ResistVal, InspecChk, HisWriteChk, ProcWorkEnd
            EXECUTESQL_SECOND_DB($"update rTemp_Massage set WorkDateTime = '{DateTime.Now:yyyyMMddHHmmss}', judge = '{judge}', Dval_Min = '{dvalmin}' , Dval_Max = '{dvalmax}' ,Capacit_Min = '{capacitymin}', Capacit_Max = '{capacitymax}', Dval2_Min = '{dval2min}' , Dval2_Max = '{dval2max}' ,Capacit2_Min = '{capacity2min}', Capacit2_Max = '{capacity2max}',ResistVal = '{regist}', InspecChk = '1', HisWriteChk = '0', ProcWorkEnd = '1'");

        }
        public static void ResetDb()
        {
            EXECUTESQL_SECOND_DB($"update rTemp_Massage set  InspecChk = '0', HisWriteChk = '1', ProcWorkEnd = '0'");
        }

        public static bool ReadDbStart()
        {
            var ret = SCALARSQL_SECOND_DB("select ProcWorkEnd from rTemp_Massage");
            return ret != null ? ret.ToString() == "0" : false;
        }
    }
}
