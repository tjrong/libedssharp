namespace ODEditor
{
    partial class NewIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewIndex));
            this.radioButton_var = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_record = new System.Windows.Forms.RadioButton();
            this.radioButton_array = new System.Windows.Forms.RadioButton();
            this.numericUpDown_index = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_index)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_var
            // 
            this.radioButton_var.AutoSize = true;
            this.radioButton_var.Checked = true;
            this.radioButton_var.Location = new System.Drawing.Point(6, 18);
            this.radioButton_var.Name = "radioButton_var";
            this.radioButton_var.Size = new System.Drawing.Size(41, 16);
            this.radioButton_var.TabIndex = 0;
            this.radioButton_var.TabStop = true;
            this.radioButton_var.Text = "VAR";
            this.radioButton_var.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_record);
            this.groupBox1.Controls.Add(this.radioButton_array);
            this.groupBox1.Controls.Add(this.radioButton_var);
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Type";
            // 
            // radioButton_record
            // 
            this.radioButton_record.AutoSize = true;
            this.radioButton_record.Location = new System.Drawing.Point(6, 60);
            this.radioButton_record.Name = "radioButton_record";
            this.radioButton_record.Size = new System.Drawing.Size(59, 16);
            this.radioButton_record.TabIndex = 2;
            this.radioButton_record.Text = "RECORD";
            this.radioButton_record.UseVisualStyleBackColor = true;
            // 
            // radioButton_array
            // 
            this.radioButton_array.AutoSize = true;
            this.radioButton_array.Location = new System.Drawing.Point(6, 39);
            this.radioButton_array.Name = "radioButton_array";
            this.radioButton_array.Size = new System.Drawing.Size(53, 16);
            this.radioButton_array.TabIndex = 1;
            this.radioButton_array.Text = "ARRAY";
            this.radioButton_array.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_index
            // 
            this.numericUpDown_index.Hexadecimal = true;
            this.numericUpDown_index.Location = new System.Drawing.Point(97, 19);
            this.numericUpDown_index.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_index.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_index.Name = "numericUpDown_index";
            this.numericUpDown_index.Size = new System.Drawing.Size(101, 21);
            this.numericUpDown_index.TabIndex = 1;
            this.numericUpDown_index.Value = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index (hex)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(97, 50);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(241, 21);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Text = "New Object";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(23, 188);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(108, 34);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(180, 188);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(108, 34);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // NewIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_index);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewIndex";
            this.Text = "Create new OD Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_var;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_record;
        private System.Windows.Forms.RadioButton radioButton_array;
        private System.Windows.Forms.NumericUpDown numericUpDown_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_cancel;
    }
}