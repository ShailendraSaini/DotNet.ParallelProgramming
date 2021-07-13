namespace AsyncSampleProject
{
    partial class FrmMain
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
            System.Windows.Forms.Button TaskWithoutAwait;
            System.Windows.Forms.Button btnPrimeNo;
            this.WithoutAsync = new System.Windows.Forms.Button();
            this.WithAsync = new System.Windows.Forms.Button();
            this.TaskAwait = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listPrimeNos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            TaskWithoutAwait = new System.Windows.Forms.Button();
            btnPrimeNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskWithoutAwait
            // 
            TaskWithoutAwait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TaskWithoutAwait.Location = new System.Drawing.Point(28, 132);
            TaskWithoutAwait.Name = "TaskWithoutAwait";
            TaskWithoutAwait.Size = new System.Drawing.Size(148, 59);
            TaskWithoutAwait.TabIndex = 3;
            TaskWithoutAwait.Text = "TaskWithoutAwait";
            TaskWithoutAwait.UseVisualStyleBackColor = true;
            TaskWithoutAwait.Click += new System.EventHandler(this.Task_Click);
            // 
            // WithoutAsync
            // 
            this.WithoutAsync.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithoutAsync.Location = new System.Drawing.Point(28, 25);
            this.WithoutAsync.Name = "WithoutAsync";
            this.WithoutAsync.Size = new System.Drawing.Size(148, 58);
            this.WithoutAsync.TabIndex = 1;
            this.WithoutAsync.Text = "WithoutAsync";
            this.WithoutAsync.UseVisualStyleBackColor = true;
            this.WithoutAsync.Click += new System.EventHandler(this.WithoutAsync_Click);
            // 
            // WithAsync
            // 
            this.WithAsync.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithAsync.Location = new System.Drawing.Point(208, 25);
            this.WithAsync.Name = "WithAsync";
            this.WithAsync.Size = new System.Drawing.Size(148, 58);
            this.WithAsync.TabIndex = 2;
            this.WithAsync.Text = "WithAsync";
            this.WithAsync.UseVisualStyleBackColor = true;
            this.WithAsync.Click += new System.EventHandler(this.WithAsync_Click);
            // 
            // TaskAwait
            // 
            this.TaskAwait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskAwait.Location = new System.Drawing.Point(208, 132);
            this.TaskAwait.Name = "TaskAwait";
            this.TaskAwait.Size = new System.Drawing.Size(148, 59);
            this.TaskAwait.TabIndex = 4;
            this.TaskAwait.Text = "Task Await";
            this.TaskAwait.UseVisualStyleBackColor = true;
            this.TaskAwait.Click += new System.EventHandler(this.TaskAwait_Click);
            // 
            // btnPrimeNo
            // 
            btnPrimeNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPrimeNo.Location = new System.Drawing.Point(15, 296);
            btnPrimeNo.Name = "btnPrimeNo";
            btnPrimeNo.Size = new System.Drawing.Size(195, 30);
            btnPrimeNo.TabIndex = 5;
            btnPrimeNo.Text = "Check Prime Number";
            btnPrimeNo.UseVisualStyleBackColor = true;
            btnPrimeNo.Click += new System.EventHandler(this.btnPrimeNo_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 252);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(195, 38);
            this.txtInput.TabIndex = 6;
            this.txtInput.Text = "1,2,3,4,5,6,7,11,18,19,24,25,26,28,35,37,39";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter comma seperated list of numbers :";
            // 
            // listPrimeNos
            // 
            this.listPrimeNos.FormattingEnabled = true;
            this.listPrimeNos.Location = new System.Drawing.Point(253, 257);
            this.listPrimeNos.Name = "listPrimeNos";
            this.listPrimeNos.Size = new System.Drawing.Size(120, 69);
            this.listPrimeNos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prime Numbers :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(230, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPrimeNos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(btnPrimeNo);
            this.Controls.Add(this.TaskAwait);
            this.Controls.Add(TaskWithoutAwait);
            this.Controls.Add(this.WithAsync);
            this.Controls.Add(this.WithoutAsync);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WithoutAsync;
        private System.Windows.Forms.Button WithAsync;
        private System.Windows.Forms.Button TaskAwait;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listPrimeNos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

