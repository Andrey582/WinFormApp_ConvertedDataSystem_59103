
namespace WinFormApp_ConvertedDataSystem_59103
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.Button_RunQuery = new System.Windows.Forms.Button();
            this.ListBox_Output = new System.Windows.Forms.ListBox();
            this.Output = new System.Windows.Forms.Label();
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.Button_Read = new System.Windows.Forms.Button();
            this.ListBox_Input = new System.Windows.Forms.ListBox();
            this.ComboBox_Tasks = new System.Windows.Forms.ComboBox();
            this.Input = new System.Windows.Forms.Label();
            this.groupBox_general.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            this.groupBox_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_general
            // 
            this.groupBox_general.Controls.Add(this.groupBox_output);
            this.groupBox_general.Controls.Add(this.groupBox_input);
            this.groupBox_general.Location = new System.Drawing.Point(12, 12);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Size = new System.Drawing.Size(615, 426);
            this.groupBox_general.TabIndex = 0;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "groupBox_общий";
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.Button_RunQuery);
            this.groupBox_output.Controls.Add(this.ListBox_Output);
            this.groupBox_output.Controls.Add(this.Output);
            this.groupBox_output.Location = new System.Drawing.Point(320, 15);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(295, 405);
            this.groupBox_output.TabIndex = 1;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "groupBox_Вывод";
            // 
            // Button_RunQuery
            // 
            this.Button_RunQuery.Location = new System.Drawing.Point(6, 365);
            this.Button_RunQuery.Name = "Button_RunQuery";
            this.Button_RunQuery.Size = new System.Drawing.Size(282, 29);
            this.Button_RunQuery.TabIndex = 2;
            this.Button_RunQuery.Text = "Выполнить запрос";
            this.Button_RunQuery.UseVisualStyleBackColor = true;
            this.Button_RunQuery.Click += new System.EventHandler(this.Button_RunQuery_Click);
            // 
            // ListBox_Output
            // 
            this.ListBox_Output.FormattingEnabled = true;
            this.ListBox_Output.ItemHeight = 15;
            this.ListBox_Output.Location = new System.Drawing.Point(6, 44);
            this.ListBox_Output.Name = "ListBox_Output";
            this.ListBox_Output.Size = new System.Drawing.Size(283, 304);
            this.ListBox_Output.TabIndex = 1;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(6, 19);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(145, 15);
            this.Output.TabIndex = 0;
            this.Output.Text = "Подсистема вычисления";
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.Button_Read);
            this.groupBox_input.Controls.Add(this.ListBox_Input);
            this.groupBox_input.Controls.Add(this.ComboBox_Tasks);
            this.groupBox_input.Controls.Add(this.Input);
            this.groupBox_input.Location = new System.Drawing.Point(6, 15);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(308, 405);
            this.groupBox_input.TabIndex = 0;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "groupBox_Ввод";
            // 
            // Button_Read
            // 
            this.Button_Read.Location = new System.Drawing.Point(6, 365);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(295, 30);
            this.Button_Read.TabIndex = 3;
            this.Button_Read.Text = "Считать данные";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // ListBox_Input
            // 
            this.ListBox_Input.FormattingEnabled = true;
            this.ListBox_Input.ItemHeight = 15;
            this.ListBox_Input.Location = new System.Drawing.Point(6, 76);
            this.ListBox_Input.Name = "ListBox_Input";
            this.ListBox_Input.Size = new System.Drawing.Size(295, 274);
            this.ListBox_Input.TabIndex = 2;
            // 
            // ComboBox_Tasks
            // 
            this.ComboBox_Tasks.FormattingEnabled = true;
            this.ComboBox_Tasks.Items.AddRange(new object[] {
            "Задание по умолчанию",
            "Задание по варианту"});
            this.ComboBox_Tasks.Location = new System.Drawing.Point(6, 37);
            this.ComboBox_Tasks.Name = "ComboBox_Tasks";
            this.ComboBox_Tasks.Size = new System.Drawing.Size(296, 23);
            this.ComboBox_Tasks.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(6, 19);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(172, 15);
            this.Input.TabIndex = 0;
            this.Input.Text = "Подсистема исходных данных";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.groupBox_general);
            this.Name = "Form_Main";
            this.Text = "Приложение для работы с LINQ-запросами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_output.ResumeLayout(false);
            this.groupBox_output.PerformLayout();
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.GroupBox groupBox_output;
        private System.Windows.Forms.Button Button_RunQuery;
        private System.Windows.Forms.ListBox ListBox_Output;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.ListBox ListBox_Input;
        private System.Windows.Forms.ComboBox ComboBox_Tasks;
        private System.Windows.Forms.Label Input;
    }
}

