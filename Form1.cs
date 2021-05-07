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
    public partial class Form_Main : Form
    {
        /// <summary>
        /// form's constants (постоянные класса формы)
        /// </summary>
        public const short MAX_NUM_OF_DICTIONARY_VALUES = 1000;
        /// <summary>
        /// application, book, list for active Excel's data
        /// (хэндл приложения, книги, листа данных пользователя Excel)
        /// </summary>
        private Excel.Application _xlsapp_App;
        private Excel.Workbook _xlsbook_Book;
        /// <summary>
        /// dictionary data to be extracted from Excel
        /// (данные словаря, извлекаемые из таблиц Excel)
        /// </summary>
        private string[] _str_data_values;
        private short _sh_data_count;
        /// <summary>
        /// input dictionary view
        /// (представление словаря входных данных)
        /// </summary>
        private short[] _sh_input_keys;
        private string[] _str_input_values;
        private short _sh_input_count;
        /// <summary>
        /// index of input tasks (индекс задания входных данных)
        /// </summary>
        private short _sh_input_task_index;
        /// <summary>
        ///  form constructor (конструктор формы)
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
            // empty data before filing (данных нет, пока они не будут заполнены)
            _sh_data_count = 0;
            _sh_input_count = 0;
            // allocation for addmissible range
            // (динамическое выделение памяти для разрешенного диапазона значений)
            _str_data_values = new string[MAX_NUM_OF_DICTIONARY_VALUES];
            _sh_input_keys = new short[MAX_NUM_OF_DICTIONARY_VALUES];
            _str_input_values = new string[MAX_NUM_OF_DICTIONARY_VALUES];
        }
        /// <summary>
        /// Form loading event (Событите при загрузке формы)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this._sh_input_task_index = 0;
            //this.ComboBox_Tasks.SelectedIndex = this._sh_input_task_index;
            this.Open_Excel();
            this.Read_Data(this._sh_input_task_index);
        }

        /// <summary>
        /// Stop & close Excel‐server at form closing
        /// (необходимо остановить и закрыть Excel‐сервер при закрытии формы)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close_Excel();
        }
        /// <summary>
        /// Read data using index task for input list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Read_Click(object sender, EventArgs e)
        {
            this.Read_Data(this._sh_input_task_index);
            this.ListBox_Input.Items.Clear();
            for (short sh_i = 0; sh_i < this._sh_input_count; sh_i++)
            {
                this.ListBox_Input.Items.Add(this._str_input_values[sh_i]);
            }
        }
        /// <summary>
        /// Run query filled in evaluate list if its possible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_RunQuery_Click(object sender, EventArgs e)
        {
            string[] str_values = new string[this._sh_input_count];
            for (short sh_i = 0; sh_i < this._sh_input_count; sh_i++)
            {
                str_values[sh_i] = this._str_input_values[sh_i];
            }
            this.ListBox_Output.Items.Clear();
            this.ListBox_Output.Items.Add((string)"‐‐‐ v_sampling ‐‐‐");
            if (ComboBox_Tasks.SelectedIndex == 0)
            {
                var v_sampling = 
                    from strs in str_values
                    where (IsCorrespond(strs, (string)"ы", 7, 0) &&
                    IsCorrespond(strs, (string)"а", 0, 15)) ||
                    IsCorrespond(strs, (string)"С", 6, 8)
                    orderby strs ascending
                    select strs;
                foreach (var v_i in v_sampling)
                {
                    this.ListBox_Output.Items.Add(v_i);
                }
            }
            else
            {
                var v_sampling =
                    from strs in str_values
                    where (IsCorrespond(strs, (string)"н", 0, 7)) ||
                    IsCorrespond(strs, (string)"к", 5, 0) ||
                    IsCorrespond(strs, (string)"в", 0, 7)
                    orderby strs ascending
                    select strs;
                foreach (var v_i in v_sampling)
                {
                    this.ListBox_Output.Items.Add(v_i);
                }
            }

            this.ListBox_Output.Items.Add((string)"‐‐‐ v_subsampling ‐‐‐");
            //      foreach(var v_i in v_subsampling)
            //      {
            //        this.ListBox_Output.Items.Add(v_i);
            //      }
        }
    }
}