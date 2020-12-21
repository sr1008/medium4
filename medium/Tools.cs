using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace medium
{
    class Tools
    {
        public static bool dom = true;
        public static void  ExportSaff(DataSet data)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.xls)|*.xls";
            save.ShowDialog();
            string path = save.FileName;

            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = excel.Workbooks.Add(true); ;

            Excel.Worksheet ws = wb.Worksheets[1];
            ws.Cells[1, 1] = "工号";
            ws.Cells[1, 2] = "姓名";
            ws.Cells[1, 3] = "性别";
            ws.Cells[1, 4] = "身份证号";
            ws.Cells[1, 5] = "电话";
            ws.Cells[1, 6] = "职务";
            ws.Cells[1, 7] = "入职时间";
            
            int index = 2;
            foreach(DataRow row in data.Tables[0].Rows)
            {
                ws.Cells[index, 1] = row["jobNum"];
                ws.Cells[index, 2] = row["name"];
                ws.Cells[index, 3] = row["sex1"];
                ws.Cells[index, 4] = row["cardNo"];
                ws.Cells[index, 5] = row["number"];
                ws.Cells[index, 6] = row["status1"];
                ws.Cells[index, 7] = row["endDate"];
                index++;
            }

            wb.SaveAs(path);
            excel.Quit();
           

        }

        public static void ExportHouse(DataSet data)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.xls)|*.xls";
            save.ShowDialog();
            string path = save.FileName;

            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = excel.Workbooks.Add(true);
            Excel.Worksheet ws = wb.Worksheets[1];

            ws.Cells[1, 1] = "房源编号";
            ws.Cells[1, 2] = "预估价格";
            ws.Cells[1, 3] = "房源地址";
            ws.Cells[1, 4] = "房源状态";
            ws.Cells[1, 5] = "房主编号";
            ws.Cells[1, 6] = "房主名字";
            ws.Cells[1, 7] = "电话号码";
            ws.Cells[1, 8] = "添加时间";

            int index = 2;

            foreach(DataRow row in data.Tables[0].Rows)
            {
                ws.Cells[index, 1] = row["card"];
                ws.Cells[index, 2] = row["estPrice"];
                ws.Cells[index, 3] = row["address"];
                ws.Cells[index, 4] = row["houseState"];
                ws.Cells[index, 5] = row["cardCli"];
                ws.Cells[index, 6] = row["name"];
                ws.Cells[index, 7] = row["number"];
                ws.Cells[index, 8] = row["insDate"];

                index++;
            }

            wb.SaveAs(path);
            excel.Quit();
        }

        public static void ExportOrder(DataSet data)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.xls)|*.xls";
            save.ShowDialog();
            string path = save.FileName;

            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = excel.Workbooks.Add(true);
            Excel.Worksheet ws = wb.Worksheets[1];

            ws.Cells[1, 1] = "订单编号";
            ws.Cells[1, 2] = "交易房源编号";
            ws.Cells[1, 3] = "房源地址";
            ws.Cells[1, 4] = "房东编号";
            ws.Cells[1, 5] = "房东电话";
            ws.Cells[1, 6] = "房东名字";
            ws.Cells[1, 7] = "房客编号";
            ws.Cells[1, 8] = "房客电话";
            ws.Cells[1, 9] = "房客名字";
            ws.Cells[1, 10] = "交易类型";
            ws.Cells[1, 11] = "交易金额";
            ws.Cells[1, 12] = "交易时间";
            ws.Cells[1, 13] = "操作人";

            int index = 2;

            foreach(DataRow row in data.Tables[0].Rows)
            {
                ws.Cells[index, 1] = row["orderCard"];
                ws.Cells[index, 2] = row["houseCard"];
                ws.Cells[index, 3] = row["address"];
                ws.Cells[index, 4] = row["hostClient"];
                ws.Cells[index, 5] = row["hosetNumber"];
                ws.Cells[index, 6] = row["hosetName"];
                ws.Cells[index, 7] = row["guestClient"];
                ws.Cells[index, 8] = row["guestNumber"];
                ws.Cells[index, 9] = row["geustName"];
                ws.Cells[index, 10] = row["strType"];
                ws.Cells[index, 11] = row["factPrice"];
                ws.Cells[index, 12] = row["endDate"];
                ws.Cells[index, 13] = row["operateMan"];

                index++;
            }

            wb.SaveAs(path);
            excel.Quit();
        }
    }

    
}
