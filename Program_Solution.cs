using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;//////////////////
using System.IO;///////////////////////////////////////////////
namespace WinFormApp_ConvertedDataSystem_59103
{
    public partial class Form_Main
    {
        /// <summary>
        /// Open Excel‐server
        /// </summary>
        public short Open_Excel()
        {
            // only for empty xls‐application (только если приложение xls еще не запущено для данного приложения)
            if (_xlsapp_App == null)
            {
                _xlsapp_App = new Excel.Application();
                string path = "C:\\Docs\\Software_Dictionary.xlsx";
                FileInfo fi = new FileInfo(path);
                // if fail is found (если файл существует и найден)
                if (fi.Exists)
                {
                    // COM‐initialization the Excel server (инициализация сервера xls для приложения через COM)
                    _xlsbook_Book = _xlsapp_App.Workbooks.Open(path);
                    //excelApp.Visible = true;
                    Excel.Sheets xlssheets_Sheets = _xlsbook_Book.Worksheets;
                    // read the 1‐st sheet data (считывание данных с 1‐го листа)
                    Excel.Worksheet xlsworksheet_FirstSheet = xlssheets_Sheets.get_Item(1);
                    _sh_data_count = 0;
                    for (short sh_iter = 1; sh_iter < MAX_NUM_OF_DICTIONARY_VALUES; sh_iter++)
                    {
                        string str_cell = "B" + sh_iter.ToString();
                        Excel.Range xlsrange_Range = xlsworksheet_FirstSheet.get_Range(str_cell, str_cell);
                        string str_value = Convert.ToString(xlsrange_Range.Value2);
                        // break if data is empty (завершение цикла, если получено пустое значение)
                        if (str_value == null)
                        {
                            break;
                        }
                        // else filing the vector data (иначе наполнение данных в вектор)
                        else
                        {
                            this._str_data_values[sh_iter - 1] = str_value;
                            this._sh_data_count++;
                        }
                    }
                    //MessageBox.Show(null, this._str_data_values[0], this._str_data_values[this._sh_data_count - 1], 0);
                }
                else
                {
                    FileStream file = File.Create(path);
                    MessageBox.Show(null, "Файл создан по пути \"" + path + "\", введите данные", "Ошибка", 0);
                }
            }
            // else failing due to replacing attempt (иначе ошибка из‐за попытки замещения)
            else
            {
                MessageBox.Show(null, "Новый сервер Excel не создан, т.к.выполняется рабочий сервер !", "Ошибка", 0);
            }
            return 0;
        }
        /// <summary>
        /// Close Excel‐server
        /// </summary>
        public void Close_Excel()
        {
            if (_xlsapp_App != null)
            {
                _xlsbook_Book.Close(0);
                _xlsapp_App.Quit();
                _xlsbook_Book = null;
                _xlsapp_App = null;
                GC.Collect();
            }
        }
        /// <summary>
        /// Scan all data from Excel‐server
        /// </summary>
        public short Read_Data(short sh_index_task)
        {/// BEGIN OF METHOD READ_DATA
            if (sh_index_task < 0 || (sh_index_task != 0 && sh_index_task >= this.ComboBox_Tasks.Items.Count))
                return -1;
            this.ComboBox_Tasks.SelectedIndex = sh_index_task;
            // read data in accordance with task
            switch (sh_index_task)
            {
                case 0:// get all data
                    for (short sh_i = 0; sh_i < this._sh_data_count; sh_i++)
                    {
                        this._sh_input_keys[sh_i] = sh_i;
                        this._str_input_values[sh_i] = this._str_data_values[sh_i];
                    }
                    this._sh_input_count = this._sh_data_count;
                    break;
                case 1:
                    break;
            }
            return 0;
        }/// END OF METHOD READ_DATA
        //‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
        public bool IsCorrespond(string str_query, string str_find, short sh_min_count, short sh_max_count)
        {
            if ((sh_min_count == 0 || sh_min_count < str_query.Count()) &&
                (sh_max_count == 0 || sh_max_count > str_query.Count()) &&
                (str_find == null || str_query.Contains(str_find)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ 
    }
}