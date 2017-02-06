namespace SudokuSolver
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBigTask = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(462, 420);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "";
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(487, 12);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(75, 23);
            this.btnReduce.TabIndex = 1;
            this.btnReduce.Text = "Reduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(487, 41);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBigTask
            // 
            this.btnBigTask.Location = new System.Drawing.Point(487, 70);
            this.btnBigTask.Name = "btnBigTask";
            this.btnBigTask.Size = new System.Drawing.Size(75, 23);
            this.btnBigTask.TabIndex = 1;
            this.btnBigTask.Text = "Big Task";
            this.btnBigTask.UseVisualStyleBackColor = true;
            this.btnBigTask.Click += new System.EventHandler(this.btnBigTask_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(487, 99);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 458);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnBigTask);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBigTask;
        private System.Windows.Forms.Button btnComplete;
    }
}

