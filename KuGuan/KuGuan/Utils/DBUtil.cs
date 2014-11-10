using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace KuGuan.Utils
{
    class DBUtil
    {
        private static kuguanDataSetTableAdapters.supplierTableAdapter supAdapter = new kuguanDataSetTableAdapters.supplierTableAdapter();
        private static kuguanDataSetTableAdapters.customerTableAdapter cusAdapter = new kuguanDataSetTableAdapters.customerTableAdapter();
        private static kuguanDataSetTableAdapters.unitTableAdapter unitAdapter = new kuguanDataSetTableAdapters.unitTableAdapter();
        private static kuguanDataSetTableAdapters.product_typeTableAdapter product_typeTableAdapter = new kuguanDataSetTableAdapters.product_typeTableAdapter();
        private static kuguanDataSetTableAdapters.stockTableAdapter stockTableAdapter = new kuguanDataSetTableAdapters.stockTableAdapter();
        private static kuguanDataSetTableAdapters.productTableAdapter proAdapter = new kuguanDataSetTableAdapters.productTableAdapter();

        public static int GetEngId(string store_name, string eng_name)
        {
            DataTable st = product_typeTableAdapter.GetOldId(store_name, 1, 0);
            DataTable et;
            int engId = 0;
            int storeId = 0;
            if (st.Rows.Count > 0)
            {
                storeId = (int)st.Rows[0][0];
                et = product_typeTableAdapter.GetOldId(eng_name, 2, storeId);
                if (et.Rows.Count > 0)
                {
                    engId = (int)et.Rows[0][0];
                }
                else
                {
                    product_typeTableAdapter.AddType(eng_name, 2, storeId);
                    engId = (int)product_typeTableAdapter.GetNewId();
                }
            }
            else
            {
                product_typeTableAdapter.AddType(store_name, 1, 0);
                storeId = (int)product_typeTableAdapter.GetNewId();
                product_typeTableAdapter.AddType(eng_name, 2, storeId);
                engId = (int)product_typeTableAdapter.GetNewId();
            }
            return engId;
        }

        public static int GetSupId(string sup_name)
        {
            int supId = 0;
            DataTable st = supAdapter.GetOldId(sup_name);
            if (st.Rows.Count > 0)
            {
                supId = (int)st.Rows[0][0];
            }
            else
            {
                supAdapter.AddSup(sup_name, (int)supAdapter.GetMinTypeId());
                supId = (int)supAdapter.GetNewId();
            }
            return supId;
        }

        public static int GetUnitId(string unit)
        {
            int unitId = 0;
            DataTable ut = unitAdapter.GetOldId(unit);
            if (ut.Rows.Count > 0)
            {
                unitId = (int)ut.Rows[0][0];
            }
            else
            {
                unitId = (int)unitAdapter.GetNewId();
                unitAdapter.AddUnit(unitId, unit);
            }
            return unitId;
        }

        public static int GetProId(string pro_name, string spec,string unit, decimal price, string remark, kuguanDataSet.proDataTable pro)
        {
            int proId = 0;
            int unitId = GetUnitId(unit);
            var rs = from kuguanDataSet.proRow row in pro.Rows
                  where row.product_name == pro_name 
                  && row.spec == spec 
                  && row.out_price == price 
                  && row.remark == remark
                  && row.unit_id == unitId
                  select row.product_id;
            if (rs.Count() > 0)
            {
                proId = rs.ElementAt(0);
            }
            else
            {
                proId = pro.AddproRow(pro_name, price, price, unitId, "", remark, spec).product_id;
            }
            return proId;
        }

        public static kuguanDataSet.stockRow changeStock(int pro_id, int store_id, Decimal num, Decimal price,Decimal amount, kuguanDataSet.stockDataTable stock)
        {
            var rs = from kuguanDataSet.stockRow row in stock.Rows
                     where row.product_id == pro_id && row.product_type_id == store_id
                     select row;
            int count = rs.Count();
            if (count > 0)
            {
                kuguanDataSet.stockRow row = rs.ElementAt(0);
                row.stock_num += num;
                row.stock_amount += amount;
                return row;
            }
            else
            {
                if (pro_id != -1)
                {
                    kuguanDataSet.stockRow r = stock.AddstockRow(pro_id, store_id, num, amount);
                    return r;
                }
                return null;
            }
        }

        public static kuguanDataSet.remainRow changeRemain(int pro_id, int store_id, Decimal num, Decimal price, kuguanDataSet.remainDataTable remain)
        {
            var rs = from kuguanDataSet.remainRow row in remain.Rows
                     where row.product_id == pro_id && row.store_id == store_id
                     select row;
            int count = rs.Count();
            if (count > 0)
            {
                kuguanDataSet.remainRow row = rs.ElementAt(0);
                row.num += num;
                row.amount += Decimal.Round(price * num, 11);
                return row;
            }
            else
            {
                if (pro_id != -1)
                {
                    kuguanDataSet.remainRow r = remain.AddremainRow(pro_id, store_id, num, Decimal.Round(price * num, 11));
                    return r;
                }
                return null;
            }
        }

        public static void changeStock(List<Object[]> objRows,int store_id,kuguanDataSet dataSet)
        {
            foreach(Object[] row in objRows)
            {
                var rs = from kuguanDataSet.proRow r in dataSet.pro.Rows
                         where r.product_name == (string)row[0] && r.spec == (string)row[1]
                            && r.remark == (string)row[4]
                            && r.out_price == (decimal)row[3]
                         select r;
                if (rs.Count() > 0)
                {
                    int proId = rs.ElementAt(0).product_id;

                    decimal num = Convert.ToDecimal(row[5]);
                    decimal amount = Convert.ToDecimal(row[6]);
                    var rs0 = from kuguanDataSet.stockRow r0 in dataSet.stock.Rows
                              where r0.product_id == proId && r0.product_type_id == store_id
                              select r0;
                    int count = rs0.Count();
                    if (count > 0)
                    {
                        kuguanDataSet.stockRow r1 = rs0.ElementAt(0);
                        r1.stock_num += num;
                        r1.stock_amount += amount;
                    }
                    else
                        dataSet.stock.AddstockRow(proId, store_id, num, amount);
                }
            }
        }

        public static void AddSup(string name, string address, string phone, int sup_type_id)
        {
            supAdapter.AddSup0(name, address, "", "", phone, "", "", "", "", "", sup_type_id);

        }
        
        public static void AddCus(string name, string address, string phone, int cus_type_id)
        {
            cusAdapter.AddCus0(cus_type_id, name, address, "", "", phone, "", "", "", "", "");
            
        }

    }
}
