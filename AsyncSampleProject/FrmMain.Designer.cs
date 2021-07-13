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
            this.WithoutAsync = new System.Windows.Forms.Button();
            this.WithAsync = new System.Windows.Forms.Button();
            this.TaskAwait = new System.Windows.Forms.Button();
            TaskWithoutAwait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskWithoutAwait
            // 
            TaskWithoutAwait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TaskWithoutAwait.Location = new System.Drawing.Point(340, 252);
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
            this.WithoutAsync.Location = new System.Drawing.Point(340, 71);
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
            this.WithAsync.Location = new System.Drawing.Point(340, 165);
            this.WithAsync.Name = "WithAsync";
            this.WithAsync.Size = new System.Drawing.Size(148, 50);
            this.WithAsync.TabIndex = 2;
            this.WithAsync.Text = "WithAsync";
            this.WithAsync.UseVisualStyleBackColor = true;
            this.WithAsync.Click += new System.EventHandler(this.WithAsync_Click);
            // 
            // TaskAwait
            // 
            this.TaskAwait.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskAwait.Location = new System.Drawing.Point(340, 354);
            this.TaskAwait.Name = "TaskAwait";
            this.TaskAwait.Size = new System.Drawing.Size(148, 56);
            this.TaskAwait.TabIndex = 4;
            this.TaskAwait.Text = "Task Await";
            this.TaskAwait.UseVisualStyleBackColor = true;
            this.TaskAwait.Click += new System.EventHandler(this.TaskAwait_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskAwait);
            this.Controls.Add(TaskWithoutAwait);
            this.Controls.Add(this.WithAsync);
            this.Controls.Add(this.WithoutAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WithoutAsync;
        private System.Windows.Forms.Button WithAsync;
        private System.Windows.Forms.Button TaskAwait;
    }
}

