using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace CourseSchedulingProject
{
    public class CourseDataReader
    {
        /// <summary>
        /// 讀Excel檔案中某一Sheet內容，將其儲存入一個DataTable物件並回傳(要存取的欄位由List清單提供)
        /// </summary>
        /// <param name="_excelFilePath"></param>
        /// <param name="sheetNameToBeRead"></param>
        /// <param name="necessaryColumnName_list"></param>
        /// <param name="outputTableName"></param>
        /// <returns></returns>
        public static DataTable GetExcelContent(string _excelFilePath, string sheetNameToBeRead, List<string> necessaryColumnName_list, string outputTableName = "")
        {
            if (outputTableName.Length == 0)
            {
                FileInfo fi = new FileInfo(_excelFilePath);

                outputTableName = string.Format("{0}_{1}", Path.GetFileNameWithoutExtension(_excelFilePath), sheetNameToBeRead);
            }

            // 初始化 Excel 檔案物件
            FileStream excelFileObj = new FileStream(_excelFilePath, FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook = new XSSFWorkbook(excelFileObj);
            DataTable dt = new DataTable(outputTableName);

            // 從要求的欄位定義設定DataTable的欄位
            foreach (var _necessaryColumnName in necessaryColumnName_list)
            {
                dt.Columns.Add(_necessaryColumnName, typeof(String));
            }

            // 開始讀檔案
            for (int sheetIndex = 0; sheetIndex < workbook.Count; ++sheetIndex)
            {
                string thisSheetName = workbook.GetSheetName(sheetIndex);

                if (thisSheetName == sheetNameToBeRead)
                {
                    var sheet = workbook.GetSheet(thisSheetName);

                    List<string> columnNameInSheet_list = new List<string>();
                    Dictionary<int, int> sheetColumnIndex2tableColumnIndex = new Dictionary<int, int>();

                    for (int rowIndex = 0; rowIndex <= sheet.LastRowNum; rowIndex++)
                    {
                        IRow rowObj = sheet.GetRow(rowIndex);
                        /*
                        if (rowIndex != 0)
                        {
                            int cellIndex = 0;
                            //DataRow singleRow = dt.NewRow();

                            //IRow rowObj = sheet.GetRow(rowIndex);
                            for (int cell = 0; cell < columnNames_list.Count; ++cell)
                            {
                                ICell cellObj = rowObj.GetCell(cell, MissingCellPolicy.RETURN_NULL_AND_BLANK);
                                if (cellObj == null)
                                {
                                    Console.WriteLine("Warning: 第 {0} 行, 欄位'{1}' 資料有空白", row + 1, columnNames_list[cellIndex]);
                                    singleRow[columnNames_list[cellIndex]] = "";
                                }
                                else if (cellObj.CellType == CellType.String)
                                {
                                    //如果是字串型 就要取 StringCellValue  這屬性的值
                                    if (cellObj.StringCellValue.Length > 0)
                                    {
                                        singleRow[columnNames_list[cellIndex]] = cellObj.StringCellValue.Trim();
                                    }
                                    else
                                    {
                                        throw new Exception("資料欄位內容空白!");
                                    }
                                }
                                else if (cellObj.CellType == CellType.Numeric)
                                {
                                    //如果是數字型 就要取 NumericCellValue  這屬性的值
                                    if (cellObj.NumericCellValue.ToString().Length > 0)
                                    {
                                        singleRow[columnNames_list[cellIndex]] = cellObj.NumericCellValue.ToString().Trim();
                                    }
                                    else
                                    {
                                        throw new Exception("資料欄位內容空白!");
                                    }
                                }
                                else
                                {
                                    throw new Exception("資料欄位內容格式未知!");
                                }
                                ++cellIndex;
                            }

                            if (cellIndex == columnNames_list.Count)
                            {
                                dt.Rows.Add(singleRow);
                            }
                            else
                            {
                                throw new Exception(string.Format("第{0} 行，資料欄位數量少於 {0}", row + 1, columnNames_list.Count));
                            }
                        }
                        else
                        {
                            List<string> columnNames_tmp = new List<string>();
                            
                            int counter = 0;
                            foreach (ICell cell in rowObj.Cells)
                            {
                                if (cell.CellType == CellType.String)
                                {
                                    //如果是字串型 就要取 StringCellValue  這屬性的值
                                    if (cell.StringCellValue.Length > 0)
                                    {
                                        columnNames_tmp.Add(cell.StringCellValue);
                                        if (necessaryColumnName_list.Contains(cell.StringCellValue))
                                        {
                                            sheetColumnIndex2tableColumnIndex.Add(counter, necessaryColumnName_list.IndexOf(cell.StringCellValue));
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("column 名稱為空字串");
                                    }
                                }
                                else
                                {
                                    throw new Exception("此 column 格式非字串");
                                }
                            }

                            foreach (var _columnName in columnNames)
                            {
                                dt.Columns.Add(_columnName, typeof(String));
                                columnNames_list.Add(_columnName);
                            }
                            Console.WriteLine("總共有 {0} 欄位", dt.Columns.Count);
                            
                        }
                    */
                    }
                
                }
                else
                {
                    continue;
                }
            
            }



            return dt;
        }
    }
}
