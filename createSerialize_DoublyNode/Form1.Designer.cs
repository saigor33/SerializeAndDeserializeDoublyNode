namespace createSerialize_DoublyNode
{
    partial class Form_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_serializeList = new System.Windows.Forms.TextBox();
            this.btn_addItems = new System.Windows.Forms.Button();
            this.tbx_Orig_listNode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_new_listNode = new System.Windows.Forms.TextBox();
            this.tbx_textFile = new System.Windows.Forms.TextBox();
            this.btn_deserializeList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_serializeList
            // 
            this.tbx_serializeList.Location = new System.Drawing.Point(26, 283);
            this.tbx_serializeList.Multiline = true;
            this.tbx_serializeList.Name = "tbx_serializeList";
            this.tbx_serializeList.Size = new System.Drawing.Size(510, 136);
            this.tbx_serializeList.TabIndex = 0;
            // 
            // btn_addItems
            // 
            this.btn_addItems.Location = new System.Drawing.Point(115, 17);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Size = new System.Drawing.Size(337, 36);
            this.btn_addItems.TabIndex = 1;
            this.btn_addItems.Text = "Добавить 5 элементов и сериализовать";
            this.btn_addItems.UseVisualStyleBackColor = true;
            this.btn_addItems.Click += new System.EventHandler(this.btn_addItems_Click);
            // 
            // tbx_Orig_listNode
            // 
            this.tbx_Orig_listNode.Location = new System.Drawing.Point(26, 91);
            this.tbx_Orig_listNode.Multiline = true;
            this.tbx_Orig_listNode.Name = "tbx_Orig_listNode";
            this.tbx_Orig_listNode.Size = new System.Drawing.Size(510, 136);
            this.tbx_Orig_listNode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сериализованный список";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Связи полученного списка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_new_listNode
            // 
            this.tbx_new_listNode.Location = new System.Drawing.Point(592, 283);
            this.tbx_new_listNode.Multiline = true;
            this.tbx_new_listNode.Name = "tbx_new_listNode";
            this.tbx_new_listNode.Size = new System.Drawing.Size(511, 136);
            this.tbx_new_listNode.TabIndex = 0;
            // 
            // tbx_textFile
            // 
            this.tbx_textFile.Location = new System.Drawing.Point(592, 91);
            this.tbx_textFile.Multiline = true;
            this.tbx_textFile.Name = "tbx_textFile";
            this.tbx_textFile.Size = new System.Drawing.Size(511, 136);
            this.tbx_textFile.TabIndex = 0;
            // 
            // btn_deserializeList
            // 
            this.btn_deserializeList.Location = new System.Drawing.Point(681, 17);
            this.btn_deserializeList.Name = "btn_deserializeList";
            this.btn_deserializeList.Size = new System.Drawing.Size(338, 36);
            this.btn_deserializeList.TabIndex = 1;
            this.btn_deserializeList.Text = "Десериализовать файл";
            this.btn_deserializeList.UseVisualStyleBackColor = true;
            this.btn_deserializeList.Click += new System.EventHandler(this.btn_deserializeList_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Связи после десериализации";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(587, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Содержимое файла";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deserializeList);
            this.Controls.Add(this.tbx_textFile);
            this.Controls.Add(this.btn_addItems);
            this.Controls.Add(this.tbx_new_listNode);
            this.Controls.Add(this.tbx_Orig_listNode);
            this.Controls.Add(this.tbx_serializeList);
            this.Name = "Form_main";
            this.Text = "Проверка работы алгоритмов сериализации и десериализации двухсвязного списка";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_serializeList;
        private System.Windows.Forms.Button btn_addItems;
        private System.Windows.Forms.TextBox tbx_Orig_listNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_new_listNode;
        private System.Windows.Forms.TextBox tbx_textFile;
        private System.Windows.Forms.Button btn_deserializeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

